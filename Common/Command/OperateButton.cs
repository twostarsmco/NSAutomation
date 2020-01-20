using System;
using Newtonsoft.Json;

namespace Command
{
    public class OperateButton : OperateCommandBase
    {
        public byte TargetState { get;}
        public override byte[] CommandBytes { get; }

        public OperateButton(ButtonID targetButton, ButtonState targetState) : base((byte)targetButton)
        {
            this.TargetState = (byte)targetState;
            this.CommandBytes = new byte[] { this.TargetControlID, (byte)this.TargetState };
        }

        [JsonConstructor]
        internal OperateButton(byte targetControlID, byte targetState) : base(targetControlID)
        {
            if (!Enum.IsDefined(typeof(ButtonID), targetControlID)) throw new ArgumentOutOfRangeException("targetButton");
            if (!Enum.IsDefined(typeof(ButtonState), targetState)) throw new ArgumentOutOfRangeException("targetState");
            this.TargetState = targetState;
            this.CommandBytes = new byte[] { this.TargetControlID, TargetState };
        }
    }

}
