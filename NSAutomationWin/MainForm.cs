using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

using Newtonsoft.Json;

using Common;
using Command;

namespace NSAutomationWin
{
    public partial class MainForm : Form
    {
        private Config Config;

        private IOutputPort Port;

        private MacroRunner Runner;

        private CancellationTokenSource CancellationToken;

        public MainForm(Config config, IOutputPort port, MacroRunner runner)
        {
            InitializeComponent();
            SetToolStripControls();
            SetLoopCountNumericUpDownEnabled();

            this.Config = config;
            this.Port = port;
            this.Runner = runner;

            this.Config.AutoSave = true;
            //Set available SerialPorts
            var cbxItems = this.COMSelectToolStripComboBox.Items;
            cbxItems.Add("");
            cbxItems.AddRange(SerialPort.GetPortNames());
            if (config.Online && cbxItems.Contains(config.COMPort.ToString()))
            {
                this.COMSelectToolStripComboBox.SelectedItem = config.COMPort.ToString();
            }
            else
            {
                this.COMSelectToolStripComboBox.SelectedItem = "";
            }
        }

        private void SetToolStripControls()
        {
            this.MenuToolStrip.Items.Add(new ToolStripControlHost(this.LoopCheckBox) { Enabled = true });
            this.MenuToolStrip.Items.Add(new ToolStripControlHost(this.LoopCountNumericUpDown) { Enabled = true });
        }
        private void SetLoopCountNumericUpDownEnabled()
        {
            this.LoopCountNumericUpDown.Enabled = this.LoopCheckBox.Checked;
        }

        private void SetPort(string comPortName) 
        {
            try
            {
                if (Config.Online)
                {
                    this.Port.PortName = comPortName;
                }
            }
            catch (Exception)
            {

            }
        }

        private async Task Run()
        {
            Macro macro = this.macroDesigner1.CurrentMacro;
            this.CancellationToken = new CancellationTokenSource();
            var token = this.CancellationToken.Token;

            int loopCount = this.LoopCheckBox.Checked? 0: 1;
            await this.Runner.RunAsync(macro, token, loopCount);  // TODO: show progress of macro
        }


        private async void Cancel()
        {
            this.CancellationToken.Cancel();
            await this.Runner.RunAsync(MacroExamples.NeutralizeAllInput);
        }


        private async void JC_ButtonStateChanged(object sender, ButtonStateChangedEventArgs e)
        {
            Macro macro;
            if (e.IsOnePush)
            {
                macro = new Macro(new CommandBase[]
                {
                new OperateButton(e.ButtonID, Command.ButtonState.PRESS),
                new Wait(30),
                new OperateButton(e.ButtonID, Command.ButtonState.RELEASE),
                });
            }
            else
            {
                macro = new Macro(new CommandBase[] { new OperateButton(e.ButtonID, e.ButtonState) });
            }
            await this.Runner.RunAsync(macro);
        }

        private void PortSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.COMSelectToolStripComboBox.SelectedItem.ToString();
            this.SetPort(selected);
            if (!(string.IsNullOrEmpty(selected)))
            {
                this.Config.Online = true;
                this.Config.COMPort = selected;
                this.Port.PortName = this.Config.COMPort;
            }
            else
            {
                this.Config.Online = false;
                this.Config.COMPort = "";
                this.Port.PortName = "";
            }
        }




        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string macroJson = "";
                using (OpenFileDialog ofd = new OpenFileDialog()
                { Filter = "JSON file|*.json|All Files|*.*" })
                {
                    ofd.ShowDialog();
                    if (ofd.FileName == "") return;

                    macroJson = File.ReadAllText(ofd.FileName);
                }
                var macro = Macro.FromJSON(macroJson);
                this.macroDesigner1.CurrentMacro = macro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Failed to load a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog()
                { Filter = "JSON file|*.json|All Files|*.*" })
                {
                    sfd.ShowDialog();
                    if (sfd.FileName != "")
                    {
                        var macro = macroDesigner1.CurrentMacro;
                        string macroJson = macro.ToJSON();
                        File.WriteAllText(sfd.FileName, macroJson);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Failed to save a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void RunToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = ((ToolStripButton)sender);
            if (checkbox.Checked)
            {
                await this.Run();
                checkbox.CheckedChanged -= RunToolStripButton_CheckedChanged;
                checkbox.Checked = false;
                checkbox.CheckedChanged += RunToolStripButton_CheckedChanged;
            }
            else
            {
                this.Cancel();
            }
        }

        private void LoopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetLoopCountNumericUpDownEnabled();
        }


        private void LoopCountNumericUpDown_EnabledChanged(object sender, EventArgs e)
        {
            SetLoopCountNumericUpDownEnabled();
        }

    }
}
