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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacroDesigner));
            this.CommandsDataGridView = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DeleteAllButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.CutButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
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
            this.CommandsDataGridView.Location = new System.Drawing.Point(35, 3);
            this.CommandsDataGridView.Name = "CommandsDataGridView";
            this.CommandsDataGridView.ReadOnly = true;
            this.CommandsDataGridView.RowHeadersWidth = 51;
            this.CommandsDataGridView.RowTemplate.Height = 24;
            this.CommandsDataGridView.Size = new System.Drawing.Size(400, 270);
            this.CommandsDataGridView.TabIndex = 0;
            this.CommandsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CommandsDataGridView_CellDoubleClick);
            this.CommandsDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandsDataGridView_KeyDown);
            // 
            // DeleteAllButton
            // 
            this.DeleteAllButton.AutoSize = true;
            this.DeleteAllButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteAllButton.Image = global::NSAutomationWin.Properties.Resources.DeleteAllRows_16x;
            this.DeleteAllButton.Location = new System.Drawing.Point(3, 201);
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.Size = new System.Drawing.Size(22, 22);
            this.DeleteAllButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.DeleteAllButton, "Delete all commands");
            this.DeleteAllButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditButton.Image = global::NSAutomationWin.Properties.Resources.EditFieldDialog_16x;
            this.EditButton.Location = new System.Drawing.Point(3, 61);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(22, 22);
            this.EditButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.EditButton, "Edit selected command");
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.AutoSize = true;
            this.CopyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CopyButton.Image = global::NSAutomationWin.Properties.Resources.Copy_16x;
            this.CopyButton.Location = new System.Drawing.Point(3, 117);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(22, 22);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // CutButton
            // 
            this.CutButton.AutoSize = true;
            this.CutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CutButton.Image = global::NSAutomationWin.Properties.Resources.Cut_16x;
            this.CutButton.Location = new System.Drawing.Point(3, 89);
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(22, 22);
            this.CutButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.CutButton, "Cut selected commands");
            this.CutButton.UseVisualStyleBackColor = true;
            this.CutButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.AutoSize = true;
            this.PasteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PasteButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteButton.Image")));
            this.PasteButton.Location = new System.Drawing.Point(3, 145);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(22, 22);
            this.PasteButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.PasteButton, "Paste");
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Image = global::NSAutomationWin.Properties.Resources.DeleteTableRow_16x;
            this.DeleteButton.Location = new System.Drawing.Point(3, 173);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(22, 22);
            this.DeleteButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.DeleteButton, "Delete selected command");
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.AutoSize = true;
            this.InsertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertButton.Image = global::NSAutomationWin.Properties.Resources.InsertClause_16x;
            this.InsertButton.Location = new System.Drawing.Point(3, 32);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(22, 22);
            this.InsertButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.InsertButton, "Insert");
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Image = global::NSAutomationWin.Properties.Resources.AddBottomFrame_16x;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(22, 22);
            this.AddButton.TabIndex = 1;
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
            this.Controls.Add(this.DeleteAllButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.CutButton);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Button CutButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button DeleteAllButton;
    }
}
