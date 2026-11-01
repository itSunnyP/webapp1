namespace WinFormsApp1
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object? sender, EventArgs e)
        {
            Order order = AppData.Current;
            txtName.Text = order.CustomerName;
            mtbPhone.Text = order.Phone;
            rdoMember.Checked = order.CustomerType == "สมาชิก";
            rdoStudent.Checked = order.CustomerType == "นิสิต";
            rdoGeneral.Checked = order.CustomerType == "ทั่วไป";
            rdoTakeaway.Checked = order.ServiceType == "สั่งกลับบ้าน";
            rdoDineIn.Checked = order.ServiceType == "ทานที่ร้าน";
            numTable.Value = order.TableNo;
            dtpPickup.Value = order.PickupTime == default ? DateTime.Now.AddMinutes(15) : order.PickupTime;
            txtNote.Text = order.Note;
            UpdateServiceFields();
        }

        private void Service_Changed(object? sender, EventArgs e)
        {
            UpdateServiceFields();
        }

        private void UpdateServiceFields()
        {
            numTable.Enabled = rdoDineIn.Checked;
            dtpPickup.Enabled = rdoTakeaway.Checked;
        }

        private void btnNext_Click(object? sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = new(mtbPhone.Text.Where(char.IsDigit).ToArray());

            if (name.Length == 0)
            {
                lblError.Text = "กรุณากรอกชื่อลูกค้า";
                txtName.Focus();
                return;
            }
            if (phone.Length != 0 && phone.Length != 10)
            {
                lblError.Text = "เบอร์โทรศัพท์ต้องมี 10 หลัก หรือเว้นว่างไว้";
                mtbPhone.Focus();
                return;
            }

            SaveToOrder(name, phone);
            Navigator.Go(this, new FormDrink());
        }

        private void SaveToOrder(string name, string phone)
        {
            Order order = AppData.Current;
            order.CustomerName = name;
            order.Phone = phone;
            order.CustomerType = rdoMember.Checked ? "สมาชิก" : rdoStudent.Checked ? "นิสิต" : "ทั่วไป";
            order.ServiceType = rdoDineIn.Checked ? "ทานที่ร้าน" : "สั่งกลับบ้าน";
            order.TableNo = (int)numTable.Value;
            order.PickupTime = dtpPickup.Value;
            order.Note = txtNote.Text.Trim();
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            Navigator.Go(this, new FormMainMenu());
        }
    }
}
