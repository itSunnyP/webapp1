namespace WinFormsApp1
{
    partial class FormPayment
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
            grpSummary = new GroupBox();
            lblSubtotalCap = new Label();
            lblSubtotal = new Label();
            lblMemberCap = new Label();
            lblMember = new Label();
            lblCouponCap = new Label();
            lblCoupon = new Label();
            lblTotalCap = new Label();
            lblTotal = new Label();
            lblCouponInput = new Label();
            txtCoupon = new TextBox();
            btnApplyCoupon = new Button();
            grpMethod = new GroupBox();
            rdoCash = new RadioButton();
            rdoTransfer = new RadioButton();
            rdoCard = new RadioButton();
            pnlCash = new Panel();
            lblReceivedCap = new Label();
            txtReceived = new TextBox();
            lblChange = new Label();
            lblMethodInfo = new Label();
            lblError = new Label();
            btnBack = new Button();
            btnConfirm = new Button();
            pnlHeader.SuspendLayout();
            grpSummary.SuspendLayout();
            grpMethod.SuspendLayout();
            pnlCash.SuspendLayout();
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
            lblHeader.Text = "ชำระเงิน";
            lblHeader.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(24, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(620, 36);
            lblHeader.TabIndex = 1;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Text = "ขั้นตอนที่ 5 จาก 5";
            lblHeaderSub.Font = new Font("Leelawadee UI", 9.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(215, 204, 200);
            lblHeaderSub.Location = new Point(24, 44);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(620, 22);
            lblHeaderSub.TabIndex = 2;
            // 
            // grpSummary
            // 
            grpSummary.Text = "สรุปยอด";
            grpSummary.Location = new Point(24, 84);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(400, 240);
            grpSummary.TabIndex = 3;
            grpSummary.Controls.Add(lblSubtotalCap);
            grpSummary.Controls.Add(lblSubtotal);
            grpSummary.Controls.Add(lblMemberCap);
            grpSummary.Controls.Add(lblMember);
            grpSummary.Controls.Add(lblCouponCap);
            grpSummary.Controls.Add(lblCoupon);
            grpSummary.Controls.Add(lblTotalCap);
            grpSummary.Controls.Add(lblTotal);
            // 
            // lblSubtotalCap
            // 
            lblSubtotalCap.Text = "ยอดรวม";
            lblSubtotalCap.Location = new Point(16, 34);
            lblSubtotalCap.Name = "lblSubtotalCap";
            lblSubtotalCap.Size = new Size(200, 30);
            lblSubtotalCap.TabIndex = 4;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Text = "0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            lblSubtotal.Location = new Point(220, 34);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(164, 30);
            lblSubtotal.TabIndex = 5;
            // 
            // lblMemberCap
            // 
            lblMemberCap.Text = "ส่วนลดประเภทลูกค้า";
            lblMemberCap.Location = new Point(16, 70);
            lblMemberCap.Name = "lblMemberCap";
            lblMemberCap.Size = new Size(200, 30);
            lblMemberCap.TabIndex = 6;
            // 
            // lblMember
            // 
            lblMember.Text = "0.00";
            lblMember.TextAlign = ContentAlignment.MiddleRight;
            lblMember.Location = new Point(220, 70);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(164, 30);
            lblMember.TabIndex = 7;
            // 
            // lblCouponCap
            // 
            lblCouponCap.Text = "ส่วนลดคูปอง";
            lblCouponCap.Location = new Point(16, 106);
            lblCouponCap.Name = "lblCouponCap";
            lblCouponCap.Size = new Size(200, 30);
            lblCouponCap.TabIndex = 8;
            // 
            // lblCoupon
            // 
            lblCoupon.Text = "0.00";
            lblCoupon.TextAlign = ContentAlignment.MiddleRight;
            lblCoupon.Location = new Point(220, 106);
            lblCoupon.Name = "lblCoupon";
            lblCoupon.Size = new Size(164, 30);
            lblCoupon.TabIndex = 9;
            // 
            // lblTotalCap
            // 
            lblTotalCap.Text = "ยอดสุทธิ";
            lblTotalCap.Font = new Font("Leelawadee UI", 14F, FontStyle.Bold);
            lblTotalCap.Location = new Point(16, 160);
            lblTotalCap.Name = "lblTotalCap";
            lblTotalCap.Size = new Size(150, 44);
            lblTotalCap.TabIndex = 10;
            // 
            // lblTotal
            // 
            lblTotal.Text = "0.00";
            lblTotal.Font = new Font("Leelawadee UI", 20F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(141, 90, 50);
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Location = new Point(170, 160);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(214, 44);
            lblTotal.TabIndex = 11;
            // 
            // lblCouponInput
            // 
            lblCouponInput.Text = "คูปอง";
            lblCouponInput.Location = new Point(24, 336);
            lblCouponInput.Name = "lblCouponInput";
            lblCouponInput.Size = new Size(100, 30);
            lblCouponInput.TabIndex = 12;
            // 
            // txtCoupon
            // 
            txtCoupon.PlaceholderText = "กรอกรหัสคูปอง เช่น COFFEE20";
            txtCoupon.Location = new Point(24, 368);
            txtCoupon.Name = "txtCoupon";
            txtCoupon.Size = new Size(260, 32);
            txtCoupon.TabIndex = 13;
            // 
            // btnApplyCoupon
            // 
            btnApplyCoupon.Text = "ใช้คูปอง";
            btnApplyCoupon.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnApplyCoupon.BackColor = Color.FromArgb(215, 204, 200);
            btnApplyCoupon.ForeColor = Color.FromArgb(78, 52, 46);
            btnApplyCoupon.FlatStyle = FlatStyle.Flat;
            btnApplyCoupon.Cursor = Cursors.Hand;
            btnApplyCoupon.FlatAppearance.BorderSize = 0;
            btnApplyCoupon.Location = new Point(294, 364);
            btnApplyCoupon.Name = "btnApplyCoupon";
            btnApplyCoupon.Size = new Size(130, 40);
            btnApplyCoupon.TabIndex = 14;
            btnApplyCoupon.Click += btnApplyCoupon_Click;
            // 
            // grpMethod
            // 
            grpMethod.Text = "วิธีชำระเงิน";
            grpMethod.Location = new Point(440, 84);
            grpMethod.Name = "grpMethod";
            grpMethod.Size = new Size(396, 84);
            grpMethod.TabIndex = 15;
            grpMethod.Controls.Add(rdoCash);
            grpMethod.Controls.Add(rdoTransfer);
            grpMethod.Controls.Add(rdoCard);
            // 
            // rdoCash
            // 
            rdoCash.Text = "เงินสด";
            rdoCash.Checked = true;
            rdoCash.Location = new Point(16, 34);
            rdoCash.Name = "rdoCash";
            rdoCash.Size = new Size(110, 30);
            rdoCash.TabIndex = 16;
            rdoCash.CheckedChanged += Method_Changed;
            // 
            // rdoTransfer
            // 
            rdoTransfer.Text = "โอนเงิน";
            rdoTransfer.Location = new Point(132, 34);
            rdoTransfer.Name = "rdoTransfer";
            rdoTransfer.Size = new Size(120, 30);
            rdoTransfer.TabIndex = 17;
            rdoTransfer.CheckedChanged += Method_Changed;
            // 
            // rdoCard
            // 
            rdoCard.Text = "บัตรเครดิต";
            rdoCard.Location = new Point(258, 34);
            rdoCard.Name = "rdoCard";
            rdoCard.Size = new Size(120, 30);
            rdoCard.TabIndex = 18;
            rdoCard.CheckedChanged += Method_Changed;
            // 
            // pnlCash
            // 
            pnlCash.BackColor = Color.White;
            pnlCash.Location = new Point(440, 180);
            pnlCash.Name = "pnlCash";
            pnlCash.Size = new Size(396, 144);
            pnlCash.TabIndex = 19;
            pnlCash.Controls.Add(lblReceivedCap);
            pnlCash.Controls.Add(txtReceived);
            pnlCash.Controls.Add(lblChange);
            // 
            // lblReceivedCap
            // 
            lblReceivedCap.Text = "รับเงินมา (บาท)";
            lblReceivedCap.Location = new Point(16, 14);
            lblReceivedCap.Name = "lblReceivedCap";
            lblReceivedCap.Size = new Size(200, 28);
            lblReceivedCap.TabIndex = 20;
            // 
            // txtReceived
            // 
            txtReceived.Location = new Point(16, 44);
            txtReceived.Name = "txtReceived";
            txtReceived.Size = new Size(200, 32);
            txtReceived.TabIndex = 21;
            txtReceived.TextChanged += txtReceived_TextChanged;
            // 
            // lblChange
            // 
            lblChange.Text = "เงินทอน 0.00 บาท";
            lblChange.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            lblChange.Location = new Point(16, 90);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(364, 36);
            lblChange.TabIndex = 22;
            // 
            // lblMethodInfo
            // 
            lblMethodInfo.Text = "ยืนยันเมื่อได้รับยอดชำระครบแล้ว";
            lblMethodInfo.ForeColor = Color.FromArgb(97, 97, 97);
            lblMethodInfo.Visible = false;
            lblMethodInfo.Location = new Point(440, 180);
            lblMethodInfo.Name = "lblMethodInfo";
            lblMethodInfo.Size = new Size(396, 60);
            lblMethodInfo.TabIndex = 23;
            // 
            // lblError
            // 
            lblError.Text = "";
            lblError.ForeColor = Color.FromArgb(198, 40, 40);
            lblError.Location = new Point(24, 440);
            lblError.Name = "lblError";
            lblError.Size = new Size(812, 26);
            lblError.TabIndex = 24;
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
            btnBack.TabIndex = 25;
            btnBack.Click += btnBack_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Text = "ยืนยันการชำระเงิน";
            btnConfirm.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnConfirm.BackColor = Color.FromArgb(46, 125, 50);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.Location = new Point(666, 536);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(170, 44);
            btnConfirm.TabIndex = 26;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // FormPayment
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 245, 238);
            ClientSize = new Size(860, 600);
            Controls.Add(pnlHeader);
            Controls.Add(grpSummary);
            Controls.Add(lblCouponInput);
            Controls.Add(txtCoupon);
            Controls.Add(btnApplyCoupon);
            Controls.Add(grpMethod);
            Controls.Add(pnlCash);
            Controls.Add(lblMethodInfo);
            Controls.Add(lblError);
            Controls.Add(btnBack);
            Controls.Add(btnConfirm);
            Font = new Font("Leelawadee UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ชำระเงิน";
            Load += FormPayment_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            grpMethod.ResumeLayout(false);
            grpMethod.PerformLayout();
            pnlCash.ResumeLayout(false);
            pnlCash.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblHeaderSub;
        private GroupBox grpSummary;
        private Label lblSubtotalCap;
        private Label lblSubtotal;
        private Label lblMemberCap;
        private Label lblMember;
        private Label lblCouponCap;
        private Label lblCoupon;
        private Label lblTotalCap;
        private Label lblTotal;
        private Label lblCouponInput;
        private TextBox txtCoupon;
        private Button btnApplyCoupon;
        private GroupBox grpMethod;
        private RadioButton rdoCash;
        private RadioButton rdoTransfer;
        private RadioButton rdoCard;
        private Panel pnlCash;
        private Label lblReceivedCap;
        private TextBox txtReceived;
        private Label lblChange;
        private Label lblMethodInfo;
        private Label lblError;
        private Button btnBack;
        private Button btnConfirm;
    }
}
