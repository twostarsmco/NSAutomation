using System;

using Command;

namespace NSAutomationWin
{
    /// <summary>
    /// Provides data for ButtonStateChanged event.
    /// </summary>
    public class ButtonStateChangedEventArgs : EventArgs
    {
        /// <summary>
        /// An ID of button that changed its state.
        /// </summary>
        public ButtonID ButtonID { get; }

        /// <summary>
        /// A state of button to which change occured.
        /// </summary>
        public ButtonState ButtonState { get; }


        /// <summary>
        /// Whether this event is intended as push, rather than holding and releasing a button.
        /// </summary>
        public bool IsOnePush { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buttonID">An ID of button that changed its state.</param>
        /// <param name="state">A state of button to which change occured.</param>
        public ButtonStateChangedEventArgs(ButtonID buttonID, ButtonState state, bool isOnePush)
        {
            this.ButtonID = buttonID;
            this.ButtonState = state;
            this.IsOnePush = isOnePush;
        }
    }
}
