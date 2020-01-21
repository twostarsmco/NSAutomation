using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Command;

namespace NSAutomationWin
{
    public partial class ButtonStateSelector : UserControl
    {
        // TODO:
        // - Implement keyboard shortcut
        // - When button is clicked along with Shift key, enable Hold automatically
        private ButtonID buttonID;
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

        public event EventHandler<ButtonStateChangedEventArgs> ButtonStateChanged;

        private void ButtonStateSelectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ButtonStateSelectCheckBox.Checked)
            {
                ButtonStateChanged?.Invoke(this, new ButtonStateChangedEventArgs(
                    this.ButtonID, Command.ButtonState.PRESS));
                if (!this.HoldCheckBox.Checked && this.ButtonStateSelectCheckBox.Checked)
                {
                    this.ButtonStateSelectCheckBox.Checked = false;
                }
            }
            else
            {
                ButtonStateChanged?.Invoke(this, new ButtonStateChangedEventArgs(
                    this.ButtonID, Command.ButtonState.RELEASE));
            }
        }

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
