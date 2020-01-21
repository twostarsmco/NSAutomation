using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Common;

namespace NSAutomationWin
{
    public partial class MainForm : Form
    {
        private Config Config;

        private IOutputPort Port;

        private MacroRunner Runner;
        public MainForm(Config config, IOutputPort port, MacroRunner runner)
        {
            InitializeComponent();
            this.Config = config;
            this.Port = port;
            this.Runner = runner;
        }


        private void SetPort(string comPortName) 
        {
            
            if (Config.Online)
            {

            }
        }

        private void buttonStateSelector1_ButtonStateChanged(object sender, ButtonStateChangedEventArgs e)
        {
            if (e.ButtonState == Command.ButtonState.PRESS)
            {
                System.Diagnostics.Debug.Print($"{e.ButtonID.ToString()} pressed.");
            }
            else if (e.ButtonState == Command.ButtonState.RELEASE)
            {
                System.Diagnostics.Debug.Print($"{e.ButtonID.ToString()} released.");
            }
        }

        private void JC_ButtonStateChanged(object sender, ButtonStateChangedEventArgs e)
        {
            System.Diagnostics.Debug.Print($"{DateTime.Now.ToString("hh:mm:ss.fff")}\t{e.ButtonID}\t{e.ButtonState}");
        }
    }
}
