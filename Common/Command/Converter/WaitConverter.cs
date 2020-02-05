using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Command.Converter
{
    public class WaitConverter : JsonConverter
    {

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Command.Wait);
        }


        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jobject = JObject.Load(reader);
            return new Wait((int)jobject["WaitTime"]);
        }


        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var operation = (Command.Wait)value;
            if (operation == null) throw new ArgumentException("value is not OperateButton", "value");

            writer.WriteStartObject();
            writer.WritePropertyName("CommandType");
            writer.WriteValue("Wait");
            writer.WritePropertyName("WaitTime");
            writer.WriteValue(operation.WaitTime);
            writer.WriteEndObject();
        }
    }
}
