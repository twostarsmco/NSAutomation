using System;
using Newtonsoft.Json;

using Command.Converter;

namespace Command
{
    /// <summary>
    /// A class that represents an operation of pressing, or releasing a button.
    /// </summary>
    [JsonConverter(typeof(OperateButtonConverter))]
    public class OperateButton : OperateCommandBase
    {
        /// <summary>
        /// A state of button after this operation is performed.
        /// </summary>
        public ButtonState TargetState { get;}


        public override byte[] CommandBytes { get; }


        /// <summary>
        /// An ID of button on which this operation is performed
        /// </summary>
        [JsonIgnore]
        public ButtonID ButtonID { get { return (ButtonID)Enum.ToObject(typeof(ButtonID), this.TargetControlID); } }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetButton">An ID of button on which this operation is performed</param>
        /// <param name="targetState">A state of button after this operation is performed.</param>
        public OperateButton(ButtonID targetButton, ButtonState targetState) : base((byte)targetButton)
        {
            this.TargetState = targetState;
            this.CommandBytes = new byte[] { this.TargetControlID, (byte)this.TargetState };
        }


        /// <summary>
        /// An internal constructor to be used for instantination from JSON data.
        /// </summary>
        /// <param name="targetButton">An ID of button on which this operation is performed</param>
        /// <param name="targetState">A state of button after this operation is performed.</param>
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
