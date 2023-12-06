// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;

namespace Hiperspace
{
    public static class Space
    {
        public static ValueTuple<byte[], byte[]> FindBytes(byte[] source, (int key, (int member, int key)[] values)[] map)
        {
            var find = Vpl2f(source, map);
            return (find.begin, find.end);
        }
        
        public static byte[] KeyBytes<TProto>(TProto proto, (int key, (int member, int key)[] values)[] map)
        {
            var ms = new MemoryStream();
            Serializer.Serialize(ms, proto);
            ms.Position = 0;
            var key = ms.ToArray();
            var vpl = Lpv2Vpl(key, map);
#if DEBUG
            var lpv = Vpl2lpv(vpl, map);
            System.Diagnostics.Debug.Assert(key.SequenceEqual(lpv));
#endif
            return vpl;
        }
        public static byte[] ValueBytes<TProto>(TProto proto, bool eof = false)
        {
            var ms = new MemoryStream();
            Serializer.Serialize(ms, proto);
            ms.Position = 0;
            return ms.ToArray();
        }
        public static TProto FromKey<TProto>(byte[] bytes, (int key, (int member, int key)[] values)[] map)
        {
            var lpv = Vpl2lpv(bytes, map);
            var protoStream = new MemoryStream(lpv);
            protoStream.Position = 0;
            var key = Serializer.Deserialize<TProto>(protoStream);
            return key;
        }
        public static TProto FromValue<TProto>(byte[] bytes)
        {
            var protoStream = new MemoryStream(bytes);
            protoStream.Position = 0;
            return Serializer.Deserialize<TProto>(protoStream);
        }
        public static (TKey, TValue) From<TKey,TValue>(byte[] Key, byte[] Value)
        {
            var keyStream = new MemoryStream(Key);
            var valueStream = new MemoryStream(Value);
            return 
                (
                    Serializer.Deserialize<TKey>(keyStream),
                    Serializer.Deserialize<TValue>(valueStream)
                );
        }

        const byte icont  = 0b1000_0000;
        const byte ival   = 0b0111_1111;
        const byte btype  = 0b0000_0111;

        /// <summary>
        /// Convert length prefixed value to value prefix length to allow ordeed search
        /// </summary>
        /// <remarks>
        /// only the top level lengths are reordered
        /// </remarks>
        /// <param name="source"></param>
        /// <returns></returns>
        public static byte[] Lpv2Vpl(byte[] source, (int key, (int member, int key)[] values)[] metadata)
        {
            if (source.Length == 0) return source;
            var meta = new MetaMap(metadata, source.Length);
            byte[] bytes = new byte[source.Length];
            int s = 0;
            int p = 0;
            int e = source.Length - 1;
            while (e >= s && p < source.Length)
            {
                meta.PopIf(p);
                switch (source[p] & btype)
                {
                    case 0: //varint
                        while ((source[p] & icont) == icont)
                        {
                            bytes[s++] = source[p++];
                        }
                        bytes[s++] = source[p++];
                        // copy value
                        while ((source[p] & icont) == icont)
                        {
                            bytes[s++] = source[p++];
                        }
                        bytes[s++] = source[p++];
                        break;
                    case 1: // I64
                        for (int c = 0; c < 9; c++)
                        {
                            bytes[s++] = source[p++];
                        }
                        break;
                    case 2: // LEN prefixed value
                        int id = (source[p] & ival) >> 3;
                        int shift = 4;
                        int totlen = 0;
                        while ((source[p] & icont) == icont)  // copy varint
                        {
                            bytes[s++] = source[p++];
                            id += (source[p] & ival) << shift;
                            shift += 4;
                        }
                        bytes[s++] = source[p++];
                        // copy LEN field to the end of the buffer
                        int len = source[p] & ival;
                        shift = 4;
                        while ((source[p] & icont) == icont)
                        {
                            len += (source[p] & ival) << shift;
                            shift += 4;
                            bytes[e--] = source[p++];
                            totlen--;
                        }
                        totlen += len;
                        bytes[e--] = source[p++];
                        // is not a nested message
                        if (!meta.Next(id, p + totlen))
                        {
                            // copy the length prefixed field
                            while (totlen-- != 0)
                            {
                                bytes[s++] = source[p++];
                            }
                        }
                        break;
                    case 5: // I32
                        for (int c = 0; c < 5; c++)
                        {
                            bytes[s++] = source[p++];
                        }
                        break;
                    default: // others copy
                        bytes[s++] = source[p++];
                        break;
                }
            }
            return bytes;
        }

