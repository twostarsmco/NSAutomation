using System;

using Newtonsoft.Json;

namespace Command
{
    public class OperateStick : OperateCommandBase
    {
        private byte[] commandBytes;
        public override byte[] CommandBytes { get { return commandBytes; } }
        public byte TargetXAngle { get; private set; }
        public byte TargetYAngle { get; private set; }
        public OperateStick(StickID targetStick, byte targetXAngle, byte targetYAngle) : base((byte)targetStick)
        {
            this.Initialize(targetXAngle, targetYAngle);
        }

        public OperateStick(StickID targetStick, StickAngle targetXAngle, StickAngle targetYAngle) :
            this(targetStick, (byte)targetXAngle, (byte)targetYAngle)
        { }

        [JsonConstructor]
        internal OperateStick(byte targetControlID, byte targetXAngle, byte targetYAngle) : base(targetControlID)
        {
            if (!Enum.IsDefined(typeof(StickID), targetControlID)) throw new ArgumentOutOfRangeException("targetStick");
            this.Initialize(targetXAngle, targetYAngle);
        }

        private void Initialize(byte targetXAngle, byte targetYAngle) 
        {
            this.TargetXAngle = targetXAngle;
            this.TargetYAngle = targetYAngle;
            this.commandBytes = new byte[] { this.TargetControlID, this.TargetXAngle, this.TargetYAngle };
        }
    }

    public enum StickAngle : byte
    {
        MIN = 0,
        NEUTRAL = 128,
        MAX = 255
    }
}
