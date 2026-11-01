namespace WinFormsApp1
{
    partial class FormLogin
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
            pnlHeader = new Panel();
            lblHeader = new Label();
            lblHeaderSub = new Label();
            pnlCard = new Panel();
            lblUser = new Label();
            txtUser = new TextBox();
            lblPass = new Label();
            txtPass = new TextBox();
            chkShowPass = new CheckBox();
            lblError = new Label();
            btnLogin = new Button();
            lblHint = new Label();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            pnlCard.SuspendLayout();
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
            // 
            // lblHeader
            // 
            lblHeader.Text = "เข้าสู่ระบบ";
            lblHeader.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(24, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(620, 36);
            lblHeader.TabIndex = 1;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Text = "สำหรับพนักงานร้าน";
            lblHeaderSub.Font = new Font("Leelawadee UI", 9.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(215, 204, 200);
            lblHeaderSub.Location = new Point(24, 44);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(620, 22);
            lblHeaderSub.TabIndex = 2;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Location = new Point(230, 100);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(400, 410);
            pnlCard.TabIndex = 3;
            pnlCard.Controls.Add(lblUser);
            pnlCard.Controls.Add(txtUser);
            pnlCard.Controls.Add(lblPass);
            pnlCard.Controls.Add(txtPass);
            pnlCard.Controls.Add(chkShowPass);
            pnlCard.Controls.Add(lblError);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(lblHint);
            // 
            // lblUser
            // 
            lblUser.Text = "ชื่อผู้ใช้";
            lblUser.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            lblUser.Location = new Point(40, 24);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(320, 28);
            lblUser.TabIndex = 4;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(40, 54);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(320, 32);
            txtUser.TabIndex = 5;
            // 
            // lblPass
            // 
            lblPass.Text = "รหัสผ่าน";
            lblPass.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            lblPass.Location = new Point(40, 102);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(320, 28);
            lblPass.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.PasswordChar = '*';
            txtPass.Location = new Point(40, 132);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(320, 32);
            txtPass.TabIndex = 7;
            // 
            // chkShowPass
            // 
            chkShowPass.Text = "แสดงรหัสผ่าน";
            chkShowPass.Location = new Point(40, 174);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(320, 30);
            chkShowPass.TabIndex = 8;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // lblError
            // 
            lblError.Text = "";
            lblError.ForeColor = Color.FromArgb(198, 40, 40);
            lblError.Location = new Point(40, 212);
            lblError.Name = "lblError";
            lblError.Size = new Size(320, 28);
            lblError.TabIndex = 9;
            // 
            // btnLogin
            // 
            btnLogin.Text = "เข้าสู่ระบบ";
            btnLogin.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnLogin.BackColor = Color.FromArgb(78, 52, 46);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Location = new Point(40, 250);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(320, 48);
            btnLogin.TabIndex = 10;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblHint
            // 
            lblHint.Text = "บัญชีทดสอบ  ชื่อผู้ใช้: admin  รหัสผ่าน: 1234";
            lblHint.Font = new Font("Leelawadee UI", 9.5F);
            lblHint.ForeColor = Color.FromArgb(97, 97, 97);
            lblHint.Location = new Point(40, 316);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(320, 60);
            lblHint.TabIndex = 11;
            // 
            // btnBack
            // 
            btnBack.Text = "ย้อนกลับ";
            btnBack.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(215, 204, 200);
            btnBack.ForeColor = Color.FromArgb(78, 52, 46);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Location = new Point(24, 536);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 44);
            btnBack.TabIndex = 12;
            btnBack.Click += btnBack_Click;
            // 
            // FormLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 245, 238);
            ClientSize = new Size(860, 600);
            Controls.Add(pnlHeader);
            Controls.Add(pnlCard);
            Controls.Add(btnBack);
            Font = new Font("Leelawadee UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "เข้าสู่ระบบ";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblHeaderSub;
        private Panel pnlCard;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblPass;
        private TextBox txtPass;
        private CheckBox chkShowPass;
        private Label lblError;
        private Button btnLogin;
        private Label lblHint;
        private Button btnBack;
    }
}
