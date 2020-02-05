using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Command.Converter
{
    public class OperateStickConverter : JsonConverter
    {

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Command.OperateStick);
        }


        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jobject = JObject.Load(reader);
            return new OperateStick(
                        (StickID)Enum.Parse(typeof(StickID), (string)jobject["StickID"], ignoreCase: true),
                        (byte)jobject["X"], (byte)jobject["Y"]);
        }


        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var operation = (Command.OperateStick)value;
            if (operation == null) throw new ArgumentException("value is not OperateButton", "value");

            writer.WriteStartObject();
            writer.WritePropertyName("CommandType");
            writer.WriteValue("Stick");
            writer.WritePropertyName("StickID");
            writer.WriteValue(operation.StickID.ToString());
            writer.WritePropertyName("X");
            writer.WriteValue(operation.TargetXAngle);
            writer.WritePropertyName("Y");
            writer.WriteValue(operation.TargetYAngle);
            writer.WriteEndObject();
        }
    }
}
