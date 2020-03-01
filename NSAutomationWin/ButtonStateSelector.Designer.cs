namespace NSAutomationWin
{
    partial class ButtonStateSelector
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
            this.HoldCheckBox = new System.Windows.Forms.CheckBox();
            this.ButtonStateSelectCheckBox = new System.Windows.Forms.CheckBox();
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // HoldCheckBox
            // 
            this.HoldCheckBox.AutoSize = true;
            this.HoldCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoldCheckBox.Location = new System.Drawing.Point(2, 142);
            this.HoldCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HoldCheckBox.Name = "HoldCheckBox";
            this.HoldCheckBox.Size = new System.Drawing.Size(146, 16);
            this.HoldCheckBox.TabIndex = 0;
            this.HoldCheckBox.Text = "Hold";
            this.HoldCheckBox.UseVisualStyleBackColor = true;
            this.HoldCheckBox.CheckedChanged += new System.EventHandler(this.HoldCheckBox_CheckedChanged);
            // 
            // ButtonStateSelectCheckBox
            // 
            this.ButtonStateSelectCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ButtonStateSelectCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonStateSelectCheckBox.Location = new System.Drawing.Point(0, 0);
            this.ButtonStateSelectCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStateSelectCheckBox.MinimumSize = new System.Drawing.Size(15, 16);
            this.ButtonStateSelectCheckBox.Name = "ButtonStateSelectCheckBox";
            this.ButtonStateSelectCheckBox.Size = new System.Drawing.Size(150, 140);
            this.ButtonStateSelectCheckBox.TabIndex = 1;
            this.ButtonStateSelectCheckBox.Text = "ButtonName";
            this.ButtonStateSelectCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonStateSelectCheckBox.UseVisualStyleBackColor = true;
            this.ButtonStateSelectCheckBox.CheckedChanged += new System.EventHandler(this.ButtonStateSelectCheckBox_CheckedChanged);
            // 
            // Layout
            // 
            this.Layout.ColumnCount = 1;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.Controls.Add(this.ButtonStateSelectCheckBox, 0, 0);
            this.Layout.Controls.Add(this.HoldCheckBox, 0, 1);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(0, 0);
            this.Layout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 2;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Layout.Size = new System.Drawing.Size(150, 160);
            this.Layout.TabIndex = 2;
            // 
            // ButtonStateSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.Layout);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ButtonStateSelector";
            this.Size = new System.Drawing.Size(150, 160);
            this.Layout.ResumeLayout(false);
            this.Layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox HoldCheckBox;
        private System.Windows.Forms.CheckBox ButtonStateSelectCheckBox;
        private System.Windows.Forms.TableLayoutPanel Layout;
    }
}
