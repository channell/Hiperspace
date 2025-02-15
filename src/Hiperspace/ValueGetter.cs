﻿// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Reflection;

namespace Hiperspace
{
    public class ValueGetter
    {
        protected FieldInfo? _field;
        protected PropertyInfo? _property;
        protected int? _index;
        protected ValueGetter? _key;
        protected object? _value;
        protected ValueGetter? _prior;

        public static ValueGetter Empty = new ValueGetter();

        protected ValueGetter ()
        {
        }
        protected ValueGetter
            ( FieldInfo? field = null
            , PropertyInfo? property = null
            , int? index = null
            , ValueGetter? key = null
            , object? value = null
            , ValueGetter? prior = null
            )
        {
            _field = field;
            _property = property;
            _index = index;
            _key = key;
            _value = value;
            _prior = prior;
        }

        public ValueGetter Field(FieldInfo field)
        {
            return new ValueGetter(field: field, prior: this);
        }
        public ValueGetter Property(PropertyInfo property)
        {
            return new ValueGetter(property: property, prior: this);
            
        }
        public ValueGetter Index(object index)
        {
            var i = index as int?;
            if (i != null)
            {
                return new ValueGetter(index: i, prior: this);
            }
            else if (index is ValueGetter vg)
            {
                return new ValueGetter(key: vg, prior: this);
            }
            else
            {
                return new ValueGetter(key: ValueGetter.Value(index), prior: this);
            }
        }
        public static ValueGetter Value(object? value)
        {
            return new ValueGetter(value: value);
        }

        public string Name
        {
            get
            {
                var result = _prior?.Name ?? "";

                if (_field != null)
                    result += "." + _field.Name;
                else if (_property != null)
                    result += "." + _property.Name;
                else if (_index != null)
                    result += "[" + _index.ToString() + "]";
                else if (_key != null && !string.IsNullOrEmpty(_key.Name))
                    result += "[" + _key.Name + "]";
                else if (_value != null)
                    result += "." + _value.ToString();
                return result;
            }
        }

        public object? GetValue(object? source = null)
        {
            object? result;
            if (_prior != null)
            {
                result = _prior.GetValue(source);
            }
            else
            {
                result = source;
            }

            if (_field != null && result != null)
            {
                result = _field.GetValue(result);
            }
            else if (_property != null && result != null)
            {
                result = _property.GetValue(result);
            }
            else if (_index != null && result != null)
            {
                var list = result as System.Collections.IList;
                if (list != null)
                {
                    result = list[_index.Value];
                }
            }
            else if (_key != null && result != null)
            {
                var dict = result as System.Collections.IDictionary;
                if (dict != null)
                {
                    result = dict[_key];
                }
            }
            else if (_value != null && source == null)
            {
                result = _value;
            }
            return result;
        }
    }
}