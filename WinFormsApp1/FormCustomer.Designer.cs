namespace WinFormsApp1
{
    partial class FormCustomer
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
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            mtbPhone = new MaskedTextBox();
            grpCustomerType = new GroupBox();
            rdoGeneral = new RadioButton();
            rdoMember = new RadioButton();
            rdoStudent = new RadioButton();
            grpService = new GroupBox();
            rdoDineIn = new RadioButton();
            rdoTakeaway = new RadioButton();
            lblTable = new Label();
            numTable = new NumericUpDown();
            lblPickup = new Label();
            dtpPickup = new DateTimePicker();
            lblNote = new Label();
            txtNote = new TextBox();
            lblError = new Label();
            btnBack = new Button();
            btnNext = new Button();
            pnlHeader.SuspendLayout();
            grpCustomerType.SuspendLayout();
            grpService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTable).BeginInit();
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
            lblHeader.Text = "ข้อมูลลูกค้า";
            lblHeader.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(24, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(620, 36);
            lblHeader.TabIndex = 1;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Text = "ขั้นตอนที่ 1 จาก 5";
            lblHeaderSub.Font = new Font("Leelawadee UI", 9.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(215, 204, 200);
            lblHeaderSub.Location = new Point(24, 44);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(620, 22);
            lblHeaderSub.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.Text = "ชื่อลูกค้า *";
            lblName.Location = new Point(24, 92);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 30);
            lblName.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(180, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(320, 32);
            txtName.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.Text = "เบอร์โทรศัพท์";
            lblPhone.Location = new Point(24, 134);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(150, 30);
            lblPhone.TabIndex = 5;
            // 
            // mtbPhone
            // 
            mtbPhone.Mask = "000-000-0000";
            mtbPhone.Location = new Point(180, 132);
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(200, 32);
            mtbPhone.TabIndex = 6;
            // 
            // grpCustomerType
            // 
            grpCustomerType.Text = "ประเภทลูกค้า";
            grpCustomerType.Location = new Point(24, 176);
            grpCustomerType.Name = "grpCustomerType";
            grpCustomerType.Size = new Size(398, 84);
            grpCustomerType.TabIndex = 7;
            grpCustomerType.Controls.Add(rdoGeneral);
            grpCustomerType.Controls.Add(rdoMember);
            grpCustomerType.Controls.Add(rdoStudent);
            // 
            // rdoGeneral
            // 
            rdoGeneral.Text = "ทั่วไป";
            rdoGeneral.Checked = true;
            rdoGeneral.Location = new Point(16, 34);
            rdoGeneral.Name = "rdoGeneral";
            rdoGeneral.Size = new Size(110, 30);
            rdoGeneral.TabIndex = 8;
            // 
            // rdoMember
            // 
            rdoMember.Text = "สมาชิก -10%";
            rdoMember.Location = new Point(130, 34);
            rdoMember.Name = "rdoMember";
            rdoMember.Size = new Size(130, 30);
            rdoMember.TabIndex = 9;
            // 
            // rdoStudent
            // 
            rdoStudent.Text = "นิสิต -5%";
            rdoStudent.Location = new Point(262, 34);
            rdoStudent.Name = "rdoStudent";
            rdoStudent.Size = new Size(125, 30);
            rdoStudent.TabIndex = 10;
            // 
            // grpService
            // 
            grpService.Text = "รูปแบบการรับสินค้า";
            grpService.Location = new Point(438, 176);
            grpService.Name = "grpService";
            grpService.Size = new Size(398, 84);
            grpService.TabIndex = 11;
            grpService.Controls.Add(rdoDineIn);
            grpService.Controls.Add(rdoTakeaway);
            // 
            // rdoDineIn
            // 
            rdoDineIn.Text = "ทานที่ร้าน";
            rdoDineIn.Checked = true;
            rdoDineIn.Location = new Point(16, 34);
            rdoDineIn.Name = "rdoDineIn";
            rdoDineIn.Size = new Size(150, 30);
            rdoDineIn.TabIndex = 12;
            rdoDineIn.CheckedChanged += Service_Changed;
            // 
            // rdoTakeaway
            // 
            rdoTakeaway.Text = "สั่งกลับบ้าน";
            rdoTakeaway.Location = new Point(180, 34);
            rdoTakeaway.Name = "rdoTakeaway";
            rdoTakeaway.Size = new Size(150, 30);
            rdoTakeaway.TabIndex = 13;
            rdoTakeaway.CheckedChanged += Service_Changed;
            // 
            // lblTable
            // 
            lblTable.Text = "หมายเลขโต๊ะ";
            lblTable.Location = new Point(24, 276);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(150, 30);
            lblTable.TabIndex = 14;
            // 
            // numTable
            // 
            numTable.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTable.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numTable.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numTable.Location = new Point(180, 274);
            numTable.Name = "numTable";
            numTable.Size = new Size(90, 32);
            numTable.TabIndex = 15;
            // 
            // lblPickup
            // 
            lblPickup.Text = "เวลารับสินค้า";
            lblPickup.Location = new Point(438, 276);
            lblPickup.Name = "lblPickup";
            lblPickup.Size = new Size(110, 30);
            lblPickup.TabIndex = 16;
            // 
            // dtpPickup
            // 
            dtpPickup.Format = DateTimePickerFormat.Custom;
            dtpPickup.CustomFormat = "HH:mm";
            dtpPickup.ShowUpDown = true;
            dtpPickup.Location = new Point(560, 274);
            dtpPickup.Name = "dtpPickup";
            dtpPickup.Size = new Size(120, 32);
            dtpPickup.TabIndex = 17;
            // 
            // lblNote
            // 
            lblNote.Text = "หมายเหตุ";
            lblNote.Location = new Point(24, 320);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(150, 30);
            lblNote.TabIndex = 18;
            // 
            // txtNote
            // 
            txtNote.Multiline = true;
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Location = new Point(180, 318);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(656, 110);
            txtNote.TabIndex = 19;
            // 
            // lblError
            // 
            lblError.Text = "";
            lblError.ForeColor = Color.FromArgb(198, 40, 40);
            lblError.Location = new Point(180, 440);
            lblError.Name = "lblError";
            lblError.Size = new Size(656, 26);
            lblError.TabIndex = 20;
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
            btnBack.TabIndex = 21;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Text = "ถัดไป";
            btnNext.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnNext.BackColor = Color.FromArgb(78, 52, 46);
            btnNext.ForeColor = Color.White;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.Location = new Point(696, 536);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(140, 44);
            btnNext.TabIndex = 22;
            btnNext.Click += btnNext_Click;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 245, 238);
            ClientSize = new Size(860, 600);
            Controls.Add(pnlHeader);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblPhone);
            Controls.Add(mtbPhone);
            Controls.Add(grpCustomerType);
            Controls.Add(grpService);
            Controls.Add(lblTable);
            Controls.Add(numTable);
            Controls.Add(lblPickup);
            Controls.Add(dtpPickup);
            Controls.Add(lblNote);
            Controls.Add(txtNote);
            Controls.Add(lblError);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Font = new Font("Leelawadee UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ข้อมูลลูกค้า";
            Load += FormCustomer_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpCustomerType.ResumeLayout(false);
            grpCustomerType.PerformLayout();
            grpService.ResumeLayout(false);
            grpService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblHeaderSub;
        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private MaskedTextBox mtbPhone;
        private GroupBox grpCustomerType;
        private RadioButton rdoGeneral;
        private RadioButton rdoMember;
        private RadioButton rdoStudent;
        private GroupBox grpService;
        private RadioButton rdoDineIn;
        private RadioButton rdoTakeaway;
        private Label lblTable;
        private NumericUpDown numTable;
        private Label lblPickup;
        private DateTimePicker dtpPickup;
        private Label lblNote;
        private TextBox txtNote;
        private Label lblError;
        private Button btnBack;
        private Button btnNext;
    }
}
