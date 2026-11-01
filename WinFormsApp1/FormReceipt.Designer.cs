namespace WinFormsApp1
{
    partial class FormReceipt
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
            rtbReceipt = new RichTextBox();
            btnNewOrder = new Button();
            btnMainMenu = new Button();
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
            // 
            // lblHeader
            // 
            lblHeader.Text = "ใบเสร็จรับเงิน";
            lblHeader.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(24, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(620, 36);
            lblHeader.TabIndex = 1;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Text = "ชำระเงินเรียบร้อยแล้ว";
            lblHeaderSub.Font = new Font("Leelawadee UI", 9.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(215, 204, 200);
            lblHeaderSub.Location = new Point(24, 44);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(620, 22);
            lblHeaderSub.TabIndex = 2;
            // 
            // rtbReceipt
            // 
            rtbReceipt.BackColor = Color.White;
            rtbReceipt.BorderStyle = BorderStyle.FixedSingle;
            rtbReceipt.ReadOnly = true;
            rtbReceipt.Location = new Point(24, 88);
            rtbReceipt.Name = "rtbReceipt";
            rtbReceipt.Size = new Size(600, 492);
            rtbReceipt.TabIndex = 3;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Text = "รับออเดอร์ใหม่";
            btnNewOrder.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnNewOrder.BackColor = Color.FromArgb(46, 125, 50);
            btnNewOrder.ForeColor = Color.White;
            btnNewOrder.FlatStyle = FlatStyle.Flat;
            btnNewOrder.Cursor = Cursors.Hand;
            btnNewOrder.FlatAppearance.BorderSize = 0;
            btnNewOrder.Location = new Point(640, 88);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(196, 50);
            btnNewOrder.TabIndex = 4;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Text = "กลับเมนูหลัก";
            btnMainMenu.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnMainMenu.BackColor = Color.FromArgb(215, 204, 200);
            btnMainMenu.ForeColor = Color.FromArgb(78, 52, 46);
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Cursor = Cursors.Hand;
            btnMainMenu.FlatAppearance.BorderSize = 0;
            btnMainMenu.Location = new Point(640, 150);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(196, 50);
            btnMainMenu.TabIndex = 5;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // FormReceipt
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 245, 238);
            ClientSize = new Size(860, 600);
            Controls.Add(pnlHeader);
            Controls.Add(rtbReceipt);
            Controls.Add(btnNewOrder);
            Controls.Add(btnMainMenu);
            Font = new Font("Leelawadee UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ใบเสร็จรับเงิน";
            Load += FormReceipt_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblHeaderSub;
        private RichTextBox rtbReceipt;
        private Button btnNewOrder;
        private Button btnMainMenu;
    }
}
