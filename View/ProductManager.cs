﻿namespace View
{
    public partial class ProductManager : UserControl
    {
        public ProductManager()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
