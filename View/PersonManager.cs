namespace View
{
    public partial class PersonManager : UserControl
    {
        public PersonManager()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
