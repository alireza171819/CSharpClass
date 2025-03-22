using ApplicationService.Dtos.Customer;
using ApplicationService.Dtos.Product;
using ApplicationService.Services.Implementation;
using ApplicationService.Services.Interface;

namespace View
{
    public partial class CustomerManager : UserControl
    {
        #region Filds

        private readonly ICustomerService _customerService;
        private int _customerId;
        private int _rowIndex;

        #endregion

        #region Ctor

        public CustomerManager(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }
        #endregion

        #region Methods

        private CustomerCreate GetParametrs()
        {
            CustomerCreate customerCreate = new();
            if (!string.IsNullOrEmpty(txtFirstName.Text))
            {
                customerCreate.FirstName = txtFirstName.Text;
            }
            else
            {
                MessageBox.Show("plz insert first name .");
                txtFirstName.Focus();
                return null;
            }

            if (!string.IsNullOrEmpty(txtLastName.Text))
            {
                customerCreate.LastName = txtLastName.Text;
            }
            else
            {
                MessageBox.Show("plz insert last name .");
                txtLastName.Focus();
                return null;
            }

            if (!string.IsNullOrEmpty(txtDateOfBirth.Text))
            {
                int year = Convert.ToInt32(txtDateOfBirth.Text.Substring(0, 4));
                int month = Convert.ToInt32(txtDateOfBirth.Text.Substring(5, 2));
                int day = Convert.ToInt32(txtDateOfBirth.Text.Substring(8, 2));
                var dateOfBirth = new DateTime(year, month, day);
                customerCreate.DateOfBirth = dateOfBirth;
            }
            else
            {
                MessageBox.Show("plz insert date of birth .");
                txtDateOfBirth.Focus();
                return null;
            }
            return customerCreate;
        }

        private void Clear()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
            RefreshDgv();
            txtFirstName.Focus();
        }

        public string ThreeDigitSeparator(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                try
                {
                    return Convert.ToInt32(input.Replace(",", "")).ToString("#,#");
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return "0";
        }

        private void DigitFilter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void RefreshDgv()
        {
            dgvCustomers.Rows.Clear();
            var productsInfo = _customerService.GetCustomreList();
            foreach (var item in productsInfo)
            {
                dgvCustomers.Rows.Add(item.Id, item.FullName, item.DateOfBirth.Date);
            }
        }

        private void Create()
        {

        }

        private void Update()
        {

        }

        private void Delete()
        {

        }

        #endregion

        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDgv();
        }


        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            _rowIndex = dgvCustomers.CurrentRow.Index;
            _customerId = (int)dgvCustomers.Rows[_rowIndex].Cells["Id"].Value;
        }
    }
}
