using System.IO;

namespace Command
{

    public class ExternalMacro : Macro
    {
        public string MacroFilePath { get; }

        public ExternalMacro(string macroFilePath, string basePath) :
            base(null)//, Path.GetDirectoryName(Path.Combine(basePath, macroFilePath)))
        {
            this.MacroFilePath = macroFilePath;
        }

        public override string ToString()
        {
            return this.MacroFilePath;
        }
    }
}

