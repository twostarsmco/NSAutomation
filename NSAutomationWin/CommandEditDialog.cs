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
using Command;


namespace NSAutomationWin
{
    /// <summary>
    /// A Form to provide means to edit the following ICommand classes:
    /// Wait, OperateButton, OperateStick, ExternalMacro
    /// </summary>
    public partial class CommandEditDialog : Form
    {
        public ICommand EditedCommand;

        public CommandEditDialog():this(new Wait(0))
        {

        }
        
        public CommandEditDialog(ICommand commandToEdit)
        {
            InitializeComponent();

            this.EditedCommand = commandToEdit;

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            switch (CommandTypeTab.SelectedIndex)
            {
                case 0: //Wait
                    this.EditedCommand = new Wait((int)WaitTimeUpDown.Value);
                    break;

                case 1: //Button

                    this.EditedCommand = new OperateButton(
                        (ButtonID)ButtonComboBox.SelectedItem,
                        (Command.ButtonState)ButtonStateComboBox.SelectedItem);
                    break;

                case 2: //Stick

                    this.EditedCommand = new OperateStick(
                        (StickID)StickComboBox.SelectedItem,
                        (byte)XUpDown.Value, (byte)YUpDown.Value);
                    break;

                default:
                    break;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CommandEditDialog_Load(object sender, EventArgs e)
        {
            ButtonComboBox.DataSource = Enum.GetValues(typeof(Command.ButtonID));
            ButtonStateComboBox.DataSource = Enum.GetValues(typeof(Command.ButtonState));
            StickComboBox.DataSource = Enum.GetValues(typeof(Command.StickID));

            switch (this.EditedCommand)
            {
                case Wait w:
                    this.CommandTypeTab.SelectedIndex = 0;
                    WaitTimeUpDown.Value = (decimal)w.WaitTime;
                    break;

                case OperateButton b:
                    this.CommandTypeTab.SelectedIndex = 1;
                    ButtonComboBox.SelectedItem = b.ButtonID;
                    ButtonStateComboBox.SelectedItem = b.TargetState;
                    break;

                case OperateStick s:
                    this.CommandTypeTab.SelectedIndex = 2;
                    StickComboBox.SelectedItem = s.StickID;
                    XUpDown.Value = (decimal)s.TargetXAngle;
                    YUpDown.Value = (decimal)s.TargetYAngle;
                    break;

                default:    // TODO: implement ExternalMacro
                    CancelButton_Click(this, new EventArgs());
                    break;
            }
        }
        private void AdjustDialogLocation()
        { }



        public static ICommand CreateNewCommandFromDialog()
        {
            return CreateNewCommandFromDialog(new Wait(0));
        }

        public static ICommand CreateNewCommandFromDialog(ICommand existingCommand)
        {
            using (var dialog = new CommandEditDialog(existingCommand))
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return dialog.EditedCommand;
                }
                else
                {
                    return null;
                }
            }
        }

    }
}
