namespace NSAutomationWin
{
    partial class CommandEditDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CommandTypeTab = new System.Windows.Forms.TabControl();
            this.WaitTab = new System.Windows.Forms.TabPage();
            this.WaitTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.WaitTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.ButtonTab = new System.Windows.Forms.TabPage();
            this.ButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonStateComboBox = new System.Windows.Forms.ComboBox();
            this.StickTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.YUpDown = new System.Windows.Forms.NumericUpDown();
            this.XUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.StickLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.StickComboBox = new System.Windows.Forms.ComboBox();
            this.CommandTypeTab.SuspendLayout();
            this.WaitTab.SuspendLayout();
            this.WaitTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitTimeUpDown)).BeginInit();
            this.ButtonTab.SuspendLayout();
            this.ButtonTableLayoutPanel.SuspendLayout();
            this.StickTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(184, 238);
            this.OKButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(56, 24);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(245, 238);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(56, 24);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CommandTypeTab
            // 
            this.CommandTypeTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandTypeTab.Controls.Add(this.WaitTab);
            this.CommandTypeTab.Controls.Add(this.ButtonTab);
            this.CommandTypeTab.Controls.Add(this.StickTab);
            this.CommandTypeTab.Location = new System.Drawing.Point(9, 10);
            this.CommandTypeTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CommandTypeTab.Name = "CommandTypeTab";
            this.CommandTypeTab.SelectedIndex = 0;
            this.CommandTypeTab.Size = new System.Drawing.Size(292, 224);
            this.CommandTypeTab.TabIndex = 2;
            // 
            // WaitTab
            // 
            this.WaitTab.Controls.Add(this.WaitTableLayoutPanel);
            this.WaitTab.Location = new System.Drawing.Point(4, 22);
            this.WaitTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WaitTab.Name = "WaitTab";
            this.WaitTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WaitTab.Size = new System.Drawing.Size(284, 198);
            this.WaitTab.TabIndex = 0;
            this.WaitTab.Text = "Wait";
            this.WaitTab.UseVisualStyleBackColor = true;
            // 
            // WaitTableLayoutPanel
            // 
            this.WaitTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WaitTableLayoutPanel.ColumnCount = 2;
            this.WaitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.WaitTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WaitTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.WaitTableLayoutPanel.Controls.Add(this.WaitTimeUpDown, 1, 0);
            this.WaitTableLayoutPanel.Location = new System.Drawing.Point(4, 5);
            this.WaitTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WaitTableLayoutPanel.Name = "WaitTableLayoutPanel";
            this.WaitTableLayoutPanel.RowCount = 1;
            this.WaitTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WaitTableLayoutPanel.Size = new System.Drawing.Size(278, 191);
            this.WaitTableLayoutPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wait time (ms)";
            // 
            // WaitTimeUpDown
            // 
            this.WaitTimeUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WaitTimeUpDown.Location = new System.Drawing.Point(86, 86);
            this.WaitTimeUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WaitTimeUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.WaitTimeUpDown.Name = "WaitTimeUpDown";
            this.WaitTimeUpDown.Size = new System.Drawing.Size(190, 19);
            this.WaitTimeUpDown.TabIndex = 0;
            // 
            // ButtonTab
            // 
            this.ButtonTab.Controls.Add(this.ButtonTableLayoutPanel);
            this.ButtonTab.Location = new System.Drawing.Point(4, 22);
            this.ButtonTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonTab.Name = "ButtonTab";
            this.ButtonTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonTab.Size = new System.Drawing.Size(284, 198);
            this.ButtonTab.TabIndex = 1;
            this.ButtonTab.Text = "Button";
            this.ButtonTab.UseVisualStyleBackColor = true;
            // 
            // ButtonTableLayoutPanel
            // 
            this.ButtonTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonTableLayoutPanel.ColumnCount = 2;
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonTableLayoutPanel.Controls.Add(this.label2, 0, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.label3, 0, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonComboBox, 1, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.ButtonStateComboBox, 1, 1);
            this.ButtonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.ButtonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonTableLayoutPanel.Name = "ButtonTableLayoutPanel";
            this.ButtonTableLayoutPanel.RowCount = 2;
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTableLayoutPanel.Size = new System.Drawing.Size(280, 194);
            this.ButtonTableLayoutPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Button";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "State";
            // 
            // ButtonComboBox
            // 
            this.ButtonComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonComboBox.FormattingEnabled = true;
            this.ButtonComboBox.Location = new System.Drawing.Point(45, 40);
            this.ButtonComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonComboBox.Name = "ButtonComboBox";
            this.ButtonComboBox.Size = new System.Drawing.Size(233, 20);
            this.ButtonComboBox.TabIndex = 4;
            // 
            // ButtonStateComboBox
            // 
            this.ButtonStateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonStateComboBox.FormattingEnabled = true;
            this.ButtonStateComboBox.Location = new System.Drawing.Point(45, 137);
            this.ButtonStateComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonStateComboBox.Name = "ButtonStateComboBox";
            this.ButtonStateComboBox.Size = new System.Drawing.Size(233, 20);
            this.ButtonStateComboBox.TabIndex = 5;
            // 
            // StickTab
            // 
            this.StickTab.Controls.Add(this.tableLayoutPanel1);
            this.StickTab.Location = new System.Drawing.Point(4, 22);
            this.StickTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StickTab.Name = "StickTab";
            this.StickTab.Size = new System.Drawing.Size(284, 198);
            this.StickTab.TabIndex = 2;
            this.StickTab.Text = "Stick";
            this.StickTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.YUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.XUpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.StickLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.XLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StickComboBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 198);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // YUpDown
            // 
            this.YUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.YUpDown.Location = new System.Drawing.Point(37, 155);
            this.YUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.YUpDown.Name = "YUpDown";
            this.YUpDown.Size = new System.Drawing.Size(254, 19);
            this.YUpDown.TabIndex = 9;
            this.YUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // XUpDown
            // 
            this.XUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.XUpDown.Location = new System.Drawing.Point(37, 89);
            this.XUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.XUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.XUpDown.Name = "XUpDown";
            this.XUpDown.Size = new System.Drawing.Size(254, 19);
            this.XUpDown.TabIndex = 8;
            this.XUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y";
            // 
            // StickLabel
            // 
            this.StickLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StickLabel.AutoSize = true;
            this.StickLabel.Location = new System.Drawing.Point(2, 27);
            this.StickLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StickLabel.Name = "StickLabel";
            this.StickLabel.Size = new System.Drawing.Size(31, 12);
            this.StickLabel.TabIndex = 2;
            this.StickLabel.Text = "Stick";
            this.StickLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // XLabel
            // 
            this.XLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(2, 93);
            this.XLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(12, 12);
            this.XLabel.TabIndex = 3;
            this.XLabel.Text = "X";
            // 
            // StickComboBox
            // 
            this.StickComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StickComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StickComboBox.FormattingEnabled = true;
            this.StickComboBox.Location = new System.Drawing.Point(37, 23);
            this.StickComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StickComboBox.Name = "StickComboBox";
            this.StickComboBox.Size = new System.Drawing.Size(254, 20);
            this.StickComboBox.TabIndex = 4;
            // 
            // CommandEditDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(310, 272);
            this.Controls.Add(this.CommandTypeTab);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CommandEditDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.CommandEditDialog_Load);
            this.CommandTypeTab.ResumeLayout(false);
            this.WaitTab.ResumeLayout(false);
            this.WaitTableLayoutPanel.ResumeLayout(false);
            this.WaitTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitTimeUpDown)).EndInit();
            this.ButtonTab.ResumeLayout(false);
            this.ButtonTableLayoutPanel.ResumeLayout(false);
            this.ButtonTableLayoutPanel.PerformLayout();
            this.StickTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TabControl CommandTypeTab;
        private System.Windows.Forms.TabPage WaitTab;
        private System.Windows.Forms.TabPage ButtonTab;
        private System.Windows.Forms.TabPage StickTab;
        private System.Windows.Forms.TableLayoutPanel WaitTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown WaitTimeUpDown;
        private System.Windows.Forms.TableLayoutPanel ButtonTableLayoutPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ButtonComboBox;
        private System.Windows.Forms.ComboBox ButtonStateComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown XUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StickLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.ComboBox StickComboBox;
        private System.Windows.Forms.NumericUpDown YUpDown;
    }
}