using ApplicationService.Services.Interface;

namespace View
{
    public partial class MainForm : Form
    {
        #region Filds

        private readonly CustomerManager customerManager;
        private readonly ProductManager productManager;

        #endregion

        #region Ctor
        public MainForm(IProductService productService, ICustomerService customerService)
        {
            InitializeComponent();
            customerManager = new CustomerManager(customerService);
            productManager = new ProductManager(productService);
        }

        #endregion

        #region Methods

        private void MainForm_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(customerManager);
            pnlMain.Controls.Add(productManager);
            customerManager.Hide();
            productManager.Hide();
        }

        private void btnPersonPage_Click(object sender, EventArgs e)
        {
            customerManager.Show();
            HideButtons();
        }

        private void btnProductPage_Click(object sender, EventArgs e)
        {
            productManager.Show();
            HideButtons();
        }

        #endregion

        #region Privet Methods

        private void HideButtons()
        {
            btnProductPage.SendToBack();
            btnPersonPage.SendToBack();
        }

#endregion
    }
}
