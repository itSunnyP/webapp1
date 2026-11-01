namespace WinFormsApp1
{
    partial class FormDrink
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
            lblDrinks = new Label();
            lstDrinks = new ListBox();
            grpTemp = new GroupBox();
            rdoHot = new RadioButton();
            rdoIced = new RadioButton();
            rdoFrappe = new RadioButton();
            grpSize = new GroupBox();
            rdoSizeS = new RadioButton();
            rdoSizeM = new RadioButton();
            rdoSizeL = new RadioButton();
            grpTopping = new GroupBox();
            chkPearl = new CheckBox();
            chkWhip = new CheckBox();
            chkShot = new CheckBox();
            lblSweet = new Label();
            trkSweet = new TrackBar();
            lblQty = new Label();
            numQty = new NumericUpDown();
            lblLineTotal = new Label();
            btnAdd = new Button();
            lblCart = new Label();
            btnBack = new Button();
            btnNext = new Button();
            pnlHeader.SuspendLayout();
            grpTemp.SuspendLayout();
            grpSize.SuspendLayout();
            grpTopping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkSweet).BeginInit();
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
            lblHeader.Text = "เลือกเครื่องดื่ม";
            lblHeader.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(24, 8);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(620, 36);
            lblHeader.TabIndex = 1;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Text = "ขั้นตอนที่ 2 จาก 5";
            lblHeaderSub.Font = new Font("Leelawadee UI", 9.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(215, 204, 200);
            lblHeaderSub.Location = new Point(24, 44);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(620, 22);
            lblHeaderSub.TabIndex = 2;
            // 
            // lblDrinks
            // 
            lblDrinks.Text = "เมนูเครื่องดื่ม";
            lblDrinks.Font = new Font("Leelawadee UI", 11F, FontStyle.Bold);
            lblDrinks.Location = new Point(24, 84);
            lblDrinks.Name = "lblDrinks";
            lblDrinks.Size = new Size(250, 28);
            lblDrinks.TabIndex = 3;
            // 
            // lstDrinks
            // 
            lstDrinks.Location = new Point(24, 114);
            lstDrinks.Name = "lstDrinks";
            lstDrinks.Size = new Size(250, 300);
            lstDrinks.TabIndex = 4;
            lstDrinks.SelectedIndexChanged += Option_Changed;
            // 
            // grpTemp
            // 
            grpTemp.Text = "รูปแบบ";
            grpTemp.Location = new Point(290, 84);
            grpTemp.Name = "grpTemp";
            grpTemp.Size = new Size(546, 72);
            grpTemp.TabIndex = 5;
            grpTemp.Controls.Add(rdoHot);
            grpTemp.Controls.Add(rdoIced);
            grpTemp.Controls.Add(rdoFrappe);
            // 
            // rdoHot
            // 
            rdoHot.Text = "ร้อน";
            rdoHot.Checked = true;
            rdoHot.Location = new Point(16, 30);
            rdoHot.Name = "rdoHot";
            rdoHot.Size = new Size(140, 30);
            rdoHot.TabIndex = 6;
            rdoHot.CheckedChanged += Option_Changed;
            // 
            // rdoIced
            // 
            rdoIced.Text = "เย็น +10";
            rdoIced.Location = new Point(170, 30);
            rdoIced.Name = "rdoIced";
            rdoIced.Size = new Size(140, 30);
            rdoIced.TabIndex = 7;
            rdoIced.CheckedChanged += Option_Changed;
            // 
            // rdoFrappe
            // 
            rdoFrappe.Text = "ปั่น +20";
            rdoFrappe.Location = new Point(330, 30);
            rdoFrappe.Name = "rdoFrappe";
            rdoFrappe.Size = new Size(140, 30);
            rdoFrappe.TabIndex = 8;
            rdoFrappe.CheckedChanged += Option_Changed;
            // 
            // grpSize
            // 
            grpSize.Text = "ขนาด";
            grpSize.Location = new Point(290, 162);
            grpSize.Name = "grpSize";
            grpSize.Size = new Size(546, 72);
            grpSize.TabIndex = 9;
            grpSize.Controls.Add(rdoSizeS);
            grpSize.Controls.Add(rdoSizeM);
            grpSize.Controls.Add(rdoSizeL);
            // 
            // rdoSizeS
            // 
            rdoSizeS.Text = "S";
            rdoSizeS.Checked = true;
            rdoSizeS.Location = new Point(16, 30);
            rdoSizeS.Name = "rdoSizeS";
            rdoSizeS.Size = new Size(140, 30);
            rdoSizeS.TabIndex = 10;
            rdoSizeS.CheckedChanged += Option_Changed;
            // 
            // rdoSizeM
            // 
            rdoSizeM.Text = "M +10";
            rdoSizeM.Location = new Point(170, 30);
            rdoSizeM.Name = "rdoSizeM";
            rdoSizeM.Size = new Size(140, 30);
            rdoSizeM.TabIndex = 11;
            rdoSizeM.CheckedChanged += Option_Changed;
            // 
            // rdoSizeL
            // 
            rdoSizeL.Text = "L +20";
            rdoSizeL.Location = new Point(330, 30);
            rdoSizeL.Name = "rdoSizeL";
            rdoSizeL.Size = new Size(140, 30);
            rdoSizeL.TabIndex = 12;
            rdoSizeL.CheckedChanged += Option_Changed;
            // 
            // grpTopping
            // 
            grpTopping.Text = "ท็อปปิง";
            grpTopping.Location = new Point(290, 240);
            grpTopping.Name = "grpTopping";
            grpTopping.Size = new Size(546, 72);
            grpTopping.TabIndex = 13;
            grpTopping.Controls.Add(chkPearl);
            grpTopping.Controls.Add(chkWhip);
            grpTopping.Controls.Add(chkShot);
            // 
            // chkPearl
            // 
            chkPearl.Text = "ไข่มุก +10";
            chkPearl.Location = new Point(16, 30);
            chkPearl.Name = "chkPearl";
            chkPearl.Size = new Size(140, 30);
            chkPearl.TabIndex = 14;
            chkPearl.CheckedChanged += Option_Changed;
            // 
            // chkWhip
            // 
            chkWhip.Text = "วิปครีม +10";
            chkWhip.Location = new Point(170, 30);
            chkWhip.Name = "chkWhip";
            chkWhip.Size = new Size(140, 30);
            chkWhip.TabIndex = 15;
            chkWhip.CheckedChanged += Option_Changed;
            // 
            // chkShot
            // 
            chkShot.Text = "ช็อตกาแฟ +15";
            chkShot.Location = new Point(330, 30);
            chkShot.Name = "chkShot";
            chkShot.Size = new Size(170, 30);
            chkShot.TabIndex = 16;
            chkShot.CheckedChanged += Option_Changed;
            // 
            // lblSweet
            // 
            lblSweet.Text = "ความหวาน 50%";
            lblSweet.Location = new Point(290, 318);
            lblSweet.Name = "lblSweet";
            lblSweet.Size = new Size(300, 28);
            lblSweet.TabIndex = 17;
            // 
            // trkSweet
            // 
            trkSweet.Maximum = 4;
            trkSweet.LargeChange = 1;
            trkSweet.Value = 2;
            trkSweet.Location = new Point(290, 346);
            trkSweet.Name = "trkSweet";
            trkSweet.Size = new Size(300, 45);
            trkSweet.TabIndex = 18;
            trkSweet.Scroll += Option_Changed;
            // 
            // lblQty
            // 
            lblQty.Text = "จำนวนแก้ว";
            lblQty.Location = new Point(620, 318);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(120, 28);
            lblQty.TabIndex = 19;
            // 
            // numQty
            // 
            numQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQty.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQty.Location = new Point(620, 350);
            numQty.Name = "numQty";
            numQty.Size = new Size(100, 32);
            numQty.TabIndex = 20;
            numQty.ValueChanged += Option_Changed;
            // 
            // lblLineTotal
            // 
            lblLineTotal.Text = "รวม 0.00 บาท";
            lblLineTotal.Font = new Font("Leelawadee UI", 14F, FontStyle.Bold);
            lblLineTotal.ForeColor = Color.FromArgb(141, 90, 50);
            lblLineTotal.Location = new Point(24, 426);
            lblLineTotal.Name = "lblLineTotal";
            lblLineTotal.Size = new Size(400, 40);
            lblLineTotal.TabIndex = 21;
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
            btnAdd.Location = new Point(640, 426);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(196, 46);
            btnAdd.TabIndex = 22;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblCart
            // 
            lblCart.Text = "";
            lblCart.ForeColor = Color.FromArgb(97, 97, 97);
            lblCart.Location = new Point(24, 476);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(600, 28);
            lblCart.TabIndex = 23;
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
            btnBack.TabIndex = 24;
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
            btnNext.TabIndex = 25;
            btnNext.Click += btnNext_Click;
            // 
            // FormDrink
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(250, 245, 238);
            ClientSize = new Size(860, 600);
            Controls.Add(pnlHeader);
            Controls.Add(lblDrinks);
            Controls.Add(lstDrinks);
            Controls.Add(grpTemp);
            Controls.Add(grpSize);
            Controls.Add(grpTopping);
            Controls.Add(lblSweet);
            Controls.Add(trkSweet);
            Controls.Add(lblQty);
            Controls.Add(numQty);
            Controls.Add(lblLineTotal);
            Controls.Add(btnAdd);
            Controls.Add(lblCart);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Font = new Font("Leelawadee UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDrink";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "เลือกเครื่องดื่ม";
            Load += FormDrink_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpTemp.ResumeLayout(false);
            grpTemp.PerformLayout();
            grpSize.ResumeLayout(false);
            grpSize.PerformLayout();
            grpTopping.ResumeLayout(false);
            grpTopping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkSweet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Label lblHeaderSub;
        private Label lblDrinks;
        private ListBox lstDrinks;
        private GroupBox grpTemp;
        private RadioButton rdoHot;
        private RadioButton rdoIced;
        private RadioButton rdoFrappe;
        private GroupBox grpSize;
        private RadioButton rdoSizeS;
        private RadioButton rdoSizeM;
        private RadioButton rdoSizeL;
        private GroupBox grpTopping;
        private CheckBox chkPearl;
        private CheckBox chkWhip;
        private CheckBox chkShot;
        private Label lblSweet;
        private TrackBar trkSweet;
        private Label lblQty;
        private NumericUpDown numQty;
        private Label lblLineTotal;
        private Button btnAdd;
        private Label lblCart;
        private Button btnBack;
        private Button btnNext;
    }
}
