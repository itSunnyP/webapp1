namespace WinFormsApp1
{
    public partial class FormReceipt : Form
    {
        public FormReceipt()
        {
            InitializeComponent();
        }

        private void FormReceipt_Load(object? sender, EventArgs e)
        {
            rtbReceipt.SelectionTabs = new[] { 150, 460 };
            rtbReceipt.Text = AppData.LastOrder?.BuildReceipt() ?? "";
        }

        private void btnNewOrder_Click(object? sender, EventArgs e)
        {
            AppData.StartNewOrder();
            Navigator.Go(this, new FormCustomer());
        }

        private void btnMainMenu_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormMainMenu());
        }
    }
}
