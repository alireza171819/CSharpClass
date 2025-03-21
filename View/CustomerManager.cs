namespace View
{
    public partial class CustomerManager : UserControl
    {
        public CustomerManager()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
