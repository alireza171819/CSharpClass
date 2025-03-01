namespace View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonPage_Click(object sender, EventArgs e)
        {
            PersonManager personManager = new PersonManager();
            pnlMain.Controls.Add(personManager);
        }

        private void btnProductPage_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();
            pnlMain.Controls.Add(productManager);
        }
    }
}
