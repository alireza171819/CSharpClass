namespace View
{
    partial class ProductManager
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label1 = new Label();
            btnRefresh = new Button();
            btnClose = new Button();
            button3 = new Button();
            button2 = new Button();
            dgvPerson = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("IRANYekanXFaNum", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(514, 199);
            txtLastName.MaxLength = 100;
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "توضیحات";
            txtLastName.RightToLeft = RightToLeft.Yes;
            txtLastName.Size = new Size(180, 32);
            txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("IRANYekanXFaNum", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(514, 161);
            txtFirstName.MaxLength = 100;
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "عنوان";
            txtFirstName.RightToLeft = RightToLeft.Yes;
            txtFirstName.Size = new Size(180, 32);
            txtFirstName.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("IRANYekanXFaNum DemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(418, 37);
            label1.Name = "label1";
            label1.Size = new Size(227, 36);
            label1.TabIndex = 15;
            label1.Text = "مدیریت محصولات";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = Properties.Resources.Refresh_light_3x;
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("IRANYekanXFaNum", 9F);
            btnRefresh.Location = new Point(14, 233);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(58, 43);
            btnRefresh.TabIndex = 14;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.Dell_light_3x;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("IRANYekanXFaNum", 9F);
            btnClose.Location = new Point(658, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(58, 43);
            btnClose.TabIndex = 13;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // button3
            // 
            button3.Font = new Font("IRANYekanXFaNum", 9F);
            button3.Location = new Point(430, 105);
            button3.Name = "button3";
            button3.Size = new Size(84, 43);
            button3.TabIndex = 12;
            button3.Text = "ویرایش";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("IRANYekanXFaNum", 9F);
            button2.Location = new Point(520, 105);
            button2.Name = "button2";
            button2.Size = new Size(84, 43);
            button2.TabIndex = 11;
            button2.Text = "حذف";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgvPerson
            // 
            dgvPerson.BackgroundColor = Color.White;
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Location = new Point(14, 275);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.RowHeadersWidth = 51;
            dgvPerson.Size = new Size(680, 319);
            dgvPerson.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("IRANYekanXFaNum", 9F);
            button1.Location = new Point(610, 105);
            button1.Name = "button1";
            button1.Size = new Size(84, 43);
            button1.TabIndex = 9;
            button1.Text = "ذخیره";
            button1.UseVisualStyleBackColor = true;
            // 
            // ProductManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dgvPerson);
            Controls.Add(button1);
            Name = "ProductManager";
            Size = new Size(730, 614);
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label1;
        private Button btnRefresh;
        private Button btnClose;
        private Button button3;
        private Button button2;
        private DataGridView dgvPerson;
        private Button button1;
    }
}
