namespace NSAutomationWin
{
    partial class MacroDesigner
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CommandsDataGridView = new System.Windows.Forms.DataGridView();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PasteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandWrapperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CommandsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandWrapperBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CommandsDataGridView
            // 
            this.CommandsDataGridView.AllowUserToAddRows = false;
            this.CommandsDataGridView.AllowUserToDeleteRows = false;
            this.CommandsDataGridView.AllowUserToResizeColumns = false;
            this.CommandsDataGridView.AllowUserToResizeRows = false;
            this.CommandsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandsDataGridView.AutoGenerateColumns = false;
            this.CommandsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommandsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn});
            this.CommandsDataGridView.DataSource = this.commandWrapperBindingSource;
            this.CommandsDataGridView.Location = new System.Drawing.Point(32, 3);
            this.CommandsDataGridView.Name = "CommandsDataGridView";
            this.CommandsDataGridView.ReadOnly = true;
            this.CommandsDataGridView.RowHeadersWidth = 51;
            this.CommandsDataGridView.RowTemplate.Height = 24;
            this.CommandsDataGridView.Size = new System.Drawing.Size(400, 270);
            this.CommandsDataGridView.TabIndex = 0;
            this.CommandsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CommandsDataGridView_CellDoubleClick);
            this.CommandsDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandsDataGridView_KeyDown);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(3, 32);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(23, 23);
            this.InsertButton.TabIndex = 2;
            this.InsertButton.Text = "Insert";
            this.toolTip1.SetToolTip(this.InsertButton, "Insert");
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(3, 90);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(23, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.DeleteButton, "Delete selected command");
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(3, 61);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(23, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.toolTip1.SetToolTip(this.EditButton, "Edit selected command");
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.Location = new System.Drawing.Point(3, 119);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(23, 23);
            this.PasteButton.TabIndex = 3;
            this.PasteButton.Text = "Paste";
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(23, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.toolTip1.SetToolTip(this.AddButton, "Add");
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Command";
            this.textDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commandWrapperBindingSource
            // 
            this.commandWrapperBindingSource.DataSource = typeof(NSAutomationWin.CommandWrapper);
            // 
            // MacroDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CommandsDataGridView);
            this.Name = "MacroDesigner";
            this.Size = new System.Drawing.Size(435, 276);
            ((System.ComponentModel.ISupportInitialize)(this.CommandsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandWrapperBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CommandsDataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.BindingSource commandWrapperBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button PasteButton;
    }
}
