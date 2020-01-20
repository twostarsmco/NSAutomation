using System;
using Newtonsoft.Json;

namespace Command
{
    public class OperateButtonConverter<OperateButton>: JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            //determine whether or not this converted can create an instance of
            //the specified object type
            return objectType == typeof(OperateButton);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            //deserialize an object from the specified reader
            return serializer.Deserialize<OperateButton>(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            //serialize the object value
            serializer.Serialize(writer, value);
        }
    }
}
