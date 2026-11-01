namespace WinFormsApp1
{
    partial class FormBakery
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
            lblCategory = new Label();
            cboCategory = new ComboBox();
            clbItems = new CheckedListBox();
            lblQty = new Label();
            numQty = new NumericUpDown();
            chkWarm = new CheckBox();
            btnAdd = new Button();
            lblCart = new Label();
            btnBack = new Button();
            btnNext = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
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
            lblHeader.Text = "เลือกเบเกอรี่";
            lblHeader.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(24, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(620, 36);
            lblHeader.TabIndex = 1;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Text = "ขั้นตอนที่ 3 จาก 5 (ข้ามได้ถ้าไม่ต้องการ)";
            lblHeaderSub.Font = new Font("Leelawadee UI", 9.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(215, 204, 200);
            lblHeaderSub.Location = new Point(24, 44);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(620, 22);
            lblHeaderSub.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.Text = "หมวดหมู่";
            lblCategory.Location = new Point(24, 88);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 30);
            lblCategory.TabIndex = 3;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(130, 86);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(250, 32);
            cboCategory.TabIndex = 4;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // clbItems
            // 
            clbItems.CheckOnClick = true;
            clbItems.Location = new Point(24, 130);
            clbItems.Name = "clbItems";
            clbItems.Size = new Size(500, 330);
            clbItems.TabIndex = 5;
            // 
            // lblQty
            // 
            lblQty.Text = "จำนวนชิ้นละรายการ";
            lblQty.Location = new Point(548, 130);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(200, 28);
            lblQty.TabIndex = 6;
            // 
            // numQty
            // 
            numQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQty.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQty.Location = new Point(548, 160);
            numQty.Name = "numQty";
            numQty.Size = new Size(100, 32);
            numQty.TabIndex = 7;
            // 
            // chkWarm
            // 
            chkWarm.Text = "อุ่นร้อนก่อนเสิร์ฟ";
            chkWarm.Location = new Point(548, 206);
            chkWarm.Name = "chkWarm";
            chkWarm.Size = new Size(200, 30);
            chkWarm.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Text = "เพิ่มลงตะกร้า";
            btnAdd.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            btnAdd.BackColor = Color.FromArgb(46, 125, 50);
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Location = new Point(548, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(288, 46);
            btnAdd.TabIndex = 9;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblCart
            // 
            lblCart.Text = "";
            lblCart.ForeColor = Color.FromArgb(97, 97, 97);
            lblCart.Location = new Point(548, 316);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(288, 60);
            lblCart.TabIndex = 10;
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
            btnBack.TabIndex = 11;
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
            btnNext.TabIndex = 12;
            btnNext.Click += btnNext_Click;
            // 
            // FormBakery
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 245, 238);
            ClientSize = new Size(860, 600);
            Controls.Add(pnlHeader);
            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(clbItems);
            Controls.Add(lblQty);
            Controls.Add(numQty);
            Controls.Add(chkWarm);
            Controls.Add(btnAdd);
            Controls.Add(lblCart);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Font = new Font("Leelawadee UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBakery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "เลือกเบเกอรี่";
            Load += FormBakery_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblHeaderSub;
        private Label lblCategory;
        private ComboBox cboCategory;
        private CheckedListBox clbItems;
        private Label lblQty;
        private NumericUpDown numQty;
        private CheckBox chkWarm;
        private Button btnAdd;
        private Label lblCart;
        private Button btnBack;
        private Button btnNext;
    }
}
