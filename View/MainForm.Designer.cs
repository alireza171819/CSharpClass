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
            panel1 = new Panel();
            btnProductPage = new Button();
            btnPersonPage = new Button();
            pnlMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(243, 243, 243);
            panel1.Controls.Add(btnProductPage);
            panel1.Controls.Add(btnPersonPage);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(730, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 603);
            panel1.TabIndex = 0;
            // 
            // btnProductPage
            // 
            btnProductPage.BackColor = Color.Transparent;
            btnProductPage.Font = new Font("IRANYekanFN", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductPage.Location = new Point(0, 153);
            btnProductPage.Name = "btnProductPage";
            btnProductPage.Size = new Size(180, 32);
            btnProductPage.TabIndex = 2;
            btnProductPage.Text = "محصولات";
            btnProductPage.UseVisualStyleBackColor = false;
            btnProductPage.Click += btnProductPage_Click;
            // 
            // btnPersonPage
            // 
            btnPersonPage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPersonPage.BackColor = Color.Transparent;
            btnPersonPage.Font = new Font("IRANYekanFN", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPersonPage.ForeColor = SystemColors.WindowText;
            btnPersonPage.Location = new Point(0, 115);
            btnPersonPage.Name = "btnPersonPage";
            btnPersonPage.Size = new Size(180, 32);
            btnPersonPage.TabIndex = 1;
            btnPersonPage.Text = "اشخاص";
            btnPersonPage.UseVisualStyleBackColor = false;
            btnPersonPage.Click += btnPersonPage_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(730, 603);
            pnlMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 603);
            Controls.Add(pnlMain);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += this.MainForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPersonPage;
        private Button btnProductPage;
        private Panel pnlMain;
    }
}
