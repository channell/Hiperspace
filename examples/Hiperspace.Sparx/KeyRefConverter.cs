using Hiperspace;
using System.Reflection;
using System.Text.Json;

namespace Sparx
{
    public class KeyRefConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            if (!typeToConvert.IsGenericType)
            {
                return false;
            }

            if (typeToConvert.GetGenericTypeDefinition() != typeof(KeyRef<,>))
            {
                return false;
            }

            return true;
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            Type keyType = typeToConvert.GetGenericArguments()[0];
            Type valueType = typeToConvert.GetGenericArguments()[1];

            JsonConverter converter = (JsonConverter)Activator.CreateInstance(
                typeof(KeyRefConverterInner<,>).MakeGenericType(
                    new Type[] { keyType, valueType }),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: new object[] { options },
                culture: null)!;

            return converter;
        }

        private class KeyRefConverterInner<TKey,TEntity> : JsonConverter<KeyRef<TKey,TEntity>>
            where TKey : struct, IEquatable<TKey>, IComparable<TKey>
            where TEntity : Element<TEntity>, new()
        {
            private readonly JsonConverter<TEntity> _valueConverter;
            private readonly Type _valueType;

            public KeyRefConverterInner(JsonSerializerOptions options)
            {
                // For performance, use the existing converter.
                _valueConverter = (JsonConverter<TEntity>)options
                    .GetConverter(typeof(TEntity));

                // Cache the key and value types.
                _valueType = typeof(TEntity);
            }

            public override KeyRef<TKey,TEntity> Read(
                ref Utf8JsonReader reader,
                Type typeToConvert,
                JsonSerializerOptions options)
            {
                if (reader.TokenType != JsonTokenType.StartObject)
                {
                    throw new JsonException();
                }
                while (reader.Read())
                {
                    if (reader.TokenType == JsonTokenType.EndObject)
                    {
                        return default;
                    }

                    // Get the value.
                    reader.Read();
                }

                throw new JsonException();
            }

            public override void Write(
                Utf8JsonWriter writer,
                KeyRef<TKey,TEntity> set,
                JsonSerializerOptions options)
            {
            }
        }
    }
}

