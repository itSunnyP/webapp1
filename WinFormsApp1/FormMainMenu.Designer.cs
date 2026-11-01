namespace WinFormsApp1
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            lblHeader = new Label();
            lblHeaderSub = new Label();
            lblClock = new Label();
            lblWelcome = new Label();
            btnNewOrder = new Button();
            btnHistory = new Button();
            btnReport = new Button();
            btnLogout = new Button();
            tmrClock = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(860, 72);
            pnlHeader.TabIndex = 0;
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(lblHeaderSub);
            pnlHeader.Controls.Add(lblClock);
            // 
            // lblHeader
            // 
            lblHeader.Text = "เมนูหลัก";
            lblHeader.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(24, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(620, 36);
            lblHeader.TabIndex = 1;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Text = "เลือกรายการที่ต้องการ";
            lblHeaderSub.Font = new Font("Leelawadee UI", 9.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(215, 204, 200);
            lblHeaderSub.Location = new Point(24, 44);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(620, 22);
            lblHeaderSub.TabIndex = 2;
            // 
            // lblClock
            // 
            lblClock.Text = "";
            lblClock.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            lblClock.ForeColor = Color.White;
            lblClock.TextAlign = ContentAlignment.MiddleRight;
            lblClock.Location = new Point(620, 20);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(216, 30);
            lblClock.TabIndex = 3;
            // 
            // lblWelcome
            // 
            lblWelcome.Text = "ยินดีต้อนรับ";
            lblWelcome.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            lblWelcome.Location = new Point(40, 92);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(780, 32);
            lblWelcome.TabIndex = 4;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Text = "รับออเดอร์ใหม่";
            btnNewOrder.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnNewOrder.BackColor = Color.FromArgb(78, 52, 46);
            btnNewOrder.ForeColor = Color.White;
            btnNewOrder.FlatStyle = FlatStyle.Flat;
            btnNewOrder.Cursor = Cursors.Hand;
            btnNewOrder.FlatAppearance.BorderSize = 0;
            btnNewOrder.Location = new Point(40, 136);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(380, 180);
            btnNewOrder.TabIndex = 5;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // btnHistory
            // 
            btnHistory.Text = "ประวัติการสั่งซื้อ";
            btnHistory.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnHistory.BackColor = Color.FromArgb(78, 52, 46);
            btnHistory.ForeColor = Color.White;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.Location = new Point(440, 136);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(380, 180);
            btnHistory.TabIndex = 6;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnReport
            // 
            btnReport.Text = "รายงานยอดขาย";
            btnReport.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnReport.BackColor = Color.FromArgb(78, 52, 46);
            btnReport.ForeColor = Color.White;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Cursor = Cursors.Hand;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.Location = new Point(40, 336);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(380, 180);
            btnReport.TabIndex = 7;
            btnReport.Click += btnReport_Click;
            // 
            // btnLogout
            // 
            btnLogout.Text = "ออกจากระบบ";
            btnLogout.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnLogout.BackColor = Color.FromArgb(215, 204, 200);
            btnLogout.ForeColor = Color.FromArgb(78, 52, 46);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Location = new Point(440, 336);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(380, 180);
            btnLogout.TabIndex = 8;
            btnLogout.Click += btnLogout_Click;
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 245, 238);
            ClientSize = new Size(860, 600);
            Controls.Add(pnlHeader);
            Controls.Add(lblWelcome);
            Controls.Add(btnNewOrder);
            Controls.Add(btnHistory);
            Controls.Add(btnReport);
            Controls.Add(btnLogout);
            Font = new Font("Leelawadee UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "เมนูหลัก";
            Load += FormMainMenu_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblHeaderSub;
        private Label lblClock;
        private Label lblWelcome;
        private Button btnNewOrder;
        private Button btnHistory;
        private Button btnReport;
        private Button btnLogout;
        private System.Windows.Forms.Timer tmrClock;
    }
}