        /// <summary>
        /// Convert value prefixed length to length  prefix value for deserialisation
        /// </summary>
        /// <remarks>
        /// only the top level lengths are reordered
        /// </remarks>
        /// <param name="source"></param>
        /// <returns></returns>
        public static byte[] Vpl2lpv(byte[] source, (int key, (int member, int key)[] values)[] metadata)
        {
            if (source.Length == 0) return source;
            var meta = new MetaMap(metadata, source.Length);
            byte[] bytes = new byte[source.Length];
            int s = 0;
            int p = 0;
            int e = source.Length - 1;
            while (s <= source.Length - 1 && p < e)
            {
                meta.PopIf(p);
                switch (source[p] & btype)
                {
                    case 0: //varint
                        while ((source[p] & icont) == icont)
                        {
                            bytes[s++] = source[p++];
                        }
                        bytes[s++] = source[p++];
                        // copy value
                        while ((source[p] & icont) == icont)
                        {
                            bytes[s++] = source[p++];
                        }
                        bytes[s++] = source[p++];
                        break;
                    case 1: // I64
                        for (int c = 0; c < 9; c++)
                        {
                            bytes[s++] = source[p++];
                        }
                        break;
                    case 2: // LEN prefixed value
                        int id = (source[p] & ival) >> 3;
                        int shift = 4;
                        int totlen = 0;
                        while ((source[p] & icont) == icont) // copy varint
                        {
                            bytes[s++] = source[p++];
                            id += (source[p] & ival) << shift;
                            shift += 4;
                        }
                        bytes[s++] = source[p++];
                        int len = source[e] & ival;
                        shift = 4;
                        // copy LEN field from the end of the buffer
                        while ((source[e] & icont) == icont)
                        {
                            len += (source[e] & ival) << shift;
                            shift += 4;
                            bytes[s++] = source[e--];
                            totlen--;
                        }
                        totlen += len;
                        bytes[s++] = source[e--];
                        // is a nested message
                        if (!meta.Next(id, p + totlen))
                        {
                            // copy the length prefixed field
                            while (totlen-- != 0)
                            {
                                bytes[s++] = source[p++];
                            }
                        }
                        break;
                    case 5: // I32
                        for (int c = 0; c < 5; c++)
                        {
                            bytes[s++] = source[p++];
                        }
                        break;
                    default: // others copy
                        bytes[s++] = source[p++];
                        break;
                }
            }
            return bytes;
        }
        public static (byte[] begin, byte[] end) Vpl2f(byte[] source, (int key, (int member, int key)[] values)[] metadata)
        {
            if (source.Length == 0) return (source, source);
            var meta = new MetaMap(metadata, source.Length);
            byte[] bytes = new byte[source.Length];
            byte[] other = new byte[source.Length];
            int s = 0;
            int p = 0;
            int e = source.Length - 1;
            while (e >= s && p < source.Length)
            {
                meta.PopIf(p);
                switch (source[p] & btype)
                {
                    case 0: //varint
                        while ((source[p] & icont) == icont)
                        {
                            bytes[s++] = source[p++];
                        }
                        bytes[s++] = source[p++];
                        // copy value
                        while ((source[p] & icont) == icont)
                        {
                            bytes[s++] = source[p++];
                        }
                        bytes[s++] = source[p++];
                        break;
                    case 1: // I64
                        for (int c = 0; c < 9; c++)
                        {
                            bytes[s++] = source[p++];
                        }
                        break;
                    case 2: // LEN prefixed value
                        int totlen = 0;
                        int id = (source[p] & ival) >> 3;
                        int shift = 4;
                        while ((source[p] & icont) == icont) // copy varint
                        {
                            bytes[s++] = source[p++];
                            id += (source[p] & ival) << shift;
                            shift += 4;
                        }
                        bytes[s++] = source[p++];
                        int len = source[e] & ival;
                        shift = 4;
                        // copy LEN field from the end of the buffer
                        while ((source[e] & icont) == icont)
                        {
                            len += (source[p] & ival) << shift;
                            shift += 4;
                            bytes[e--] = 0x00;
                            totlen--;
                        }
                        totlen += len;
                        bytes[e--] = 0x00;
                        if (!meta.Next(id, p + totlen))
                        {
                            // copy the length prefixed field
                            while (totlen-- != 0)
                            {
                                bytes[s++] = source[p++];
                            }
                        }
                        break;
                    case 5: // I32
                        for (int c = 0; c < 5; c++)
                        {
                            bytes[s++] = source[p++];
                        }
                        break;
                    default: // others copy
                        bytes[s++] = source[p++];
                        break;
                }
            }
            bytes.CopyTo(other,0);
            while (++e < other.Length) other[e] = 0xFF;
            return (bytes,other);
        }
    }
}
