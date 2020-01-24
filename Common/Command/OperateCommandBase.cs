using Newtonsoft.Json;

namespace Command
{
    /// <summary>
    /// An abstract class that represents an operation
    /// that involves sending array of bytes to Arduino.
    /// </summary>
    public abstract class OperateCommandBase: ICommand
    {
        public byte TargetControlID { get; private set; }


        /// <summary>
        /// An ID of control on which this operation is performed
        /// </summary>
        public OperateCommandBase(byte targetControl)
        {
            this.TargetControlID = targetControl;
        }


        /// <summary>
        /// A sequence of bytes to send to Arduino, to perform this operation.
        /// </summary>
        [JsonIgnore]
        public abstract byte[] CommandBytes { get; }

    }
}