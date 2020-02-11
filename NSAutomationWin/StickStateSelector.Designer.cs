namespace NSAutomationWin
{
    partial class StickStateSelector
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
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.DownCheckBox = new System.Windows.Forms.CheckBox();
            this.DLCheckBox = new System.Windows.Forms.CheckBox();
            this.ULCheckBox = new System.Windows.Forms.CheckBox();
            this.UpCheckBox = new System.Windows.Forms.CheckBox();
            this.URCheckBox = new System.Windows.Forms.CheckBox();
            this.RightCheckBox = new System.Windows.Forms.CheckBox();
            this.DRCheckBox = new System.Windows.Forms.CheckBox();
            this.LeftCheckBox = new System.Windows.Forms.CheckBox();
            this.StickClickButton = new NSAutomationWin.ButtonStateSelector();
            this.Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Layout
            // 
            this.Layout.ColumnCount = 3;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Layout.Controls.Add(this.DownCheckBox, 0, 2);
            this.Layout.Controls.Add(this.DLCheckBox, 0, 2);
            this.Layout.Controls.Add(this.ULCheckBox, 0, 0);
            this.Layout.Controls.Add(this.UpCheckBox, 1, 0);
            this.Layout.Controls.Add(this.URCheckBox, 2, 0);
            this.Layout.Controls.Add(this.RightCheckBox, 2, 1);
            this.Layout.Controls.Add(this.DRCheckBox, 2, 2);
            this.Layout.Controls.Add(this.LeftCheckBox, 0, 1);
            this.Layout.Controls.Add(this.StickClickButton, 1, 1);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(0, 0);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 3;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Layout.Size = new System.Drawing.Size(200, 200);
            this.Layout.TabIndex = 0;
            // 
            // DownCheckBox
            // 
            this.DownCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.DownCheckBox.AutoSize = true;
            this.DownCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownCheckBox.Location = new System.Drawing.Point(69, 135);
            this.DownCheckBox.Name = "DownCheckBox";
            this.DownCheckBox.Size = new System.Drawing.Size(60, 62);
            this.DownCheckBox.TabIndex = 36;
            this.DownCheckBox.Text = "↓";
            this.DownCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DownCheckBox.UseVisualStyleBackColor = true;
            this.DownCheckBox.CheckedChanged += new System.EventHandler(this.DownCheckBox_CheckedChanged);
            // 
            // DLCheckBox
            // 
            this.DLCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.DLCheckBox.AutoSize = true;
            this.DLCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DLCheckBox.Location = new System.Drawing.Point(3, 135);
            this.DLCheckBox.Name = "DLCheckBox";
            this.DLCheckBox.Size = new System.Drawing.Size(60, 62);
            this.DLCheckBox.TabIndex = 35;
            this.DLCheckBox.Text = "↙";
            this.DLCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DLCheckBox.UseVisualStyleBackColor = true;
            this.DLCheckBox.CheckedChanged += new System.EventHandler(this.DLCheckBox_CheckedChanged);
            // 
            // ULCheckBox
            // 
            this.ULCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ULCheckBox.AutoSize = true;
            this.ULCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ULCheckBox.Location = new System.Drawing.Point(3, 3);
            this.ULCheckBox.Name = "ULCheckBox";
            this.ULCheckBox.Size = new System.Drawing.Size(60, 60);
            this.ULCheckBox.TabIndex = 33;
            this.ULCheckBox.Text = "↖";
            this.ULCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ULCheckBox.UseVisualStyleBackColor = true;
            this.ULCheckBox.CheckedChanged += new System.EventHandler(this.ULCheckBox_CheckedChanged);
            // 
            // UpCheckBox
            // 
            this.UpCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.UpCheckBox.AutoSize = true;
            this.UpCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpCheckBox.Location = new System.Drawing.Point(69, 3);
            this.UpCheckBox.Name = "UpCheckBox";
            this.UpCheckBox.Size = new System.Drawing.Size(60, 60);
            this.UpCheckBox.TabIndex = 34;
            this.UpCheckBox.Text = "↑";
            this.UpCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpCheckBox.UseVisualStyleBackColor = true;
            this.UpCheckBox.CheckedChanged += new System.EventHandler(this.UpCheckBox_CheckedChanged);
            // 
            // URCheckBox
            // 
            this.URCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.URCheckBox.AutoSize = true;
            this.URCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.URCheckBox.Location = new System.Drawing.Point(135, 3);
            this.URCheckBox.Name = "URCheckBox";
            this.URCheckBox.Size = new System.Drawing.Size(62, 60);
            this.URCheckBox.TabIndex = 37;
            this.URCheckBox.Text = "↗";
            this.URCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.URCheckBox.UseVisualStyleBackColor = true;
            this.URCheckBox.CheckedChanged += new System.EventHandler(this.URCheckBox_CheckedChanged);
            // 
            // RightCheckBox
            // 
            this.RightCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.RightCheckBox.AutoSize = true;
            this.RightCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightCheckBox.Location = new System.Drawing.Point(135, 69);
            this.RightCheckBox.Name = "RightCheckBox";
            this.RightCheckBox.Size = new System.Drawing.Size(62, 60);
            this.RightCheckBox.TabIndex = 38;
            this.RightCheckBox.Text = "→";
            this.RightCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RightCheckBox.UseVisualStyleBackColor = true;
            this.RightCheckBox.CheckedChanged += new System.EventHandler(this.RightCheckBox_CheckedChanged);
            // 
            // DRCheckBox
            // 
            this.DRCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.DRCheckBox.AutoSize = true;
            this.DRCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DRCheckBox.Location = new System.Drawing.Point(135, 135);
            this.DRCheckBox.Name = "DRCheckBox";
            this.DRCheckBox.Size = new System.Drawing.Size(62, 62);
            this.DRCheckBox.TabIndex = 39;
            this.DRCheckBox.Text = "↘";
            this.DRCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DRCheckBox.UseVisualStyleBackColor = true;
            this.DRCheckBox.CheckedChanged += new System.EventHandler(this.DRCheckBox_CheckedChanged);
            // 
            // LeftCheckBox
            // 
            this.LeftCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.LeftCheckBox.AutoSize = true;
            this.LeftCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftCheckBox.Location = new System.Drawing.Point(3, 69);
            this.LeftCheckBox.Name = "LeftCheckBox";
            this.LeftCheckBox.Size = new System.Drawing.Size(60, 60);
            this.LeftCheckBox.TabIndex = 41;
            this.LeftCheckBox.Text = "←";
            this.LeftCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LeftCheckBox.UseVisualStyleBackColor = true;
            this.LeftCheckBox.CheckedChanged += new System.EventHandler(this.LeftCheckBox_CheckedChanged);
            // 
            // StickClickButton
            // 
            this.StickClickButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StickClickButton.ButtonID = Command.ButtonID.LCLICK;
            this.StickClickButton.Location = new System.Drawing.Point(68, 68);
            this.StickClickButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StickClickButton.Name = "StickClickButton";
            this.StickClickButton.ShortcutKey = System.Windows.Forms.Keys.None;
            this.StickClickButton.Size = new System.Drawing.Size(62, 62);
            this.StickClickButton.TabIndex = 42;
            // 
            // StickStateSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Layout);
            this.Name = "StickStateSelector";
            this.Size = new System.Drawing.Size(200, 200);
            this.Layout.ResumeLayout(false);
            this.Layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layout;
        private System.Windows.Forms.CheckBox ULCheckBox;
        private System.Windows.Forms.CheckBox LeftCheckBox;
        private System.Windows.Forms.CheckBox DRCheckBox;
        private System.Windows.Forms.CheckBox RightCheckBox;
        private System.Windows.Forms.CheckBox URCheckBox;
        private System.Windows.Forms.CheckBox DownCheckBox;
        private System.Windows.Forms.CheckBox DLCheckBox;
        private System.Windows.Forms.CheckBox UpCheckBox;
        private ButtonStateSelector StickClickButton;
    }
}
