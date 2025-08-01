﻿// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;
using ProtoBuf.Meta;
using System.Reflection;

namespace Hiperspace
{
    public static class Space
    {
        public static ValueTuple<byte[], byte[]> FindBytes(byte[] source, (int key, (int member, int key)[] values)[] map)
        {
            var find = Vpl2f(source, map);
            return (find.begin, find.end);
        }
        public static ValueTuple<byte[], byte[]> ScanBytes(byte[] source, (int key, (int member, int key)[] values)[] map)
        {
            var find = Vpl2s(source, map);
            return (find.begin, find.end);
        }
        public static byte[] KeyBytes<TProto>(TypeModel? model, TProto proto, (int key, (int member, int key)[] values)[] map)
        {
            if (model == null) throw new TypeModelException();
            var ms = new MemoryStream();
            model.Serialize(ms, proto); 
            ms.Position = 0;
            var key = ms.ToArray();
            var vpl = Lpv2Vpl(key, map);
#if DEBUG
            var lpv = Vpl2lpv(vpl, map);
            System.Diagnostics.Debug.Assert(key.SequenceEqual(lpv));
#endif
            return vpl;
        }
        public static byte[] VectorKeyBytes<TProto>(TypeModel? model, TProto proto, (int key, (int member, int key)[] values)[] map)
        {
            if (model == null) throw new TypeModelException();
            var bytes = KeyBytes(model, proto, map);
            var result = new byte[bytes.Length + 1];
            var span = new Span<byte>(result, 1, bytes.Length);
            bytes.CopyTo(span);
            return result;
        }
        public static byte[] ValueBytes<TProto>(TypeModel? model, TProto proto, bool eof = false)
        {
            if (model == null) throw new TypeModelException();
            var ms = new MemoryStream();
            model.Serialize(ms, proto);
            ms.Position = 0;
            return ms.ToArray();
        }
        public static TProto FromKey<TProto>(TypeModel? model, byte[] bytes, (int key, (int member, int key)[] values)[] map)
        {
            try
            {
                if (model == null) throw new TypeModelException();
                var lpv = Vpl2lpv(bytes, map);
                var protoStream = new MemoryStream(lpv);
                protoStream.Position = 0;
                var key = model.Deserialize<TProto>(protoStream);
                return key;
            }
            catch (Exception ex)
            {
                throw new DataMapException(typeof(TProto), bytes, ex);
            }
        }
        public static TProto FromVectorKey<TProto>(TypeModel? model, byte[] bytes, (int key, (int member, int key)[] values)[] map)
        {
            try
            {
                if (model == null) throw new TypeModelException();
                var result = new byte[bytes.Length - 1];
                var span = new Span<byte>(bytes, 1, bytes.Length - 1);
                span.CopyTo(result);
                return FromKey<TProto>(model, result, map);
            }
            catch (Exception ex)
            {
                throw new DataMapException(typeof(TProto), bytes, ex);
            }
        }
        public static TProto FromValue<TProto>(TypeModel? model, byte[] bytes)
        {
            if (model == null) throw new TypeModelException();
            var protoStream = new MemoryStream(bytes);
            protoStream.Position = 0;
            return model.Deserialize<TProto>(protoStream);
        }
        public static (TKey, TValue) From<TKey, TValue>(TypeModel model, byte[] Key, byte[] Value)
        {
            var keyStream = new MemoryStream(Key);
            var valueStream = new MemoryStream(Value);
            return
                (
                    model.Deserialize<TKey>(keyStream),
                    model.Deserialize<TValue>(valueStream)
                );
        }

        const byte icont  = 0b1000_0000;
        const byte ival   = 0b0111_1111;
        const byte btype  = 0b0000_0111;

