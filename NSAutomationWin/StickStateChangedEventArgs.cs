using System;

using Command;

namespace NSAutomationWin
{
    /// <summary>
    /// Provides data for ButtonStateChanged event.
    /// </summary>
    public class StickStateChangedEventArgs : EventArgs
    {
        /// <summary>
        /// An ID of button that changed its state.
        /// </summary>
        public StickID StickID { get; }

        /// <summary>
        /// The angle of stick in X direction.
        /// 128 represents neutral position. 0 and 225 represents maximum tilting.
        /// </summary>
        public byte X { get; }

        /// <summary>
        /// The angle of stick in Y direction.
        /// 128 represents neutral position. 0 and 225 represents maximum tilting.
        /// </summary>
        public byte Y { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stickID">An ID of button that changed its state.</param>
        /// <param name="state">The angle of stick in X direction,</param>
        public StickStateChangedEventArgs(StickID stickID, byte x, byte y)
        {
            this.StickID = stickID;
            this.X = x;
            this.Y = y;
        }
    }
}
