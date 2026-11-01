namespace WinFormsApp1
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }

        private void FormHistory_Load(object? sender, EventArgs e)
        {
            lvOrders.Columns.Add("เลขที่", 80);
            lvOrders.Columns.Add("วันเวลา", 170);
            lvOrders.Columns.Add("ลูกค้า", 220);
            lvOrders.Columns.Add("รับสินค้า", 120);
            lvOrders.Columns.Add("ชำระโดย", 100);
            lvOrders.Columns.Add("ยอดสุทธิ", 100, HorizontalAlignment.Right);
            ShowOrders();
        }

        private void Filter_Changed(object? sender, EventArgs e)
        {
            ShowOrders();
        }

        private void ShowOrders()
        {
            string keyword = txtSearch.Text.Trim();
            IEnumerable<Order> orders = AppData.Orders.OrderByDescending(order => order.No);

            if (keyword.Length > 0)
                orders = orders.Where(order => order.CustomerName.Contains(keyword, StringComparison.OrdinalIgnoreCase));
            if (chkDate.Checked)
                orders = orders.Where(order => order.Time.Date == dtpDate.Value.Date);

            lvOrders.Items.Clear();
            txtDetail.Clear();
            foreach (Order order in orders)
            {
                var row = new ListViewItem(new[]
                {
                    order.NoText,
                    order.Time.ToString("dd/MM/yyyy HH:mm"),
                    order.CustomerName,
                    order.ServiceType,
                    order.PayMethod,
                    order.Total.ToString("N2")
                });
                row.Tag = order;
                lvOrders.Items.Add(row);
            }
        }

        private void lvOrders_SelectedIndexChanged(object? sender, EventArgs e)
        {
            txtDetail.Text = lvOrders.SelectedItems.Count == 0
                ? ""
                : ((Order)lvOrders.SelectedItems[0].Tag!).BuildReceipt();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var order = (Order)lvOrders.SelectedItems[0].Tag!;
            if (MessageBox.Show($"ต้องการลบออเดอร์เลขที่ {order.NoText} หรือไม่", "ยืนยัน",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                AppData.Orders.Remove(order);
                ShowOrders();
            }
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormMainMenu());
        }
    }
}
