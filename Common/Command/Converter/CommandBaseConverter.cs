using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Command.Converter
{
    public class CommandBaseConverter : JsonConverter
    {

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Command.CommandBase);
        }


        /// <summary>
        /// This class is write-only.
        /// </summary>
        public override bool CanWrite => false;

        /// <summary>
        /// Throws NotImplementedException. This class is read-only.
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException("This class is read-only.");
        }


        /// <summary>
        /// Deserialize JSON object as child class of CommandBase.
        /// This method first scans "CommandType" property of given JSON object,
        /// then calls ReadJson method on appropriate Converter class corresponding to "CommandType".
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jobject = JObject.Load(reader);

            JsonConverter converter;
            switch ((string)jobject["CommandType"])
            {
                case "Wait":
                    converter = new WaitConverter();
                    break;

                case "Button":
                    converter = new OperateButtonConverter();
                    break;

                case "Stick":
                    converter = new OperateStickConverter();
                    break;

                default:
                    throw new JsonReaderException("Invalid CommandType specified");
            }
            var newReader = jobject.CreateReader(); //As JsonReader cannot be used twice, create new one and pass it.
            return converter.ReadJson(newReader, objectType, existingValue, serializer);
        }

    }
}
