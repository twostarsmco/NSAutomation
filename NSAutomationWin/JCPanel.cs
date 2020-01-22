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
    public partial class JCPanel : UserControl
    {
        // TODO: Control sticks

        public event EventHandler<ButtonStateChangedEventArgs> ButtonStateChanged;

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
