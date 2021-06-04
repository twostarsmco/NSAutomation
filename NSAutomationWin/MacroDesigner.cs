using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Command;

namespace NSAutomationWin
{
    public partial class MacroDesigner : UserControl
    {

        private BindingList<CommandWrapper> Commands = new BindingList<CommandWrapper>()
        { AllowNew = true, AllowEdit = true, AllowRemove = true };

        public MacroDesigner()
        {
            InitializeComponent();
            this.Commands.Add(new CommandWrapper(new OperateButton(ButtonID.A, Command.ButtonState.PRESS)));
            this.Commands.Add(new CommandWrapper(new Wait(500)));
            this.Commands.Add(new CommandWrapper(new OperateButton(ButtonID.A, Command.ButtonState.RELEASE)));
            this.Commands.Add(new CommandWrapper(new Wait(500)));

            this.CommandsDataGridView.DataSource = this.Commands;
        }


        public Macro CurrentMacro
        {
            get
            { 
                CommandBase[] commands = this.Commands.Select(c => c.Command).ToArray();
                var macro = new Macro(commands);
                // TODO: Insert Description property here

                return macro;
            }
            set
            {
                try
                {
                    this.Commands.RaiseListChangedEvents = false;
                    this.Commands.Clear();
                    foreach (var c in value.Commands)
                    {
                        this.Commands.Add(new CommandWrapper(c));
                    }
                    // TODO: Insert Description property here
                }
                finally
                {
                    this.Commands.RaiseListChangedEvents = true;
                    this.Commands.ResetBindings();
                }
            }
        }


        #region DataGridViewOperations

        private void AddButton_Click(object sender, EventArgs e)
        {
            var c = CommandEditDialog.CreateNewCommandFromDialog();
            if (c != null) this.Commands.Add(new CommandWrapper(c));
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (this.Commands.Count<1)
            {
                this.AddButton_Click(sender, e);
            }
            else
            {
                var c = CommandEditDialog.CreateNewCommandFromDialog();
                if (c != null) this.Commands.Insert(CommandsDataGridView.CurrentCell.RowIndex, new CommandWrapper(c));
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (this.Commands.Count > 0)
            {
                var current = this.Commands[CommandsDataGridView.CurrentCell.RowIndex].Command;
                var cNew = CommandEditDialog.CreateNewCommandFromDialog(current);
                if (cNew != null) this.Commands[CommandsDataGridView.CurrentCell.RowIndex] = new CommandWrapper(cNew);
            }
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            this.Copy();
            this.DeleteSelectedRows();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            this.Copy();
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            this.Paste(Clipboard.GetText());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.DeleteSelectedRows();
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            this.CommandsDataGridView.SelectAll();
            this.DeleteSelectedRows();
        }

        private void CommandsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X)
            {
                this.CutButton_Click(sender, e);
            } //Copy is handled naturally by DataGridView
            else if (e.Control && e.KeyCode == Keys.V)
            {
                this.Paste(Clipboard.GetText());
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                this.CommandsDataGridView.SelectAll();
            }
            else if (e.Control && e.KeyCode == Keys.I)
            {
                this.InsertButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                this.DeleteSelectedRows();
            }
        }

        private SortedSet<int> GetSelectedRows()
        {
            SortedSet<int> selectedRows = new SortedSet<int>();
            foreach (DataGridViewCell item in CommandsDataGridView.SelectedCells) selectedRows.Add(item.RowIndex);
            return selectedRows;
        }


        private void CommandsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = this.Commands[e.RowIndex].Command;
            var cNew = CommandEditDialog.CreateNewCommandFromDialog(current);
            if (cNew != null) this.Commands[e.RowIndex] = new CommandWrapper(cNew);
        }

        private void DeleteSelectedRows()
        {
            var targetRows = this.GetSelectedRows();
            
            foreach (int i in targetRows.Reverse())
            {
                if (i < Commands.Count)
                    Commands.RemoveAt(i);
            }
        }

        private void Copy()
        {
            var targetRows = this.GetSelectedRows();
            var commandsString = string.Join("\r\n", targetRows.Select(i => this.Commands[i].ToString()));
            if (!string.IsNullOrEmpty(commandsString))
            {
                Clipboard.SetText(commandsString);
            }
        }

        private void Paste(string s)
        {
            if (string.IsNullOrEmpty(s)) return;

            int currentRow =
                CommandsDataGridView.CurrentCell is null ? 0 :
                CommandsDataGridView.CurrentCell.RowIndex;
            string[] s_rows = s.Replace("\r\n", "\n").Split(new[] { '\n', '\r' });

            foreach (var commandString in s_rows)
            {
                try
                {
                    var cw = new CommandWrapper(commandString);
                    this.Commands.Insert(currentRow, cw);
                    currentRow++;
                    this.CommandsDataGridView.OffsetSelectedRange(1, 0);
                }
                catch (ArgumentException)
                {
                    continue;
                }
            }
        }
        #endregion


    }

}
