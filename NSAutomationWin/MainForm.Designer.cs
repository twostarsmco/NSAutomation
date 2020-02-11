namespace NSAutomationWin
{
    partial class MainForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.macroDesigner1 = new NSAutomationWin.MacroDesigner();
            this.JC = new NSAutomationWin.JCPanel();
            this.LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.MenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.COMSelectToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RunToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LoopCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.MenuToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoopCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.Location = new System.Drawing.Point(11, 33);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.macroDesigner1);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.JC);
            this.SplitContainer.Size = new System.Drawing.Size(991, 407);
            this.SplitContainer.SplitterDistance = 519;
            this.SplitContainer.SplitterWidth = 3;
            this.SplitContainer.TabIndex = 1;
            // 
            // macroDesigner1
            // 
            this.macroDesigner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.macroDesigner1.Location = new System.Drawing.Point(0, 0);
            this.macroDesigner1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.macroDesigner1.Name = "macroDesigner1";
            this.macroDesigner1.Size = new System.Drawing.Size(519, 407);
            this.macroDesigner1.TabIndex = 6;
            // 
            // JC
            // 
            this.JC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JC.Location = new System.Drawing.Point(0, 0);
            this.JC.Margin = new System.Windows.Forms.Padding(2);
            this.JC.Name = "JC";
            this.JC.Size = new System.Drawing.Size(469, 407);
            this.JC.TabIndex = 9;
            // 
            // LoopCheckBox
            // 
            this.LoopCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopCheckBox.AutoSize = true;
            this.LoopCheckBox.Location = new System.Drawing.Point(317, 12);
            this.LoopCheckBox.Name = "LoopCheckBox";
            this.LoopCheckBox.Size = new System.Drawing.Size(48, 16);
            this.LoopCheckBox.TabIndex = 4;
            this.LoopCheckBox.Text = "Loop";
            this.LoopCheckBox.UseVisualStyleBackColor = true;
            this.LoopCheckBox.Visible = false;
            this.LoopCheckBox.CheckedChanged += new System.EventHandler(this.LoopCheckBox_CheckedChanged);
            // 
            // MenuToolStrip
            // 
            this.MenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.toolStripSeparator1,
            this.COMSelectToolStripComboBox,
            this.toolStripSeparator2,
            this.RunToolStripButton});
            this.MenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuToolStrip.Name = "MenuToolStrip";
            this.MenuToolStrip.Size = new System.Drawing.Size(1013, 25);
            this.MenuToolStrip.TabIndex = 9;
            this.MenuToolStrip.Text = "toolStrip1";
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.Image = global::NSAutomationWin.Properties.Resources.OpenFolder_16x;
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.OpenToolStripButton.Text = "Open";
            this.OpenToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.Image = global::NSAutomationWin.Properties.Resources.Save_16x;
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.SaveToolStripButton.Text = "Save";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // COMSelectToolStripComboBox
            // 
            this.COMSelectToolStripComboBox.Name = "COMSelectToolStripComboBox";
            this.COMSelectToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // RunToolStripButton
            // 
            this.RunToolStripButton.CheckOnClick = true;
            this.RunToolStripButton.Image = global::NSAutomationWin.Properties.Resources.Run_16x;
            this.RunToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RunToolStripButton.Name = "RunToolStripButton";
            this.RunToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.RunToolStripButton.Text = "Run";
            this.RunToolStripButton.CheckedChanged += new System.EventHandler(this.RunToolStripButton_CheckedChanged);
            // 
            // LoopCountNumericUpDown
            // 
            this.LoopCountNumericUpDown.Location = new System.Drawing.Point(388, 12);
            this.LoopCountNumericUpDown.Name = "LoopCountNumericUpDown";
            this.LoopCountNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.LoopCountNumericUpDown.TabIndex = 10;
            this.LoopCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LoopCountNumericUpDown.Visible = false;
            this.LoopCountNumericUpDown.EnabledChanged += new System.EventHandler(this.LoopCountNumericUpDown_EnabledChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 451);
            this.Controls.Add(this.LoopCountNumericUpDown);
            this.Controls.Add(this.LoopCheckBox);
            this.Controls.Add(this.MenuToolStrip);
            this.Controls.Add(this.SplitContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "NSAutomationWin";
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.MenuToolStrip.ResumeLayout(false);
            this.MenuToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoopCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.CheckBox LoopCheckBox;
        private MacroDesigner macroDesigner1;
        private JCPanel JC;
        private System.Windows.Forms.ToolStrip MenuToolStrip;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton RunToolStripButton;
        private System.Windows.Forms.ToolStripComboBox COMSelectToolStripComboBox;
        private System.Windows.Forms.NumericUpDown LoopCountNumericUpDown;
    }
}

