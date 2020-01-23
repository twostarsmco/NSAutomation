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
            this.Commands.Add(new CommandWrapper(new Wait(100)));
            this.Commands.Add(new CommandWrapper(new OperateButton(ButtonID.A, Command.ButtonState.RELEASE)));

            this.CommandsDataGridView.DataSource = this.Commands;
        }

        private void MacroDesigner_Load(object sender, EventArgs e)
        {

        }


        public Macro CurrentMacro
        {
            get
            { 
                ICommand[] commands = this.Commands.Select(c => c.Command).ToArray();
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
                }
                finally
                {
                    this.Commands.RaiseListChangedEvents = true;
                    this.Commands.ResetBindings();
                }
                // TODO: Insert Description property here
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
            var c = CommandEditDialog.CreateNewCommandFromDialog();
            if (c != null) this.Commands.Insert(CommandsDataGridView.CurrentCell.RowIndex, new CommandWrapper(c));
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            var current = this.Commands[CommandsDataGridView.CurrentCell.RowIndex].Command;
            var cNew = CommandEditDialog.CreateNewCommandFromDialog(current);
            if (cNew != null) this.Commands[CommandsDataGridView.CurrentCell.RowIndex] = new CommandWrapper(cNew);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SortedSet<int> targetRows = new SortedSet<int>();
            foreach (DataGridViewCell item in CommandsDataGridView.SelectedCells) targetRows.Add(item.RowIndex);

            foreach (int i in targetRows.Reverse())
            {
                if (i < Commands.Count)
                    Commands.RemoveAt(i);
            }
        }

        private void CommandsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = this.Commands[e.RowIndex].Command;
            var cNew = CommandEditDialog.CreateNewCommandFromDialog(current);
            if (cNew != null) this.Commands[e.RowIndex] = new CommandWrapper(cNew);
        }
        #endregion
    }

}
