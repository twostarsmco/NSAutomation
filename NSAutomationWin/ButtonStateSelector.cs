using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Command;

namespace NSAutomationWin
{
    /// <summary>
    /// A UserControl to provide functionality of pressing and releasing a button on the device.
    /// </summary>
    public partial class ButtonStateSelector : UserControl
    {
        // TODO:
        // - Implement keyboard shortcut
        // - When button is clicked along with Shift key, enable Hold automatically
        private ButtonID buttonID;

        /// <summary>
        /// An ID of button this instance controls.
        /// </summary>
        public ButtonID ButtonID
        {
            get { return this.buttonID; }
            set
            {
                this.buttonID = value;
                this.UpdateText();
            }
        }

        private Keys shortcutKey;
        /// <summary>
        /// A key on keyboard that acts as keyboard shortcut of this instance.
        /// </summary>
        public Keys ShortcutKey
        {
            get { return shortcutKey; }
            set
            {
                //TODO: add validation to prevent some system keys from being registered
                shortcutKey = value;
                this.UpdateText();
            }
        }


        public ButtonStateSelector()
        {
            InitializeComponent();
            this.Layout.BorderStyle = BorderStyle.FixedSingle;
            this.UpdateText();
        }


        /// <summary>
        /// A event raised when state of button on this control is changed.
        /// </summary>
        public event EventHandler<ButtonStateChangedEventArgs> StickClickStateChanged;

        private void ButtonStateSelectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Command.ButtonState newState =
                this.ButtonStateSelectCheckBox.Checked ?
                Command.ButtonState.PRESS : Command.ButtonState.RELEASE;
            if (this.HoldCheckBox.Checked)
            {
                StickClickStateChanged?.Invoke(this, new ButtonStateChangedEventArgs(
                    this.ButtonID, newState, isOnePush: false));
            }
            else
            {
                var ea = new ButtonStateChangedEventArgs(this.ButtonID, Command.ButtonState.PRESS, isOnePush: true);
                StickClickStateChanged?.Invoke(this, ea);
                this.ButtonStateSelectCheckBox.CheckedChanged -= ButtonStateSelectCheckBox_CheckedChanged;
                this.ButtonStateSelectCheckBox.Checked = false;
                this.ButtonStateSelectCheckBox.CheckedChanged += ButtonStateSelectCheckBox_CheckedChanged;
            }

        }


        /// <summary>
        /// Update this.ButtonStateSelectCheckBox.Text based on properties.
        /// e.g. "ZL (Z)" for ZL button, with Z key on keyboard as shortcut key.
        /// </summary>
        private void UpdateText()
        {
            string text;
            if (this.ShortcutKey == Keys.None)
            {
                text = ButtonTextMap[this.ButtonID];
            }
            else
            {
                text = $"{ButtonTextMap[this.ButtonID]} ({this.ShortcutKey.ToString()})";
            }
            this.ButtonStateSelectCheckBox.Text = text;
        }

        public static Dictionary<ButtonID, string> ButtonTextMap = new Dictionary<ButtonID, string>
        {
            { ButtonID.None, "" },
            { ButtonID.RIGHT, ">" },
            { ButtonID.LEFT, "<" },
            { ButtonID.UP, "^" },
            { ButtonID.DOWN, "v" },
            { ButtonID.A, "A" },
            { ButtonID.B, "B" },
            { ButtonID.X, "X" },
            { ButtonID.Y, "Y" },
            { ButtonID.R, "R" },
            { ButtonID.L, "L" },
            { ButtonID.ZR, "ZR" },
            { ButtonID.ZL, "ZL" },
            { ButtonID.RCLICK, "RCL" },
            { ButtonID.LCLICK, "LCL" },
            { ButtonID.HOME, "HOM" },
            { ButtonID.CAPTURE, "CAP" },
            { ButtonID.PLUS, "+" },
            { ButtonID.MINUS, "-" },
        };
    }
}
