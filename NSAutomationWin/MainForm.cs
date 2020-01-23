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


        private void Cancel()
        {
            this.CancellationToken.Cancel();
        }


        private async void JC_ButtonStateChanged(object sender, ButtonStateChangedEventArgs e)
        {
            Macro macro;
            if (e.IsOnePush)
            {
                macro = new Macro(new ICommand[]
                {
                new OperateButton(e.ButtonID, Command.ButtonState.PRESS),
                new Wait(30),
                new OperateButton(e.ButtonID, Command.ButtonState.RELEASE),
                });
            }
            else
            {
                macro = new Macro(new ICommand[] { new OperateButton(e.ButtonID, e.ButtonState) });
            }
            await this.Runner.RunAsync(macro, new CancellationToken(), 1);
        }

        private void PortSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetPort(this.PortSelectComboBox.SelectedItem.ToString());
        }


        private async void RunCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            var checkbox = ((CheckBox)sender);
            if (checkbox.Checked)
            {
                await this.Run();
                checkbox.CheckedChanged -= RunCheckBox_CheckedChanged;
                checkbox.Checked = false;
                checkbox.CheckedChanged += RunCheckBox_CheckedChanged;
            }
            else
            {
                this.Cancel();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog()
                { Filter = "JSON file|*.json|All Files|*.*" })
                {
                    sfd.ShowDialog();
                    if (sfd.FileName != "")
                    {
                        var jss = new JsonSerializerSettings()
                        {
                            TypeNameHandling = TypeNameHandling.Auto,
                            Formatting = Formatting.Indented
                        };
                        var macro = macroDesigner1.CurrentMacro;
                        string macroJson = JsonConvert.SerializeObject(macro, jss);
                        File.WriteAllText(sfd.FileName, macroJson);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Failed to save a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
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
                var macro = JsonConvert.DeserializeObject<Macro>(
                    macroJson,new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                this.macroDesigner1.CurrentMacro = macro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Failed to load a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
