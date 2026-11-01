namespace WinFormsApp1
{
    public partial class FormBakery : Form
    {
        public FormBakery()
        {
            InitializeComponent();
        }

        private void FormBakery_Load(object? sender, EventArgs e)
        {
            cboCategory.Items.Add("ทั้งหมด");
            cboCategory.Items.AddRange(AppData.Bakery.Select(item => item.Category).Distinct().ToArray<object>());
            cboCategory.SelectedIndex = 0;
            ShowCartCount();
        }

        private void cboCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            clbItems.Items.Clear();
            foreach (ProductItem item in AppData.Bakery)
            {
                if (cboCategory.SelectedIndex == 0 || item.Category == cboCategory.Text)
                    clbItems.Items.Add(item);
            }
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (clbItems.CheckedItems.Count == 0)
            {
                lblCart.Text = "กรุณาติ๊กเลือกสินค้าอย่างน้อย 1 รายการ";
                return;
            }

            foreach (ProductItem item in clbItems.CheckedItems)
            {
                AppData.Current.AddLine(new OrderLine
                {
                    Name = item.Name,
                    Detail = chkWarm.Checked ? "อุ่นร้อน" : "",
                    UnitPrice = item.Price,
                    Qty = (int)numQty.Value
                });
            }

            foreach (int index in clbItems.CheckedIndices.Cast<int>().ToList())
                clbItems.SetItemChecked(index, false);

            numQty.Value = 1;
            ShowCartCount();
        }

        private void ShowCartCount()
        {
            lblCart.Text = $"ในตะกร้า {AppData.Current.ItemCount} ชิ้น\nยอดรวม {AppData.Current.Subtotal:N2} บาท";
        }

        private void btnNext_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormCart());
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormDrink());
        }
    }
}
