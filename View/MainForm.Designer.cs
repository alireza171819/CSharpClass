namespace View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProductPage = new Button();
            btnPersonPage = new Button();
            pnlMain = new Panel();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnProductPage
            // 
            btnProductPage.BackColor = Color.Transparent;
            btnProductPage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnProductPage.Location = new Point(354, 283);
            btnProductPage.Name = "btnProductPage";
            btnProductPage.Size = new Size(180, 75);
            btnProductPage.TabIndex = 2;
            btnProductPage.Text = "Products";
            btnProductPage.UseVisualStyleBackColor = false;
            btnProductPage.Click += btnProductPage_Click;
            // 
            // btnPersonPage
            // 
            btnPersonPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPersonPage.BackColor = Color.Transparent;
            btnPersonPage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPersonPage.ForeColor = SystemColors.WindowText;
            btnPersonPage.Location = new Point(354, 185);
            btnPersonPage.Name = "btnPersonPage";
            btnPersonPage.Size = new Size(180, 75);
            btnPersonPage.TabIndex = 1;
            btnPersonPage.Text = "Customer";
            btnPersonPage.UseVisualStyleBackColor = false;
            btnPersonPage.Click += btnPersonPage_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(btnProductPage);
            pnlMain.Controls.Add(btnPersonPage);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(910, 603);
            pnlMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 603);
            Controls.Add(pnlMain);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnPersonPage;
        private Button btnProductPage;
        private Panel pnlMain;
    }
}
