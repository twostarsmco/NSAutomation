using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public static class MacroExamples
    {
        /// <summary>
        /// A macro that brings both sticks to neutral position, and releases all buttons.
        /// </summary>
        public static Macro NeutralizeAllInput
            = new Macro(
                new OperateStick(StickID.LSTICK, StickAngle.NEUTRAL, StickAngle.NEUTRAL),
                new Wait(50),
                new OperateStick(StickID.RSTICK, StickAngle.NEUTRAL, StickAngle.NEUTRAL),
                new Wait(50),
                new OperateButton(ButtonID.RIGHT, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.LEFT, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.UP, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.DOWN, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.A, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.B, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.X, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.Y, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.R, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.L, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.ZR, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.ZL, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.RCLICK, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.LCLICK, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.HOME, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.CAPTURE, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.PLUS, ButtonState.RELEASE),
                new Wait(50),
                new OperateButton(ButtonID.MINUS, ButtonState.RELEASE)
                );
    }
}
