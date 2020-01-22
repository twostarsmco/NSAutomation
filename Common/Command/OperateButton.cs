using System;
using Newtonsoft.Json;

namespace Command
{
    public class OperateButton : OperateCommandBase
    {
        public ButtonState TargetState { get;}
        public override byte[] CommandBytes { get; }

        [JsonIgnore]
        public ButtonID ButtonID { get { return (ButtonID)Enum.ToObject(typeof(ButtonID), this.TargetControlID); } }
 
        public OperateButton(ButtonID targetButton, ButtonState targetState) : base((byte)targetButton)
        {
            this.TargetState = targetState;
            this.CommandBytes = new byte[] { this.TargetControlID, (byte)this.TargetState };
        }

        [JsonConstructor]
        internal OperateButton(byte targetControlID, ButtonState targetState) : base(targetControlID)
        {
            if (!Enum.IsDefined(typeof(ButtonID), targetControlID)) throw new ArgumentOutOfRangeException("targetButton");
            if (!Enum.IsDefined(typeof(ButtonState), targetState)) throw new ArgumentOutOfRangeException("targetState");
            this.TargetState = targetState;
            this.CommandBytes = new byte[] { this.TargetControlID, (byte)TargetState };
        }

        public override string ToString()
        {
            return $"{this.TargetState} {this.ButtonID}";
        }
    }

}
