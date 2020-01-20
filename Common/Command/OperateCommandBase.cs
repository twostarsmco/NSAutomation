using Newtonsoft.Json;

namespace Command
{
    public abstract class OperateCommandBase: ICommand
    {
        public byte TargetControlID { get; private set; }

        public OperateCommandBase(byte targetControl)
        {
            this.TargetControlID = targetControl;
        }

        [JsonIgnore]
        public abstract byte[] CommandBytes { get; }

    }
}