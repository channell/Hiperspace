using Hiperspace;
using System.Reflection;
using System.Text.Json;

namespace Sparx
{
    public class SetSpaceConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            if (!typeToConvert.IsGenericType)
            {
                return false;
            }

            if (typeToConvert.GetGenericTypeDefinition() != typeof(SetSpace<>))
            {
                return false;
            }

            return true;
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            Type valueType = typeToConvert.GetGenericArguments()[0];

            JsonConverter converter = (JsonConverter)Activator.CreateInstance(
                typeof(SetSpaceConverterInner<>).MakeGenericType(
                    new Type[] { valueType }),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: new object[] { options },
                culture: null)!;

            return converter;
        }

        private class SetSpaceConverterInner<TEntity> : JsonConverter<SetSpace<TEntity>?>
            where TEntity : Element<TEntity>, new()
        {
            private readonly JsonConverter<TEntity> _valueConverter;
            private readonly Type _valueType;

            public SetSpaceConverterInner(JsonSerializerOptions options)
            {
                // For performance, use the existing converter.
                _valueConverter = (JsonConverter<TEntity>)options
                    .GetConverter(typeof(TEntity));

                // Cache the key and value types.
                _valueType = typeof(TEntity);
            }

            public override SetSpace<TEntity>? Read(
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
                        return null;
                    }

                    // Get the value.
                    reader.Read();
                }

                throw new JsonException();
            }

            public override void Write(
                Utf8JsonWriter writer,
                SetSpace<TEntity>? set,
                JsonSerializerOptions options)
            {
            }
        }
    }
}

