using ApplicationService.Dtos.Customer;
using ApplicationService.Services.Interface;

namespace View
{
    public partial class CustomerManager : UserControl
    {
        #region Filds

        private readonly ICustomerService _customerService;
        private int _customerId;
        private int _rowIndex;
        private bool _update;

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

            if (!string.IsNullOrEmpty(txtYear.Text) || !string.IsNullOrEmpty(txtMonth.Text) || !string.IsNullOrEmpty(txtDay.Text))
            {
                int year = Convert.ToInt32(txtYear.Text);
                int month = Convert.ToInt32(txtMonth.Text);
                int day = Convert.ToInt32(txtDay.Text);
                var dateOfBirth = new DateTime(year, month, day);
                customerCreate.DateOfBirth = dateOfBirth;
            }
            else
            {
                MessageBox.Show("plz insert date of birth .");
                txtYear.Focus();
                return null;
            }
            return customerCreate;
        }

        private void Clear()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtYear.Clear();
            txtMonth.Clear();
            txtDay.Clear();
            RefreshDgv();
            txtFirstName.Focus();
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
            var customreList = _customerService.GetCustomreList();
            if (customreList is not null)
            {
                foreach (var item in customreList)
                {
                    dgvCustomers.Rows.Add(item.Id, item.FullName, item.DateOfBirth.ToShortDateString());
                }
            }
        }

        private void Save()
        {
            var customer = GetParametrs();
            if (customer is null)
            {
                return;
            }
            //Update Customer
            if (_update)
            {
                CustomerUpdate customerUpdate = new();
                customerUpdate.Id = _customerId;
                customerUpdate.FirstName = customer.FirstName;
                customerUpdate.LastName = customer.LastName;
                customerUpdate.DateOfBirth = customer.DateOfBirth;
                var result = _customerService.UpdateCustomer(customerUpdate);
                switch (result)
                {
                    case UpdateResult.Success:
                        MessageBox.Show("Success", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        break;
                    case UpdateResult.Error:
                        MessageBox.Show("Erorr", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case UpdateResult.NullReference:
                        MessageBox.Show("Null", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case UpdateResult.NotFound:
                        MessageBox.Show("Null", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                _update = false;
                btnUpdate.Enabled = true;
            }
            //Create Customer
            else
            {
                var result = _customerService.CreateCustomer(customer);
                switch (result)
                {
                    case CreateResult.Success:
                        MessageBox.Show("Success", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        break;
                    case CreateResult.Error:
                        MessageBox.Show("Erorr", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case CreateResult.NullReference:
                        MessageBox.Show("Null", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            Clear();
        }

        private void Update()
        {
            if (_customerId <= 0)
            {
                MessageBox.Show("Pleas select a row !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _update = true;
            var customerInfo = _customerService.GetCustomer(_customerId);
            txtFirstName.Text = customerInfo.FirstName;
            txtLastName.Text = customerInfo.LastName;
            txtYear.Text = customerInfo.DateOfBirth.Date.Year.ToString();
            txtMonth.Text = customerInfo.DateOfBirth.Date.Month.ToString();
            txtDay.Text = customerInfo.DateOfBirth.Date.Day.ToString();
            btnUpdate.Enabled = false;
            txtFirstName.Focus();
        }

        private void Delete()
        {
            if (_customerId <= 0)
            {
                MessageBox.Show("Pleas select a row !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CustomerRemove customerRemove = new();
            customerRemove.Id = _customerId;
            var result = _customerService.RemoveCustomer(customerRemove);
            switch (result)
            {
                case RemoveResult.Success:
                    MessageBox.Show("Success", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case RemoveResult.Error:
                    MessageBox.Show("Erorr", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case RemoveResult.NullReference:
                    MessageBox.Show("Null", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case RemoveResult.NotFound:
                    MessageBox.Show("Null", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
            Clear();
        }

        #endregion

        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.RowCount > 1)
            {
                _rowIndex = dgvCustomers.CurrentRow.Index;
                _customerId = (int)dgvCustomers.Rows[_rowIndex].Cells[0].Value;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitFilter(sender, e);
        }

        private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitFilter(sender, e);
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitFilter(sender, e);
        }

        private void CustomerManager_Load(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion


    }
}
