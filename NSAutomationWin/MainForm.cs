using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using Common;
using Command;

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

            //Set available SerialPorts
            var cbxItems = this.PortSelectComboBox.Items;
            cbxItems.Add("");
            cbxItems.AddRange(SerialPort.GetPortNames());
            if (config.Online && cbxItems.Contains(config.COMPort.ToString()))
            {
                this.PortSelectComboBox.SelectedItem = config.COMPort.ToString();
            }
            else
            {
                this.PortSelectComboBox.SelectedItem = "";
            }
        }


        private void SetPort(string comPortName) 
        {
            try
            {
                if (comPortName != "")
                {
                    this.Port.PortName = comPortName;
                    Config.Online = true;
                }
            }
            catch (Exception)
            {

            }
        }


        private void JC_ButtonStateChanged(object sender, ButtonStateChangedEventArgs e)
        {
            System.Diagnostics.Debug.Print($"{DateTime.Now.ToString("hh:mm:ss.fff")}\t{e.ButtonID}\t{e.ButtonState}");
        }

        private void PortSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetPort(this.PortSelectComboBox.SelectedItem.ToString());
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            Macro macro = this.macroDesigner1.OutputCurrentMacro();
            await this.Runner.RunAsync(macro);  // TODO: show progress of macro
        }
    }
}
