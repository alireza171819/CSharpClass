namespace View
{
    public partial class MainForm : Form
    {
        #region Ctor
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonPage_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            CustomerManager personManager = new CustomerManager();
            pnlMain.Controls.Add(personManager);
            HideButtons();
        }

        private void btnProductPage_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ProductManager productManager = new ProductManager();
            pnlMain.Controls.Add(productManager);
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
