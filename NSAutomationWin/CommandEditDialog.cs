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
        /// <summary>
        /// A ICommand instance being edited on this form.
        /// This is updated based on form's state, only when OK button is pressed.
        /// </summary>
        public ICommand EditedCommand;


        /// <summary>
        /// Instantinate this form with default "Wait 0" command displayed.
        /// </summary>
        public CommandEditDialog() : this(new Wait(0)) { }


        /// <summary>
        /// Instantinate this form with given command displayed.
        /// </summary>
        /// <param name="commandToEdit">A command to edit. Initially displayed as-is on this form.</param>
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


        /// <summary>
        /// Upon loading, change initially displayed tab and its content according to given command.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// A method to adjust location of this form.
        /// </summary>
        private void AdjustDialogLocation()
        { }


        /// <summary>
        /// A static method that opens an instance of this form,
        /// then returns a command that is edited on it.
        /// </summary>
        /// <returns>An instance of ICommand. Returns null if cancel button is pressed.</returns>
        public static ICommand CreateNewCommandFromDialog()
        {
            return CreateNewCommandFromDialog(new Wait(0));
        }


        /// <summary>
        /// A static method that opens an instance of this form, displays given command,
        /// then returns a command that is edited on it.
        /// </summary>
        /// <param name="existingCommand"></param>
        /// <returns>An instance of ICommand. Returns null if cancel button is pressed.</returns>
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
