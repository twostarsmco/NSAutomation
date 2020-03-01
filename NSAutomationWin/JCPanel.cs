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
    /// <summary>
    /// A UserControl that simulates controller of the device.
    /// </summary>
    public partial class JCPanel : UserControl
    {
        /// <summary>
        /// Whether this instance can raise Changed events
        /// </summary>
        private bool CanRaiseChangedEvents;


        // TODO: Control sticks
        /// <summary>
        /// A event raised when state of any one of button is changed.
        /// </summary>
        public event EventHandler<ButtonStateChangedEventArgs> ButtonStateChanged;

        /// <summary>
        /// A event raised when state of any one of stick's tilt is changed.
        /// </summary>
        public event EventHandler<StickStateChangedEventArgs> StickStateChanged;

        public JCPanel()
        {
            InitializeComponent();
            this.CanRaiseChangedEvents = true;
        }

        private void OnAnyButtonStateChanged(object sender, ButtonStateChangedEventArgs e)
        {
            if (this.CanRaiseChangedEvents)
            {
                ButtonStateChanged?.Invoke(this, e);
            }
        }


        private void OnAnyStickTiltChanged(object sender, StickStateChangedEventArgs e)
        {
            if (this.CanRaiseChangedEvents)
            {
                StickStateChanged?.Invoke(this, e);
            }
        }

        public void Reset()
        {
            this.CanRaiseChangedEvents = false;

            foreach (Control control in this.Controls)
            {
                if (control is ButtonStateSelector bss)
                {
                    bss.Reset();
                }
                else if (control is StickStateSelector sss)
                {
                    sss.Reset();
                }
            }
            this.CanRaiseChangedEvents = true;
        }
    }
}
