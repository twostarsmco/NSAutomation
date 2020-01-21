using System;

using Command;

namespace NSAutomationWin
{
    public class ButtonStateChangedEventArgs : EventArgs
    {
        public ButtonID ButtonID { get; }
        public Command.ButtonState ButtonState { get; }

        public ButtonStateChangedEventArgs(ButtonID buttonID, ButtonState state)
        {
            this.ButtonID = buttonID;
            this.ButtonState = state;
        }
    }
}
