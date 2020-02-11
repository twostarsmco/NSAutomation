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
        // TODO: Control sticks
        /// <summary>
        /// A event raised when state of any one of button is changed.
        /// </summary>
        public event EventHandler<ButtonStateChangedEventArgs> ButtonStateChanged;

        /// <summary>
        /// A event raised when state of any one of stick's tilt is changed.
        /// </summary>
        public event EventHandler<ButtonStateChangedEventArgs> StickStateChanged;

        public JCPanel()
        {
            InitializeComponent();
        }

        private void OnAnyButtonStateChanged(object sender, ButtonStateChangedEventArgs e)
        {
            ButtonStateChanged?.Invoke(this, e);
        }
    }
}
