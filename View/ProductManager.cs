using ApplicationService.Dtos.Product;
using ApplicationService.Services.Interface;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace View
{
    public partial class ProductManager : UserControl
    {
        #region Filds

        private readonly IProductService _productService;
        private int _productId;
        private int _rowIndex;

        #endregion

        #region Ctor

        public ProductManager(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        #endregion

        #region Mathods

        private ProductCreate GetParametrs()
        {
            ProductCreate productCreate = new();
            if (!string.IsNullOrEmpty(txtTitel.Text))
            {
                productCreate.Title = txtTitel.Text;
            }
            else
            {
                MessageBox.Show("plz insert product titel .");
                txtTitel.Focus();
                return null;
            }

            if (!string.IsNullOrEmpty(txtDescription.Text))
            {
                productCreate.Description = txtDescription.Text;
            }
            else
            {
                MessageBox.Show("plz insert product description .");
                txtDescription.Focus();
                return null;
            }

            if (!string.IsNullOrEmpty(txtSku.Text))
            {
                productCreate.Sku = Convert.ToInt32(txtSku.Text);
            }
            else
            {
                MessageBox.Show("plz insert product sku .");
                txtSku.Focus();
                return null;
            }

            if (!string.IsNullOrEmpty(txtSku.Text))
            {
                productCreate.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
            }
            else
            {
                MessageBox.Show("plz insert product unit price .");
                txtUnitPrice.Focus();
                return null;
            }
            return productCreate;
        }

        private void Clear()
        {
            txtTitel.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtSku.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            RefreshDgv();
            txtTitel.Focus();
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

        private void Create()
        {
            var product = GetParametrs();
            if (product is null)
            {
                return;
            }
            var result = _productService.CreateProduct(product);
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
            Clear();
        }

        private void Update()
        {
            if (_productId <= 0)
            {
                MessageBox.Show("Pleas select a row !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var productInfo = GetParametrs();
            if (productInfo is null)
            {
                return;
            }
            ProductUpdate productUpdate = new();
            productUpdate.Title = productInfo.Title;
            productUpdate.Description = productInfo.Description;
            productUpdate.Id = _productId;
            productUpdate.Sku = productInfo.Sku;
            productUpdate.UnitPrice = productInfo.UnitPrice;
            var result = _productService.UpdateProduct(productUpdate);
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
            Clear();
        }

        private void Delete()
        {
            if (_productId <= 0)
            {
                MessageBox.Show("Pleas select a row !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ProductRemove productRemove = new();
            productRemove.Id = _productId;
            var result = _productService.RemoveProduct(productRemove);
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

        private void RefreshDgv()
        {
            dgvProducts.Rows.Clear();
            var productsInfo = _productService.GetProductList();
            foreach (var item in productsInfo)
            {
                dgvProducts.Rows.Add(item.Id, item.Title, item.Description, item.Sku, item.UnitPrice);
            }
        }
        #endregion

        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            RefreshDgv();
            txtTitel.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Create();
            txtTitel.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            _rowIndex = dgvProducts.CurrentRow.Index;
            _productId = (int)dgvProducts.Rows[_rowIndex].Cells["Id"].Value;
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            txtUnitPrice.Text = ThreeDigitSeparator(txtUnitPrice.Text);
            txtUnitPrice.SelectionStart = txtUnitPrice.Text.Length;
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitFilter(sender, e);
        }

        #endregion
    }
}
