namespace NSAutomationWin
{
    partial class JCPanel
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ZL = new NSAutomationWin.ButtonStateSelector();
            this.L = new NSAutomationWin.ButtonStateSelector();
            this.Y = new NSAutomationWin.ButtonStateSelector();
            this.B = new NSAutomationWin.ButtonStateSelector();
            this.A = new NSAutomationWin.ButtonStateSelector();
            this.X = new NSAutomationWin.ButtonStateSelector();
            this.Plus = new NSAutomationWin.ButtonStateSelector();
            this.Minus = new NSAutomationWin.ButtonStateSelector();
            this.Down = new NSAutomationWin.ButtonStateSelector();
            this.Right = new NSAutomationWin.ButtonStateSelector();
            this.Left = new NSAutomationWin.ButtonStateSelector();
            this.Up = new NSAutomationWin.ButtonStateSelector();
            this.R = new NSAutomationWin.ButtonStateSelector();
            this.ZR = new NSAutomationWin.ButtonStateSelector();
            this.Capture = new NSAutomationWin.ButtonStateSelector();
            this.Home = new NSAutomationWin.ButtonStateSelector();
            this.LStickStateSelector = new NSAutomationWin.StickStateSelector();
            this.RStickStateSelector = new NSAutomationWin.StickStateSelector();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 9;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel.Controls.Add(this.ZL, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.L, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.Y, 6, 2);
            this.tableLayoutPanel.Controls.Add(this.B, 7, 3);
            this.tableLayoutPanel.Controls.Add(this.A, 8, 2);
            this.tableLayoutPanel.Controls.Add(this.X, 7, 1);
            this.tableLayoutPanel.Controls.Add(this.Plus, 5, 1);
            this.tableLayoutPanel.Controls.Add(this.Minus, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.Down, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.Right, 2, 6);
            this.tableLayoutPanel.Controls.Add(this.Left, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.Up, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.R, 8, 0);
            this.tableLayoutPanel.Controls.Add(this.ZR, 7, 0);
            this.tableLayoutPanel.Controls.Add(this.Capture, 3, 7);
            this.tableLayoutPanel.Controls.Add(this.Home, 5, 7);
            this.tableLayoutPanel.Controls.Add(this.LStickStateSelector, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.RStickStateSelector, 6, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(496, 426);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // ZL
            // 
            this.ZL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ZL.ButtonID = Command.ButtonID.ZL;
            this.ZL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZL.Location = new System.Drawing.Point(61, 2);
            this.ZL.Margin = new System.Windows.Forms.Padding(2);
            this.ZL.Name = "ZL";
            this.ZL.ShortcutKey = System.Windows.Forms.Keys.None;
            this.ZL.Size = new System.Drawing.Size(55, 55);
            this.ZL.TabIndex = 6;
            this.ZL.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // L
            // 
            this.L.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.L.ButtonID = Command.ButtonID.L;
            this.L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L.Location = new System.Drawing.Point(2, 2);
            this.L.Margin = new System.Windows.Forms.Padding(2);
            this.L.Name = "L";
            this.L.ShortcutKey = System.Windows.Forms.Keys.None;
            this.L.Size = new System.Drawing.Size(55, 55);
            this.L.TabIndex = 7;
            this.L.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // Y
            // 
            this.Y.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Y.ButtonID = Command.ButtonID.Y;
            this.Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Y.Location = new System.Drawing.Point(316, 120);
            this.Y.Margin = new System.Windows.Forms.Padding(2);
            this.Y.Name = "Y";
            this.Y.ShortcutKey = System.Windows.Forms.Keys.None;
            this.Y.Size = new System.Drawing.Size(55, 55);
            this.Y.TabIndex = 14;
            this.Y.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // B
            // 
            this.B.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B.ButtonID = Command.ButtonID.B;
            this.B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B.Location = new System.Drawing.Point(375, 179);
            this.B.Margin = new System.Windows.Forms.Padding(2);
            this.B.Name = "B";
            this.B.ShortcutKey = System.Windows.Forms.Keys.None;
            this.B.Size = new System.Drawing.Size(55, 55);
            this.B.TabIndex = 16;
            this.B.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // A
            // 
            this.A.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.A.ButtonID = Command.ButtonID.A;
            this.A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.A.Location = new System.Drawing.Point(434, 120);
            this.A.Margin = new System.Windows.Forms.Padding(2);
            this.A.Name = "A";
            this.A.ShortcutKey = System.Windows.Forms.Keys.None;
            this.A.Size = new System.Drawing.Size(60, 55);
            this.A.TabIndex = 15;
            this.A.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.X.ButtonID = Command.ButtonID.X;
            this.X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.X.Location = new System.Drawing.Point(375, 61);
            this.X.Margin = new System.Windows.Forms.Padding(2);
            this.X.Name = "X";
            this.X.ShortcutKey = System.Windows.Forms.Keys.None;
            this.X.Size = new System.Drawing.Size(55, 55);
            this.X.TabIndex = 13;
            this.X.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // Plus
            // 
            this.Plus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Plus.ButtonID = Command.ButtonID.PLUS;
            this.Plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plus.Location = new System.Drawing.Point(257, 61);
            this.Plus.Margin = new System.Windows.Forms.Padding(2);
            this.Plus.Name = "Plus";
            this.Plus.ShortcutKey = System.Windows.Forms.Keys.None;
            this.Plus.Size = new System.Drawing.Size(55, 55);
            this.Plus.TabIndex = 10;
            this.Plus.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // Minus
            // 
            this.Minus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Minus.ButtonID = Command.ButtonID.MINUS;
            this.Minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minus.Location = new System.Drawing.Point(179, 61);
            this.Minus.Margin = new System.Windows.Forms.Padding(2);
            this.Minus.Name = "Minus";
            this.Minus.ShortcutKey = System.Windows.Forms.Keys.None;
            this.Minus.Size = new System.Drawing.Size(55, 55);
            this.Minus.TabIndex = 11;
            this.Minus.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // Down
            // 
            this.Down.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Down.ButtonID = Command.ButtonID.DOWN;
            this.Down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Down.Location = new System.Drawing.Point(61, 364);
            this.Down.Margin = new System.Windows.Forms.Padding(2);
            this.Down.Name = "Down";
            this.Down.ShortcutKey = System.Windows.Forms.Keys.None;
            this.Down.Size = new System.Drawing.Size(55, 60);
            this.Down.TabIndex = 3;
            this.Down.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // Right
            // 
            this.Right.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Right.ButtonID = Command.ButtonID.RIGHT;
            this.Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Right.Location = new System.Drawing.Point(120, 305);
            this.Right.Margin = new System.Windows.Forms.Padding(2);
            this.Right.Name = "Right";
            this.Right.ShortcutKey = System.Windows.Forms.Keys.None;
            this.Right.Size = new System.Drawing.Size(55, 55);
            this.Right.TabIndex = 1;
            this.Right.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // Left
            // 
            this.Left.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Left.ButtonID = Command.ButtonID.LEFT;
            this.Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Left.Location = new System.Drawing.Point(2, 305);
            this.Left.Margin = new System.Windows.Forms.Padding(2);
            this.Left.Name = "Left";
            this.Left.ShortcutKey = System.Windows.Forms.Keys.None;
            this.Left.Size = new System.Drawing.Size(55, 55);
            this.Left.TabIndex = 2;
            this.Left.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // Up
            // 
            this.Up.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Up.ButtonID = Command.ButtonID.UP;
            this.Up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Up.Location = new System.Drawing.Point(61, 246);
            this.Up.Margin = new System.Windows.Forms.Padding(2);
            this.Up.Name = "Up";
            this.Up.ShortcutKey = System.Windows.Forms.Keys.None;
            this.Up.Size = new System.Drawing.Size(55, 55);
            this.Up.TabIndex = 0;
            this.Up.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // R
            // 
            this.R.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.R.ButtonID = Command.ButtonID.R;
            this.R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.R.Location = new System.Drawing.Point(434, 2);
            this.R.Margin = new System.Windows.Forms.Padding(2);
            this.R.Name = "R";
            this.R.ShortcutKey = System.Windows.Forms.Keys.None;
            this.R.Size = new System.Drawing.Size(60, 55);
            this.R.TabIndex = 5;
            this.R.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // ZR
            // 
            this.ZR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ZR.ButtonID = Command.ButtonID.ZR;
            this.ZR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZR.Location = new System.Drawing.Point(375, 2);
            this.ZR.Margin = new System.Windows.Forms.Padding(2);
            this.ZR.Name = "ZR";
            this.ZR.ShortcutKey = System.Windows.Forms.Keys.None;
            this.ZR.Size = new System.Drawing.Size(55, 55);
            this.ZR.TabIndex = 4;
            this.ZR.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // Capture
            // 
            this.Capture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Capture.ButtonID = Command.ButtonID.CAPTURE;
            this.Capture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Capture.Location = new System.Drawing.Point(179, 364);
            this.Capture.Margin = new System.Windows.Forms.Padding(2);
            this.Capture.Name = "Capture";
            this.Capture.ShortcutKey = System.Windows.Forms.Keys.None;
            this.Capture.Size = new System.Drawing.Size(55, 60);
            this.Capture.TabIndex = 9;
            this.Capture.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // Home
            // 
            this.Home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Home.ButtonID = Command.ButtonID.HOME;
            this.Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home.Location = new System.Drawing.Point(257, 364);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.ShortcutKey = System.Windows.Forms.Keys.None;
            this.Home.Size = new System.Drawing.Size(55, 60);
            this.Home.TabIndex = 8;
            this.Home.StateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            // 
            // LStickStateSelector
            // 
            this.tableLayoutPanel.SetColumnSpan(this.LStickStateSelector, 3);
            this.LStickStateSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LStickStateSelector.Location = new System.Drawing.Point(3, 62);
            this.LStickStateSelector.Name = "LStickStateSelector";
            this.tableLayoutPanel.SetRowSpan(this.LStickStateSelector, 3);
            this.LStickStateSelector.Size = new System.Drawing.Size(171, 171);
            this.LStickStateSelector.StickID = Command.StickID.LSTICK;
            this.LStickStateSelector.TabIndex = 18;
            this.LStickStateSelector.StickClickStateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            this.LStickStateSelector.StickTiltChanged += new System.EventHandler<NSAutomationWin.StickStateChangedEventArgs>(this.OnAnyStickTiltChanged);
            // 
            // RStickStateSelector
            // 
            this.tableLayoutPanel.SetColumnSpan(this.RStickStateSelector, 3);
            this.RStickStateSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RStickStateSelector.Location = new System.Drawing.Point(317, 247);
            this.RStickStateSelector.Name = "RStickStateSelector";
            this.tableLayoutPanel.SetRowSpan(this.RStickStateSelector, 3);
            this.RStickStateSelector.Size = new System.Drawing.Size(176, 176);
            this.RStickStateSelector.StickID = Command.StickID.RSTICK;
            this.RStickStateSelector.TabIndex = 19;
            this.RStickStateSelector.StickClickStateChanged += new System.EventHandler<NSAutomationWin.ButtonStateChangedEventArgs>(this.OnAnyButtonStateChanged);
            this.RStickStateSelector.StickTiltChanged += new System.EventHandler<NSAutomationWin.StickStateChangedEventArgs>(this.OnAnyStickTiltChanged);
            // 
            // JCPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JCPanel";
            this.Size = new System.Drawing.Size(496, 426);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private ButtonStateSelector Up;
        private ButtonStateSelector Down;
        private ButtonStateSelector Left;
        private ButtonStateSelector ZR;
        private ButtonStateSelector R;
        private ButtonStateSelector ZL;
        private ButtonStateSelector L;
        private ButtonStateSelector Home;
        private ButtonStateSelector Capture;
        private ButtonStateSelector Plus;
        private ButtonStateSelector Minus;
        private ButtonStateSelector X;
        private ButtonStateSelector Y;
        private ButtonStateSelector A;
        private ButtonStateSelector B;
        private ButtonStateSelector Right;
        private StickStateSelector LStickStateSelector;
        private StickStateSelector RStickStateSelector;
    }
}
