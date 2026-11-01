namespace WinFormsApp1
{
    partial class FormStart
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            picMember1 = new PictureBox();
            lblName1 = new Label();
            lblId1 = new Label();
            picMember2 = new PictureBox();
            lblName2 = new Label();
            lblId2 = new Label();
            btnExit = new Button();
            btnNext = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMember1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMember2).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(860, 116);
            pnlHeader.TabIndex = 0;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            // 
            // lblTitle
            // 
            lblTitle.Text = "ชื่องาน";
            lblTitle.Font = new Font("Leelawadee UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Location = new Point(20, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(820, 54);
            lblTitle.TabIndex = 1;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Text = "คำอธิบายงาน";
            lblSubtitle.Font = new Font("Leelawadee UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(215, 204, 200);
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitle.Location = new Point(20, 70);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(820, 30);
            lblSubtitle.TabIndex = 2;
            // 
            // picMember1
            // 
            picMember1.BackColor = Color.FromArgb(215, 204, 200);
            picMember1.BorderStyle = BorderStyle.FixedSingle;
            picMember1.SizeMode = PictureBoxSizeMode.Zoom;
            picMember1.Location = new Point(140, 136);
            picMember1.Name = "picMember1";
            picMember1.Size = new Size(200, 240);
            picMember1.TabIndex = 3;
            // 
            // lblName1
            // 
            lblName1.Text = "ชื่อ-นามสกุล";
            lblName1.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            lblName1.TextAlign = ContentAlignment.MiddleCenter;
            lblName1.Location = new Point(40, 386);
            lblName1.Name = "lblName1";
            lblName1.Size = new Size(400, 32);
            lblName1.TabIndex = 4;
            // 
            // lblId1
            // 
            lblId1.Text = "รหัสนิสิต";
            lblId1.TextAlign = ContentAlignment.MiddleCenter;
            lblId1.Location = new Point(40, 420);
            lblId1.Name = "lblId1";
            lblId1.Size = new Size(400, 28);
            lblId1.TabIndex = 5;
            // 
            // picMember2
            // 
            picMember2.BackColor = Color.FromArgb(215, 204, 200);
            picMember2.BorderStyle = BorderStyle.FixedSingle;
            picMember2.SizeMode = PictureBoxSizeMode.Zoom;
            picMember2.Location = new Point(520, 136);
            picMember2.Name = "picMember2";
            picMember2.Size = new Size(200, 240);
            picMember2.TabIndex = 6;
            // 
            // lblName2
            // 
            lblName2.Text = "ชื่อ-นามสกุล";
            lblName2.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            lblName2.TextAlign = ContentAlignment.MiddleCenter;
            lblName2.Location = new Point(420, 386);
            lblName2.Name = "lblName2";
            lblName2.Size = new Size(400, 32);
            lblName2.TabIndex = 7;
            // 
            // lblId2
            // 
            lblId2.Text = "รหัสนิสิต";
            lblId2.TextAlign = ContentAlignment.MiddleCenter;
            lblId2.Location = new Point(420, 420);
            lblId2.Name = "lblId2";
            lblId2.Size = new Size(400, 28);
            lblId2.TabIndex = 8;
            // 
            // btnExit
            // 
            btnExit.Text = "Exit";
            btnExit.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnExit.BackColor = Color.FromArgb(198, 40, 40);
            btnExit.ForeColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Location = new Point(24, 536);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 44);
            btnExit.TabIndex = 9;
            btnExit.Click += btnExit_Click;
            // 
            // btnNext
            // 
            btnNext.Text = "Next";
            btnNext.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnNext.BackColor = Color.FromArgb(78, 52, 46);
            btnNext.ForeColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.Location = new Point(696, 536);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(140, 44);
            btnNext.TabIndex = 10;
            btnNext.Click += btnNext_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 245, 238);
            ClientSize = new Size(860, 600);
            Controls.Add(pnlHeader);
            Controls.Add(picMember1);
            Controls.Add(lblName1);
            Controls.Add(lblId1);
            Controls.Add(picMember2);
            Controls.Add(lblName2);
            Controls.Add(lblId2);
            Controls.Add(btnExit);
            Controls.Add(btnNext);
            Font = new Font("Leelawadee UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "หน้าเริ่มต้น";
            Load += FormStart_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMember1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMember2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private PictureBox picMember1;
        private Label lblName1;
        private Label lblId1;
        private PictureBox picMember2;
        private Label lblName2;
        private Label lblId2;
        private Button btnExit;
        private Button btnNext;
    }
}
