using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Command
{
    /// <summary>
    /// Represents a sequence of ICommand instances to execute sequentially,
    /// decorated with additional informations.
    /// </summary>
    public class Macro //: ICommand
    {
        /// <summary>
        /// A sequence of ICommand this instance represents.
        /// </summary>
        public IReadOnlyList<CommandBase> Commands;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="commands">A sequence of ICommand to execute.</param>
        public Macro(IList<CommandBase> commands)//, string location)
        {
            this.Commands = commands.ToArray() ?? new CommandBase[] { };
        }


        /// <summary>
        /// The title of this macro. Give it a good name.
        /// </summary>
        public string Title { get; set; } = "";


        /// <summary>
        /// The description of this macro.
        /// Write usage, prerequisite, cautions etc. here.
        /// </summary>
        public string Description { get; set; } = "";

        //TODO: implement macro that calls another macro
        public IList<CommandBase> Flatten()
        {
            List<CommandBase> commandsFlat = new List<CommandBase>();
            foreach (var command in this.Commands)
            {
                commandsFlat.Add(command);
            }
            return commandsFlat;
        }


        public override string ToString()
        {
            return string.Join("\r\n", this.Commands.Select(command => command.ToString()));
        }


        /// <summary>
        /// Generates JSON string from this instance.
        /// </summary>
        /// <param name="settings">Specifies the way JSON string is structured.
        /// If not specified, default setting is used.
        /// Beware that some non-default setting may generate incompatible JSON string.
        /// Refer to docs of Newtonsoft.Json.JsonSerializerSettings for details.
        /// </param>
        /// <returns></returns>
        public string ToJSON(JsonSerializerSettings settings = null)
        {
            settings = settings ?? new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                TypeNameHandling = TypeNameHandling.None
            };
            
            return JsonConvert.SerializeObject(this, settings);
        }


        /// <summary>
        /// Create an instance of this class from given JSON string.
        /// </summary>
        /// <param name="json">A JSON string to generate from.</param>
        /// <param name="settings">Specifies the way JSON string is deserialized.
        /// If not specified, default setting is used.
        /// Beware that some non-default setting may generate incompatible JSON string.
        /// Refer to docs of Newtonsoft.Json.JsonSerializerSettings for details.</param>
        /// <returns></returns>
        public static Macro FromJSON(string json, JsonSerializerSettings settings = null)
        {
            settings = settings ?? new JsonSerializerSettings()
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                TypeNameHandling = TypeNameHandling.None
            };
            return JsonConvert.DeserializeObject<Macro>(json, settings);
        }
    }
}
