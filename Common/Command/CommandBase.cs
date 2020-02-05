using Newtonsoft.Json;

namespace Command
{
    /// <summary>
    /// A common abstract class for each commands in macro.
    /// </summary>
    [JsonConverter(typeof(Converter.CommandBaseConverter))]
    public abstract class CommandBase
    {
        public override abstract string ToString();
    }
}
