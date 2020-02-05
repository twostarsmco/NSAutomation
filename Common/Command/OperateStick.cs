using System;

using Newtonsoft.Json;

namespace Command
{
    [JsonConverter(typeof(Converter.OperateStickConverter))]
    public class OperateStick : OperateCommandBase
    {
        private byte[] commandBytes;
        public override byte[] CommandBytes { get { return commandBytes; } }


        /// <summary>
        /// An ID of stick on which this operation is performed
        /// </summary>
        [JsonIgnore]
        public StickID StickID { get { return (StickID)Enum.ToObject(typeof(StickID), this.TargetControlID); } }


        /// <summary>
        /// The angle of stick in X direction, after this operation is performed.
        /// 128 represents neutral position. 0 and 225 represents maximum tilting.
        /// </summary>
        public byte TargetXAngle { get; private set; }


        /// <summary>
        /// The angle of stick in Y direction, after this operation is performed.
        /// 128 represents neutral position. 0 and 225 represents maximum tilting.
        /// </summary>
        public byte TargetYAngle { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetStick">An ID of stick on which this operation is performed.</param>
        /// <param name="targetXAngle">The angle of stick in X direction, after this operation is performed.
        /// 128 represents neutral position. 0 and 225 represents maximum tilting.</param>
        /// <param name="targetYAngle">The angle of stick in Y direction, after this operation is performed.</param>
        public OperateStick(StickID targetStick, byte targetXAngle, byte targetYAngle) : base((byte)targetStick)
        {
            this.Initialize(targetXAngle, targetYAngle);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetStick">An ID of stick on which this operation is performed.</param>
        /// <param name="targetXAngle">The position of stick in X direction, after this operation is performed.</param>
        /// <param name="targetYAngle">The position of stick in Y direction, after this operation is performed.</param>
        public OperateStick(StickID targetStick, StickAngle targetXAngle, StickAngle targetYAngle) :
            this(targetStick, (byte)targetXAngle, (byte)targetYAngle)
        { }


        /// <summary>
        /// An internal constructor to be used for instantination from JSON data.
        /// </summary>
        /// <param name="targetControlID">An ID of stick on which this operation is performed.</param>
        /// <param name="targetXAngle">The position of stick in X direction, after this operation is performed.</param>
        /// <param name="targetYAngle">The position of stick in Y direction, after this operation is performed.</param>
        [JsonConstructor]
        internal OperateStick(byte targetControlID, byte targetXAngle, byte targetYAngle) : base(targetControlID)
        {
            if (!Enum.IsDefined(typeof(StickID), targetControlID)) throw new ArgumentOutOfRangeException("targetStick");
            this.Initialize(targetXAngle, targetYAngle);
        }


        /// <summary>
        /// Initializes this instance by setting property members.
        /// </summary>
        /// <param name="targetXAngle">The angle of stick in X direction, after this operation is performed.</param>
        /// <param name="targetYAngle">The angle of stick in Y direction, after this operation is performed.</param>
        private void Initialize(byte targetXAngle, byte targetYAngle) 
        {
            this.TargetXAngle = targetXAngle;
            this.TargetYAngle = targetYAngle;
            this.commandBytes = new byte[] { this.TargetControlID, this.TargetXAngle, this.TargetYAngle };
        }

        
        public override string ToString()
        {
            return $"{(StickID)Enum.ToObject(typeof(StickID), this.TargetControlID)} ({this.TargetXAngle}, {this.TargetYAngle})";
        }
    }


    /// <summary>
    /// Frequently used angles of stick, and its corresponding byte value
    /// </summary>
    public enum StickAngle : byte
    {
        MIN = 0,
        NEUTRAL = 128,
        MAX = 255
    }
}
