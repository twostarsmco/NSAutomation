using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using Command;

namespace NSAutomationWin
{
    public partial class StickStateSelector : UserControl
    {
 
        private StickID stickID;

        /// <summary>
        /// An ID of stick this instance controls.
        /// </summary>
        public StickID StickID
        {
            get { return this.stickID; }
            set
            {
                this.stickID = value;
                switch (this.StickID)
                {
                    case StickID.RSTICK:
                        this.StickClickButton.ButtonID = ButtonID.RCLICK;
                        break;
                    case StickID.LSTICK:
                        this.StickClickButton.ButtonID = ButtonID.LCLICK;
                        break;
                }
            }
        }
        private CheckBox[] Directions;

        public StickStateSelector()
        {
            InitializeComponent();
            this.Layout.BorderStyle = BorderStyle.FixedSingle;

            this.Directions = new CheckBox[]
            {
                this.UpCheckBox, this.DownCheckBox, this.LeftCheckBox, this.RightCheckBox,
                this.ULCheckBox, this.URCheckBox, this.DLCheckBox, this.DRCheckBox
            };
        }

        /// <summary>
        /// A event raised when state of button on this control is changed.
        /// </summary>
        public event EventHandler<ButtonStateChangedEventArgs> StickClickStateChanged;

        /// <summary>
        /// A event raised when state of button on this control is changed.
        /// </summary>
        public event EventHandler<StickStateChangedEventArgs> StickTiltChanged;


        /// <summary>
        /// Reset states of this control.
        /// </summary>
        public void Reset()
        {
            foreach (CheckBox checkBox in this.Directions)
            {
                checkBox.Checked = false;
            }
            this.StickClickButton.Reset();

        }

        private void StickClickButton_ButtonStateChanged(object sender, ButtonStateChangedEventArgs e)
        {
            StickClickStateChanged?.Invoke(this, e);
        }

        private void StickCheckBoxes_ChangeChecked(object sender, EventArgs e)
        {
            var senderBox = (CheckBox)sender;
            if (senderBox.Checked)
            {
                foreach (var otherCheckBox in this.Directions.Where(item => item != senderBox))
                {
                    otherCheckBox.Checked = false;
                }
            }
        }

        private void StickCheckBox_StickTiltChanged(byte x, byte y)
        {
            var e = new StickStateChangedEventArgs(this.StickID, x, y);
            this.StickTiltChanged?.Invoke(this, e);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e, StickAngle x, StickAngle y)
        {
            this.StickCheckBoxes_ChangeChecked(sender, e);
            if (((CheckBox)sender).Checked)
            {
                this.StickCheckBox_StickTiltChanged((byte)x, (byte)y);
            }
            else
            {
                this.StickCheckBox_StickTiltChanged((byte)StickAngle.NEUTRAL, (byte)StickAngle.NEUTRAL);
            }
        }

        private void UpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e, StickAngle.NEUTRAL, StickAngle.MIN);
        }

        private void URCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e, StickAngle.MAX, StickAngle.MIN);
        }

        private void RightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e, StickAngle.MAX, StickAngle.NEUTRAL);
        }

        private void DRCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e, StickAngle.MAX, StickAngle.MAX);
        }

        private void DownCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e, StickAngle.NEUTRAL, StickAngle.MAX);
        }

        private void DLCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e, StickAngle.MIN, StickAngle.MAX);
        }

        private void LeftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e, StickAngle.MIN, StickAngle.NEUTRAL);
        }

        private void ULCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e, StickAngle.MIN, StickAngle.MIN);
        }
    }
}
