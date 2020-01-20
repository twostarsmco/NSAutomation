using System.IO;

namespace Command
{

    public class ExternalMacro : Macro
    {
        public ExternalMacro(string macroFilePath, string basePath) :
            base(null)//, Path.GetDirectoryName(Path.Combine(basePath, macroFilePath)))
        {

        }
    }
}
