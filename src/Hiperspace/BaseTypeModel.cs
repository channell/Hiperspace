using Graph;
using Hiperspace.Meta;
using ProtoBuf;
using ProtoBuf.Meta;
using ProtoBuf.Serializers;

namespace Hiperspace;

public class BaseTypeModel 
    : TypeModel
    , ISerializer<Alias> 
    , ISerializer<Element> 
    , ISerializer<Field> 
    , ISerializer<MetaModel> 
    , ISerializer<Name> 
    , ISerializer<Relation>
    , ISerializer<Edge.KeyType>
    , ISerializer<Edge.ValueType>
    , ISerializer<KeyRef<Edge.KeyType, Edge>>
    , ISerializer<Edge>
    , ISerializer<Node.KeyType>
    , ISerializer<Node.ValueType>
    , ISerializer<KeyRef<Node.KeyType, Node>>
    , ISerializer<Node>
    , ISerializer<Vector> 
    , ISerializer<VectorNode.KeyType> 
    , ISerializer<VectorNode.ValueType>
    , ISerializer<Graph.Route>
    , ISerializer<Graph.Rule>
    , ISerializer<Graph.HiperEdge.KeyType>
    , ISerializer<Graph.HiperEdge.ValueType>
    , ISerializer<KeyRef<Graph.HiperEdge.KeyType, Graph.HiperEdge>>
    , ISerializer<Graph.HiperEdge>
{
    public SerializerFeatures Features => SerializerFeatures.CategoryMessage;

    Alias ISerializer<Alias>.Read(ref ProtoReader.State state, Alias value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {
                case 1:
                    {
                        string text = state.ReadString(null);
                        if (text != null)
                        {
                            value.Name = text;
                        }
                        break;
                    }
                case 2:
                    {
                        Relation[] parameters = value.Parameters;
                        parameters = RepeatedSerializer.CreateVector<Relation>().ReadRepeated(ref state, (SerializerFeatures)146, parameters, this);
                        if (parameters != null)
                        {
                            value.Parameters = parameters;
                        }
                        break;
                    }
                case 3:
                    {
                        int id = state.ReadInt32();
                        value.Id = id;
                        break;
                    }
                default:
                    state.SkipField();
                    break;
            }
        }
        return value;
    }

    void ISerializer<Alias>.Write(ref ProtoWriter.State state, Alias value)

    {
        string name = value.Name;
        state.WriteString(1, name, null);
        Relation[] parameters = value.Parameters;
        if (parameters != null)
        {
            Relation[] array = parameters;
            RepeatedSerializer.CreateVector<Relation>().WriteRepeated(ref state, 2, (SerializerFeatures)146, array, this);
        }
        int id = value.Id;
        if (id != 0)
        {
            state.WriteInt32Varint(3, id);
        }
    }
    Element ISerializer<Element>.Read(ref ProtoReader.State state, Element value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {
                case 1:
                    {
                        Name name = value.Name;
                        name = state.ReadMessage(0, name, this);
                        value.Name = name;
                        break;
                    }
                case 2:
                    {
                        string text = state.ReadString(null);
                        if (text != null)
                        {
                            value.Category = text;
                        }
                        break;
                    }
                case 3:
                    {
                        Field[] values = value.Keys;
                        values = RepeatedSerializer.CreateVector<Field>().ReadRepeated(ref state, (SerializerFeatures)146, values, this);
                        if (values != null)
                        {
                            value.Keys = values;
                        }
                        break;
                    }
                case 4:
                    {
                        Field[] values = value.Values;
                        values = RepeatedSerializer.CreateVector<Field>().ReadRepeated(ref state, (SerializerFeatures)146, values, this);
                        if (values != null)
                        {
                            value.Values = values;
                        }
                        break;
                    }
                case 5:
                    {
                        Alias[] index = value.Index;
                        index = RepeatedSerializer.CreateVector<Alias>().ReadRepeated(ref state, (SerializerFeatures)146, index, this);
                        if (index != null)
                        {
                            value.Index = index;
                        }
                        break;
                    }
                case 6:
                    {
                        int id = state.ReadInt32();
                        value.Id = id;
                        break;
                    }
                case 7:
                    {
                        bool versioned = state.ReadBoolean();
                        value.Versioned = versioned;
                        break;
                    }
                default:
                    state.SkipField();
                    break;
            }
        }
        return value;
    }

    void ISerializer<Element>.Write(ref ProtoWriter.State state, Element value)
    {
        Name name = value.Name;
        state.WriteMessage(1, 0, name, this);
        string category = value.Category;
        state.WriteString(2, category, null);
        Field[] keys = value.Keys;
        if (keys != null)
        {
            Field[] array = keys;
            RepeatedSerializer.CreateVector<Field>().WriteRepeated(ref state, 3, (SerializerFeatures)146, array, this);
        }
        Field[] values = value.Values;
        if (values != null)
        {
            Field[] array = values;
            RepeatedSerializer.CreateVector<Field>().WriteRepeated(ref state, 4, (SerializerFeatures)146, array, this);
        }
        Alias[] index = value.Index;
        if (index != null)
        {
            Alias[] array2 = index;
            RepeatedSerializer.CreateVector<Alias>().WriteRepeated(ref state, 5, (SerializerFeatures)146, array2, this);
        }
        int id = value.Id;
        if (id != 0)
        {
            state.WriteInt32Varint(6, id);
        }
        bool versioned = value.Versioned;
        if (versioned)
        {
            state.WriteFieldHeader(7, 0);
            state.WriteBoolean(versioned);
        }
    }
    Field ISerializer<Field>.Read(ref ProtoReader.State state, Field value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {
                case 1:
                    {
                        string text = state.ReadString(null);
                        if (text != null)
                        {
                            value.Name = text;
                        }
                        break;
                    }
                case 2:
                    {
                        Name dataType = value.DataType;
                        dataType = state.ReadMessage(0, dataType, this);
                        value.DataType = dataType;
                        break;
                    }
                case 3:
                    {
                        int id = state.ReadInt32();
                        value.Id = id;
                        break;
                    }
                default:
                    state.SkipField();
                    break;
            }
        }
        return value;
    }

    void ISerializer<Field>.Write(ref ProtoWriter.State state, Field value)
    {
        string name = value.Name;
        state.WriteString(1, name, null);
        Name dataType = value.DataType;
        state.WriteMessage(2, 0, dataType, this);
        int id = value.Id;
        if (id != 0)
        {
            state.WriteInt32Varint(3, id);
            state.WriteAny(3, id);
        }
    }

    MetaModel ISerializer<MetaModel>.Read(ref ProtoReader.State state, MetaModel value)
    {
        if (value == null)
        {
            MetaModel val = new MetaModel();
            value = val;
        }
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            if (num == 1)
            {
                Element[]? elements = value.Elements;
                elements = RepeatedSerializer.CreateVector<Element>().ReadRepeated(ref state, (SerializerFeatures)146, elements, this);
                if (elements != null)
                {
                    value.Elements = elements;
                }
            }
            else
            {
                state.SkipField();
            }
        }
        return value;
    }

    void ISerializer<MetaModel>.Write(ref ProtoWriter.State state, MetaModel value)
    {
        ThrowUnexpectedSubtype(value);
        Element[]? elements = value.Elements;
        if (elements != null)
        {
            Element[] array = elements;
            RepeatedSerializer.CreateVector<Element>().WriteRepeated(ref state, 1, (SerializerFeatures)146, array, this);
        }
    }


    Name ISerializer<Name>.Read(ref ProtoReader.State state, Name value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {
                case 1:
                    {
                        string text = state.ReadString(null);
                        if (text != null)
                        {
                            value.Reference = text;
                        }
                        break;
                    }
                case 2:
                    {
                        Name[] parameters = value.Parameters;
                        parameters = RepeatedSerializer.CreateVector<Name>().ReadRepeated(ref state, (SerializerFeatures)146, parameters, this);
                        if (parameters != null)
                        {
                            value.Parameters = parameters;
                        }
                        break;
                    }
                default:
                    state.SkipField();
                    break;
            }
        }
        return value;
    }

    void ISerializer<Name>.Write(ref ProtoWriter.State state, Name value)
    {
        string reference = value.Reference;
        state.WriteString(1, reference, null);
        Name[] parameters = value.Parameters;
        if (parameters != null)
        {
            Name[] array = parameters;
            RepeatedSerializer.CreateVector<Name>().WriteRepeated(ref state, 2, (SerializerFeatures)146, array, this);
        }
    }


    Relation ISerializer<Relation>.Read(ref ProtoReader.State state, Relation value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {
                case 1:
                    {
                        string text = state.ReadString(null);
                        if (text != null)
                        {
                            value.Name = text;
                        }
                        break;
                    }
                case 2:
                    {
                        Name dataType = value.DataType;
                        dataType = state.ReadMessage(0, dataType, this);
                        value.DataType = dataType;
                        break;
                    }
                case 3:
                    {
                        int id = state.ReadInt32();
                        value.Id = id;
                        break;
                    }
                default:
                    state.SkipField();
                    break;
            }
        }
        return value;
    }

    void ISerializer<Relation>.Write(ref ProtoWriter.State state, Relation value)
    {
        string name = value.Name;
        state.WriteString(1, name, null);
        Name dataType = value.DataType;
        state.WriteMessage(2, 0, dataType, this);
        int id = value.Id;
        if (id != 0)
        {
            state.WriteInt32Varint(3, id);
        }
    }

    Edge.KeyType ISerializer<Edge.KeyType>.Read(ref ProtoReader.State state, Edge.KeyType value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {
                case 2:
                    {
                        KeyRef<Node.KeyType, Node>? from = value.From;
                        KeyRef<Node.KeyType, Node> valueOrDefault = from.GetValueOrDefault();
                        value.From = state.ReadMessage<KeyRef<Node.KeyType, Node>>((SerializerFeatures)0, valueOrDefault, (ISerializer<KeyRef<Node.KeyType, Node>>)this);
                        break;
                    }
                case 3:
                    {
                        KeyRef<Node.KeyType, Node>? from = value.To;
                        KeyRef<Node.KeyType, Node> valueOrDefault = from.GetValueOrDefault();
                        value.To = state.ReadMessage<KeyRef<Node.KeyType, Node>>((SerializerFeatures)0, valueOrDefault, (ISerializer<KeyRef<Node.KeyType, Node>>)this);
                        break;
                    }
                case 4:
                    {
                        string text = state.ReadString(null);
                        if (text != null)
                        {
                            value.TypeName = text;
                        }
                        break;
                    }
                default:
                    state.SkipField();
                    break;
            }
        }
        return value;
    }

    void ISerializer<Edge.KeyType>.Write(ref ProtoWriter.State state, Edge.KeyType value)
    {
        KeyRef<Node.KeyType, Node>? from = value.From;
        if (from.HasValue)
        {
            KeyRef<Node.KeyType, Node> valueOrDefault = from.GetValueOrDefault();
            state.WriteMessage<KeyRef<Node.KeyType, Node>>(2, (SerializerFeatures)0, valueOrDefault, (ISerializer<KeyRef<Node.KeyType, Node>>)this);
        }
        from = value.To;
        if (from.HasValue)
        {
            KeyRef<Node.KeyType, Node> valueOrDefault = from.GetValueOrDefault();
            state.WriteMessage<KeyRef<Node.KeyType, Node>>(3, (SerializerFeatures)0, valueOrDefault, (ISerializer<KeyRef<Node.KeyType, Node>>)this);
        }
        string? typeName = value.TypeName;
        state.WriteString(4, typeName, null);
    }
    Edge.ValueType ISerializer<Edge.ValueType>.Read(ref ProtoReader.State state, Edge.ValueType value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            if (num == 2)
            {
                string text = state.ReadString(null);
                if (text != null)
                {
                    value.Name = text;
                }
            }
            else
            {
                state.SkipField();
            }
        }
        return value;
    }

    void ISerializer<Edge.ValueType>.Write(ref ProtoWriter.State state, Edge.ValueType value)
    {
        string? name = value.Name;
        state.WriteString(2, name, null);
    }

    Node.KeyType ISerializer<Node.KeyType>.Read(ref ProtoReader.State state, Node.KeyType value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            if (num == 2)
            {
                string text = state.ReadString(null);
                if (text != null)
                {
                    value.SKey = text;
                }
            }
            else
            {
                state.SkipField();
            }
        }
        return value;
    }

    void ISerializer<Node.KeyType>.Write(ref ProtoWriter.State state, Node.KeyType value)
    {
        string sKey = value.SKey;
        state.WriteString(2, sKey, null);
    }

    Node.ValueType ISerializer<Node.ValueType>.Read(ref ProtoReader.State state, Node.ValueType value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {
                case 2:
                    {
                        string text = state.ReadString(null);
                        if (text != null)
                        {
                            value.Name = text;
                        }
                        break;
                    }
                case 3:
                    {
                        string text = state.ReadString(null);
                        if (text != null)
                        {
                            value.TypeName = text;
                        }
                        break;
                    }
                default:
                    state.SkipField();
                    break;
            }
        }
        return value;
    }

    void ISerializer<Node.ValueType>.Write(ref ProtoWriter.State state, Node.ValueType value)
    {
        string? name = value.Name;
        state.WriteString(2, name, null);
        name = value.TypeName;
        state.WriteString(3, name, null);
    }
    KeyRef<Node.KeyType, Node> ISerializer<KeyRef<Node.KeyType, Node>>.Read(ref ProtoReader.State state, KeyRef<Node.KeyType, Node> value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            if (num == 2)
            {
                Node.KeyType key = value.Key;
                key = state.ReadMessage<Node.KeyType>((SerializerFeatures)0, key, (ISerializer<Node.KeyType>)this);
                value = new KeyRef<Node.KeyType, Node> (key);
            }
            else
            {
                state.SkipField();
            }
        }
        return value;
    }

    void ISerializer<KeyRef<Node.KeyType, Node>>.Write(ref ProtoWriter.State state, KeyRef<Node.KeyType, Node> value)
    {
        Node.KeyType key = value.Key;
        state.WriteMessage<Node.KeyType>(2, (SerializerFeatures)0, key, (ISerializer<Node.KeyType>)this);
    }
    Node ISerializer<Node>.Read(ref ProtoReader.State state, Node item)
    {
        item._key = ((ISerializer<Node.KeyType>)this).Read(ref state, item._key);
        item._value = ((ISerializer<Node.ValueType>)this).Read(ref state, item._value);
        return item;
    }
    void ISerializer<Node>.Write(ref ProtoWriter.State state, Node item)
    {
        ((ISerializer<Node.KeyType>)this).Write(ref state, item._key);
        ((ISerializer<Node.ValueType>)this).Write(ref state, item._value);
    }

    Vector ISerializer<Vector>.Read(ref ProtoReader.State state, Vector value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {
                case 1:
                    {
                        int[]? ints = value.Ints;
                        ints = RepeatedSerializer.CreateVector<int>().ReadRepeated(ref state, (SerializerFeatures)144, ints);
                        if (ints != null)
                        {
                            value.Ints = ints;
                        }
                        break;
                    }
                case 2:
                    {
                        float[]? floats = value.Floats;
                        floats = RepeatedSerializer.CreateVector<float>().ReadRepeated(ref state, (SerializerFeatures)149, floats);
                        if (floats != null)
                        {
                            value.Floats = floats;
                        }
                        break;
                    }
                default:
                    state.SkipField();
                    break;
            }
        }
        return value;
    }

    void ISerializer<Vector>.Write(ref ProtoWriter.State state, Vector value)
    {
        int[]? ints = value.Ints;
        if (ints != null)
        {
            int[] array = ints;
            RepeatedSerializer.CreateVector<int>().WriteRepeated(ref state, 1, (SerializerFeatures)144, array);
        }
        float[]? floats = value.Floats;
        if (floats != null)
        {
            float[] array2 = floats;
            RepeatedSerializer.CreateVector<float>().WriteRepeated(ref state, 2, (SerializerFeatures)149, array2);
        }
    }

    VectorNode.KeyType ISerializer<VectorNode.KeyType>.Read(ref ProtoReader.State state, VectorNode.KeyType value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            if (num == 1)
            {
                string text = state.ReadString();
                if (text != null)
                {
                    value.SKey = text;
                }
            }
            else
            {
                state.SkipField();
            }
        }
        return value;
    }

    void ISerializer<VectorNode.KeyType>.Write(ref ProtoWriter.State state, VectorNode.KeyType value)
    {
        string? sKey = value.SKey;
        state.WriteString(1, sKey);
    }

    VectorNode.ValueType ISerializer<VectorNode.ValueType>.Read(ref ProtoReader.State state, VectorNode.ValueType value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            if (num == 3)
            {
                Vector? vector = value.Vector;
                Vector valueOrDefault = vector.GetValueOrDefault();
                vector = (value.Vector = state.ReadMessage<Vector>((SerializerFeatures)0, valueOrDefault, (ISerializer<Vector>)this));
            }
            else
            {
                state.SkipField();
            }
        }
        return value;
    }

    void ISerializer<VectorNode.ValueType>.Write(ref ProtoWriter.State state, VectorNode.ValueType value)
    {
        Vector? vector = value.Vector;
        if (vector.HasValue)
        {
            Vector valueOrDefault = vector.GetValueOrDefault();
            state.WriteMessage<Vector>(3, (SerializerFeatures)0, valueOrDefault, (ISerializer<Vector>)this);
        }
    }


    KeyRef<Edge.KeyType, Edge> ISerializer<KeyRef<Edge.KeyType, Edge>>.Read(ref ProtoReader.State state, KeyRef<Edge.KeyType, Edge> item)
    {
        var value = item.Key;
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {
                case 2:
                    {
                        KeyRef<Node.KeyType, Node> valueOrDefault = value.From.GetValueOrDefault();
                        value.From = state.ReadMessage<KeyRef<Node.KeyType, Node>>((SerializerFeatures)0, valueOrDefault, (ISerializer<KeyRef<Node.KeyType, Node>>)this);
                        break;
                    }
                case 3:
                    {
                        KeyRef<Node.KeyType, Node> valueOrDefault = value.To.GetValueOrDefault();
                        value.To = state.ReadMessage<KeyRef<Node.KeyType, Node>>((SerializerFeatures)0, valueOrDefault, (ISerializer<KeyRef<Node.KeyType, Node>>)this);
                        break;
                    }
                case 4:
                    {
                        string text = state.ReadString(null);
                        if (text != null)
                        {
                            value.TypeName = text;
                        }
                        break;
                    }
                default:
                    state.SkipField();
                    break;
            }
        }
        return new KeyRef<Edge.KeyType, Edge>(value);
    }

    void ISerializer<KeyRef<Edge.KeyType, Edge>>.Write(ref ProtoWriter.State state, KeyRef<Edge.KeyType, Edge> item)
    {
        var value = item.Key;
        if (value.From.HasValue)
        {
            state.WriteMessage<KeyRef<Node.KeyType, Node>>(2, (SerializerFeatures)0, value.From.Value, (ISerializer<KeyRef<Node.KeyType, Node>>)this);
        }
        if (value.To.HasValue)
        {
            state.WriteMessage<KeyRef<Node.KeyType, Node>>(2, (SerializerFeatures)0, value.To.Value, (ISerializer<KeyRef<Node.KeyType, Node>>)this);
        }
        string? typeName = value.TypeName;
        state.WriteString(4, typeName, null);
    }

    public void Write(ref ProtoWriter.State state, KeyRef<Edge.KeyType, Edge> value)
    {
        throw new NotImplementedException();
    }
    Edge ISerializer<Edge>.Read(ref ProtoReader.State state, Edge item)
    {
        item._key = ((ISerializer<Edge.KeyType>)this).Read(ref state, item._key);
        item._value = ((ISerializer<Edge.ValueType>)this).Read(ref state, item._value);
        return item;
    }
    void ISerializer<Edge>.Write(ref ProtoWriter.State state, Edge item)
    {
        ((ISerializer<Edge.KeyType>)this).Write(ref state, item._key);
        ((ISerializer<Edge.ValueType>)this).Write(ref state, item._value);
    }

    Graph.Route ISerializer<Graph.Route>.Read(ref ProtoReader.State state, Graph.Route value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {

                case 1:
                    value.Name = state.ReadString();
                    break;

                case 2:
                    value.Rules = RepeatedSerializer.CreateSet<HashSet<Graph.Rule>, Graph.Rule>().ReadRepeated(ref state, SerializerFeatures.WireTypeString | SerializerFeatures.OptionPackedDisabled, value.Rules!, this);
                    break;
                default:
                    state.SkipField();
                    break;
            }
        }
        return value;
    }
    void ISerializer<Graph.Route>.Write(ref ProtoWriter.State state, Graph.Route value)
    {

        state.WriteString(1, value.Name);

        if (value.Rules != null)
        {
            RepeatedSerializer.CreateSet<HashSet<Graph.Rule>, Graph.Rule>().WriteRepeated(ref state, 2, SerializerFeatures.WireTypeString | SerializerFeatures.OptionPackedDisabled, value.Rules, this);
        }
    }
    Graph.Rule ISerializer<Graph.Rule>.Read(ref ProtoReader.State state, Graph.Rule value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {

                case 1:
                    value.FromType = state.ReadString();
                    break;
                case 2:
                    value.ToType = state.ReadString();
                    break;
                case 3:
                    value.EdgeType = state.ReadString();
                    break;

                default:
                    state.SkipField();
                    break;
            }
        }
        return value;
    }
    void ISerializer<Graph.Rule>.Write(ref ProtoWriter.State state, Graph.Rule value)
    {

        state.WriteString(1, value.FromType);
        state.WriteString(2, value.ToType);
        state.WriteString(3, value.EdgeType);

    }
    Graph.HiperEdge.KeyType ISerializer<Graph.HiperEdge.KeyType>.Read(ref ProtoReader.State state, Graph.HiperEdge.KeyType value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {

                case 2:
                    {
                        KeyRef<Node.KeyType, Node> key = new();
                        key = state.ReadMessage<KeyRef<Node.KeyType, Node>>(SerializerFeatures.CategoryRepeated, key, this);
                        value.From = key;
                    }
                    break;
                case 3:
                    {
                        KeyRef<Node.KeyType, Node> key = new();
                        key = state.ReadMessage<KeyRef<Node.KeyType, Node>>(SerializerFeatures.CategoryRepeated, key, this);
                        value.To = key;
                    }
                    break;
                case 4:
                    value.TypeName = state.ReadString();
                    break;
                default:
                    state.SkipField();
                    break;
            }
        }
        return value;
    }
    void ISerializer<Graph.HiperEdge.KeyType>.Write(ref ProtoWriter.State state, Graph.HiperEdge.KeyType value)
    {

        if (value.From != null)
        {
            state.WriteMessage<KeyRef<Node.KeyType, Node>>(2, SerializerFeatures.CategoryRepeated, value.From.Value, this);
        }
        if (value.To != null)
        {
            state.WriteMessage<KeyRef<Node.KeyType, Node>>(3, SerializerFeatures.CategoryRepeated, value.To.Value, this);
        }
        state.WriteString(4, value.TypeName);
    }

    Graph.HiperEdge.ValueType ISerializer<Graph.HiperEdge.ValueType>.Read(ref ProtoReader.State state, Graph.HiperEdge.ValueType value)
    {
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {

                case 5:
                    value.Name = state.ReadString();
                    break;
                case 10:
                    {
                        //KeyRef<Edge.KeyType, Edge> key = new();
                        //key = state.ReadMessage<KeyRef<Edge.KeyType, Edge>>(SerializerFeatures.CategoryRepeated, key, this);
                        //value.Edge = key;
                        // read the full object
                        Edge edge = new();
                        edge = state.ReadMessage<Edge>(SerializerFeatures.CategoryRepeated, edge, this);
                        value.Edge = edge;
                    }
                    break;
                case 11:
                    {
                        //KeyRef<Graph.Path.KeyType, Graph.Path> key = new();
                        //key = state.ReadMessage<KeyRef<Graph.Path.KeyType, Graph.Path>>(SerializerFeatures.CategoryRepeated, key, this);
                        //value.Source = key;
                        // read the full object
                        Graph.HiperEdge path = new();
                        path = state.ReadMessage<Graph.HiperEdge>(SerializerFeatures.CategoryRepeated, path, this);
                        value.Source = path;
                    }
                    break;
                case 13:
                    value.Width = state.ReadInt32();
                    break;
                case 14:
                    value.Length = state.ReadInt32();
                    break;
                default:
                    state.SkipField();
                    break;
            }
        }
        return value;
    }
    void ISerializer<Graph.HiperEdge.ValueType>.Write(ref ProtoWriter.State state, Graph.HiperEdge.ValueType value)
    {

        state.WriteString(5, value.Name);
        if (value.Edge != null && value.Edge.Value.Value != null)
        {
            //state.WriteMessage<KeyRef<Edge.KeyType, Edge>>(10, SerializerFeatures.CategoryRepeated, value.Edge.Value, this);
            // write the full object
            state.WriteMessage<Edge>(10, SerializerFeatures.CategoryRepeated, value.Edge.Value.Value, this);
        }
        if (value.Source != null && value.Source.Value.Value != null)
        {
            //state.WriteMessage<KeyRef<Graph.Path.KeyType, Graph.Path>>(11, SerializerFeatures.CategoryRepeated, value.Source.Value, this);
            // write the full object
            state.WriteMessage<Graph.HiperEdge>(11, SerializerFeatures.CategoryRepeated, value.Source.Value.Value, this);
        }
        if (value.Width != null)
        {
            state.WriteFieldHeader(13, WireType.Varint);
            state.WriteInt32(value.Width.Value);
        }
        if (value.Length != null)
        {
            state.WriteFieldHeader(14, WireType.Varint);
            state.WriteInt32(value.Length.Value);
        }
    }

    KeyRef<Graph.HiperEdge.KeyType, Graph.HiperEdge> ISerializer<KeyRef<Graph.HiperEdge.KeyType, Graph.HiperEdge>>.Read(ref ProtoReader.State state, KeyRef<Graph.HiperEdge.KeyType, Graph.HiperEdge> item)
    {
        var value = item.Key;
        int num;
        while ((num = state.ReadFieldHeader()) > 0)
        {
            switch (num)
            {

                case 2:
                    {
                        //KeyRef<Node.KeyType, Node> key = new();
                        //key = state.ReadMessage<KeyRef<Node.KeyType, Node>>(SerializerFeatures.CategoryRepeated, key, this);
                        //value.From = key;
                        //read the full object
                        Node node = new();
                        node = state.ReadMessage<Node>(SerializerFeatures.CategoryRepeated, node, this);
                        value.From = node;
                    }
                    break;
                case 3:
                    {
                        //KeyRef<Node.KeyType, Node> key = new();
                        //key = state.ReadMessage<KeyRef<Node.KeyType, Node>>(SerializerFeatures.CategoryRepeated, key, this);
                        //value.To = key;
                        //read the full object
                        Node node = new();
                        node = state.ReadMessage<Node>(SerializerFeatures.CategoryRepeated, node, this);
                        value.To = node;
                    }
                    break;
                case 4:
                    value.TypeName = state.ReadString();
                    break;
                default:
                    state.SkipField();
                    break;
            }
        }
        return new KeyRef<Graph.HiperEdge.KeyType, Graph.HiperEdge>(value);
    }

    void ISerializer<KeyRef<Graph.HiperEdge.KeyType, Graph.HiperEdge>>.Write(ref ProtoWriter.State state, KeyRef<Graph.HiperEdge.KeyType, Graph.HiperEdge> item)
    {
        var value = item.Key;

        if (value.From != null && value.From.Value.Value != null)
        {
            //state.WriteMessage<KeyRef<Node.KeyType, Node>>(2, SerializerFeatures.CategoryRepeated, value.From.Value, this);
            //write the full object
            state.WriteMessage<Node>(2, SerializerFeatures.CategoryRepeated, value.From.Value.Value, this);
        }
        if (value.To != null && value.To.Value.Value != null)
        {
            //state.WriteMessage<KeyRef<Node.KeyType, Node>>(3, SerializerFeatures.CategoryRepeated, value.To.Value, this);
            //write the full object
            state.WriteMessage<Node>(3, SerializerFeatures.CategoryRepeated, value.To.Value.Value, this);
        }
        state.WriteString(4, value.TypeName);
    }

    Graph.HiperEdge ISerializer<Graph.HiperEdge>.Read(ref ProtoReader.State state, Graph.HiperEdge item)
    {
        item._key = ((ISerializer<Graph.HiperEdge.KeyType>)this).Read(ref state, item._key);
        item._value = ((ISerializer<Graph.HiperEdge.ValueType>)this).Read(ref state, item._value);
        return item;
    }
    void ISerializer<Graph.HiperEdge>.Write(ref ProtoWriter.State state, Graph.HiperEdge item)
    {
        ((ISerializer<Graph.HiperEdge.KeyType>)this).Write(ref state, item._key);
        ((ISerializer<Graph.HiperEdge.ValueType>)this).Write(ref state, item._value);
    }
}