        /// <summary>
        /// Convert length prefixed value to value prefix length to allow ordered search
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
                    case 0 when p == 0:     // special case of VectorSpace keys
                        s++; p++;
                        break;
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
                        var tspan = new Span<byte>(bytes, s, sizeof(Int64));
                        var sspan = new Span<byte>(bytes, p, sizeof(Int64));
                        sspan.CopyTo(tspan);
                        s += sizeof(Int64);
                        p += sizeof(Int64);
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
                            tspan = new Span<byte>(bytes, s, totlen);
                            sspan = new Span<byte>(source, p, totlen);
                            sspan.CopyTo(tspan);
                            s += totlen;
                            p += totlen;
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
                    case 0 when p == 0:     // special case of VectorSpace keys
                        s++; p++;
                        break;
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
                        if (s + sizeof(Int64) > source.Length) return new byte[source.Length];
                        var tspan = new Span<byte>(bytes, s, sizeof(Int64));
                        var sspan = new Span<byte>(bytes, p, sizeof(Int64));
                        sspan.CopyTo(tspan);
                        s += sizeof(Int64);
                        p += sizeof(Int64);
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
                            tspan = new Span<byte>(bytes, s, totlen);
                            sspan = new Span<byte>(source, p, totlen);
                            sspan.CopyTo(tspan);
                            s += totlen;
                            p += totlen;
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
                    case 0 when p == 0:     // special case of VectorSpace keys
                        s++; p++;
                        break;
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
                        var tspan = new Span<byte>(bytes, s, sizeof(Int64));
                        var sspan = new Span<byte>(bytes, p, sizeof(Int64));
                        sspan.CopyTo(tspan);
                        s += sizeof(Int64);
                        p += sizeof(Int64);
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
                            tspan = new Span<byte>(bytes, s, totlen);
                            sspan = new Span<byte>(source, p, totlen);
                            sspan.CopyTo(tspan);
                            s += totlen;
                            p += totlen;
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
            bytes.CopyTo(other, 0);
            while (++e < other.Length) other[e] = 0xFF;
            return (bytes, other);
        }
        /// <summary>
        /// For scan, we are only intereted in the first field
        /// </summary>
        /// <param name="source">source stream serialized to protobuf</param>
        /// <param name="metadata">metadata for nested fields</param>
        /// <returns>scan range to first buffer</returns>
        public static (byte[] begin, byte[] end) Vpl2s(byte[] source, (int key, (int member, int key)[] values)[] metadata)
        {
            if (source.Length == 0) return (source, source);
            var meta = new MetaMap(metadata, source.Length);
            byte[] bytes = new byte[source.Length];
            byte[] other = new byte[source.Length];
            int s = 0;
            int p = 0;
            int e = source.Length - 1;
            bool finding = true;
            while (e >= s && p < source.Length && finding)
            {
                meta.PopIf(p);
                switch (source[p] & btype)
                {
                    case 0 when p == 0:     // special case of VectorSpace keys
                        s++; p++;
                        break;
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
                        var tspan = new Span<byte>(bytes, s, sizeof(Int64));
                        var sspan = new Span<byte>(bytes, p, sizeof(Int64));
                        sspan.CopyTo(tspan);
                        s += sizeof(Int64);
                        p += sizeof(Int64);
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
                            tspan = new Span<byte>(bytes, s, totlen);
                            sspan = new Span<byte>(source, p, totlen);
                            sspan.CopyTo(tspan);
                            s += totlen;
                            p += totlen;
                        }
                        else
                            finding = false;
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
            bytes.CopyTo(other, 0);
            while (p < other.Length) other[p++] = 0xFF;
            return (bytes, other);
        }
        /// <summary>
        /// Get they key type from the source for delta search
        /// </summary>
        /// <param name="source">source stream serialized to protobuf</param>
        /// <returns>keytype followed by 0xFF</returns>
        public static byte[] DeltaKey(byte[] source)
        {
            if (source.Length == 0) return source;
            byte[] bytes = new byte[source.Length];
            int s = 1;
            int p = 0;
            bool searchkey = true;
            while (p < source.Length && searchkey)
            {
                switch (source[p] & btype)
                {
                    case 0 when p == 0:     // special case of VectorSpace keys
                        s++; p++;
                        break;
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
                        var tspan = new Span<byte>(bytes, s, sizeof(Int64));
                        var sspan = new Span<byte>(bytes, p, sizeof(Int64));
                        sspan.CopyTo(tspan);
                        s += sizeof(Int64);
                        p += sizeof(Int64);
                        break;
                    case 2: // LEN prefixed value
                        int id = (source[p] & ival) >> 3;
                        int shift = 4;
                        while ((source[p] & icont) == icont)  // copy varint
                        {
                            bytes[s++] = source[p++];
                            id += (source[p] & ival) << shift;
                            shift += 4;
                        }
                        bytes[s++] = source[p++];
                        searchkey = false;
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
            while (s < bytes.Length) bytes[s++] = 0xFF;
            return bytes;
        }
    }
}
