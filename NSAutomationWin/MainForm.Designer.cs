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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RunCheckBox = new System.Windows.Forms.CheckBox();
            this.PortSelectComboBox = new System.Windows.Forms.ComboBox();
            this.LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.JC = new NSAutomationWin.JCPanel();
            this.macroDesigner1 = new NSAutomationWin.MacroDesigner();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.Location = new System.Drawing.Point(11, 10);
            this.SplitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.JC);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.panel1);
            this.SplitContainer.Panel2.Controls.Add(this.macroDesigner1);
            this.SplitContainer.Panel2.Controls.Add(this.PortSelectComboBox);
            this.SplitContainer.Panel2.Controls.Add(this.LoopCheckBox);
            this.SplitContainer.Panel2.Controls.Add(this.SaveButton);
            this.SplitContainer.Panel2.Controls.Add(this.LoadButton);
            this.SplitContainer.Size = new System.Drawing.Size(986, 540);
            this.SplitContainer.SplitterDistance = 455;
            this.SplitContainer.SplitterWidth = 3;
            this.SplitContainer.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RunCheckBox);
            this.panel1.Location = new System.Drawing.Point(450, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 23);
            this.panel1.TabIndex = 8;
            // 
            // RunCheckBox
            // 
            this.RunCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.RunCheckBox.AutoSize = true;
            this.RunCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RunCheckBox.Location = new System.Drawing.Point(0, 0);
            this.RunCheckBox.Name = "RunCheckBox";
            this.RunCheckBox.Size = new System.Drawing.Size(75, 23);
            this.RunCheckBox.TabIndex = 7;
            this.RunCheckBox.Text = "Run";
            this.RunCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RunCheckBox.UseVisualStyleBackColor = true;
            this.RunCheckBox.CheckedChanged += new System.EventHandler(this.RunCheckBox_CheckedChanged);
            // 
            // PortSelectComboBox
            // 
            this.PortSelectComboBox.FormattingEnabled = true;
            this.PortSelectComboBox.Location = new System.Drawing.Point(451, 61);
            this.PortSelectComboBox.Name = "PortSelectComboBox";
            this.PortSelectComboBox.Size = new System.Drawing.Size(74, 20);
            this.PortSelectComboBox.TabIndex = 5;
            this.PortSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.PortSelectComboBox_SelectedIndexChanged);
            // 
            // LoopCheckBox
            // 
            this.LoopCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopCheckBox.AutoSize = true;
            this.LoopCheckBox.Location = new System.Drawing.Point(479, 116);
            this.LoopCheckBox.Name = "LoopCheckBox";
            this.LoopCheckBox.Size = new System.Drawing.Size(48, 16);
            this.LoopCheckBox.TabIndex = 4;
            this.LoopCheckBox.Text = "Loop";
            this.LoopCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(450, 32);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadButton.Location = new System.Drawing.Point(450, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // JC
            // 
            this.JC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JC.Location = new System.Drawing.Point(0, 0);
            this.JC.Margin = new System.Windows.Forms.Padding(2);
            this.JC.Name = "JC";
            this.JC.Size = new System.Drawing.Size(455, 540);
            this.JC.TabIndex = 0;
            this.JC.ButtonStateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.JC_ButtonStateChanged);
            // 
            // macroDesigner1
            // 
            this.macroDesigner1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.macroDesigner1.Location = new System.Drawing.Point(2, 2);
            this.macroDesigner1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.macroDesigner1.Name = "macroDesigner1";
            this.macroDesigner1.Size = new System.Drawing.Size(447, 536);
            this.macroDesigner1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.SplitContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "NSAutomationWin";
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer SplitContainer;
        private JCPanel JC;
        private System.Windows.Forms.CheckBox LoopCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.ComboBox PortSelectComboBox;
        private MacroDesigner macroDesigner1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox RunCheckBox;
    }
}

