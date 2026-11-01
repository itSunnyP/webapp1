namespace WinFormsApp1
{
    public partial class FormDrink : Form
    {
        public FormDrink()
        {
            InitializeComponent();
        }

        private int Sweetness => trkSweet.Value * 25;

        private void FormDrink_Load(object? sender, EventArgs e)
        {
            lstDrinks.Items.AddRange(AppData.Drinks.ToArray());
            lstDrinks.SelectedIndex = 0;
            ShowCartCount();
        }

        private void Option_Changed(object? sender, EventArgs e)
        {
            lblSweet.Text = $"ความหวาน {Sweetness}%";
            lblLineTotal.Text = $"รวม {CalcUnitPrice() * numQty.Value:N2} บาท";
        }

        private decimal CalcUnitPrice()
        {
            if (lstDrinks.SelectedItem is not ProductItem drink)
                return 0;

            decimal price = drink.Price;
            if (rdoIced.Checked) price += 10;
            if (rdoFrappe.Checked) price += 20;
            if (rdoSizeM.Checked) price += 10;
            if (rdoSizeL.Checked) price += 20;
            if (chkPearl.Checked) price += 10;
            if (chkWhip.Checked) price += 10;
            if (chkShot.Checked) price += 15;
            return price;
        }

        private string BuildDetail()
        {
            var parts = new List<string>
            {
                rdoHot.Checked ? "ร้อน" : rdoIced.Checked ? "เย็น" : "ปั่น",
                rdoSizeS.Checked ? "S" : rdoSizeM.Checked ? "M" : "L",
                $"หวาน {Sweetness}%"
            };
            if (chkPearl.Checked) parts.Add("ไข่มุก");
            if (chkWhip.Checked) parts.Add("วิปครีม");
            if (chkShot.Checked) parts.Add("ช็อตกาแฟ");
            return string.Join(", ", parts);
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (lstDrinks.SelectedItem is not ProductItem drink)
                return;

            AppData.Current.AddLine(new OrderLine
            {
                Name = drink.Name,
                Detail = BuildDetail(),
                UnitPrice = CalcUnitPrice(),
                Qty = (int)numQty.Value
            });
            numQty.Value = 1;
            ShowCartCount();
        }

        private void ShowCartCount()
        {
            lblCart.Text = $"ในตะกร้า {AppData.Current.ItemCount} ชิ้น  ยอดรวม {AppData.Current.Subtotal:N2} บาท";
        }

        private void btnNext_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormBakery());
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormCustomer());
        }
    }
}
