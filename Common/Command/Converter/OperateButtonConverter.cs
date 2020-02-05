using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Command.Converter
{
    public class OperateButtonConverter : JsonConverter
    {

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(OperateButton);
        }


        /// <summary>
        /// This class is write-only.
        /// </summary>
        public override bool CanRead => false;


        /// <summary>
        /// Throws NotImplementedException. This class is write-only.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jobject = JObject.Load(reader);
            return new OperateButton(
                (ButtonID)Enum.Parse(typeof(ButtonID), (string)jobject["ButtonID"], ignoreCase: true),
                (ButtonState)(byte)jobject["TargetState"]);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var operation = (OperateButton)value;
            if (operation == null) throw new ArgumentException("value is not OperateButton", "value");

            writer.WriteStartObject();
            writer.WritePropertyName("CommandType");
            writer.WriteValue("Button");
            writer.WritePropertyName("ButtonID");
            writer.WriteValue(operation.ButtonID.ToString());
            writer.WritePropertyName("TargetState");
            writer.WriteValue(operation.TargetState);
            writer.WriteEndObject();
        }


    }
}
