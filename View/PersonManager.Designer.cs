namespace View
{
    partial class PersonManager
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
            button1 = new Button();
            dgvPerson = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            btnClose = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("IRANYekanXFaNum", 9F);
            button1.Location = new Point(621, 87);
            button1.Name = "button1";
            button1.Size = new Size(84, 43);
            button1.TabIndex = 0;
            button1.Text = "ذخیره";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvPerson
            // 
            dgvPerson.BackgroundColor = Color.White;
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Location = new Point(25, 257);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.RowHeadersWidth = 51;
            dgvPerson.Size = new Size(680, 319);
            dgvPerson.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("IRANYekanXFaNum", 9F);
            button2.Location = new Point(531, 87);
            button2.Name = "button2";
            button2.Size = new Size(84, 43);
            button2.TabIndex = 2;
            button2.Text = "حذف";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("IRANYekanXFaNum", 9F);
            button3.Location = new Point(441, 87);
            button3.Name = "button3";
            button3.Size = new Size(84, 43);
            button3.TabIndex = 3;
            button3.Text = "ویرایش";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.Dell_light_3x;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("IRANYekanXFaNum", 9F);
            btnClose.Location = new Point(669, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(58, 43);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += this.btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = Properties.Resources.Refresh_light_3x;
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("IRANYekanXFaNum", 9F);
            btnRefresh.Location = new Point(25, 215);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(58, 43);
            btnRefresh.TabIndex = 5;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("IRANYekanXFaNum DemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(429, 19);
            label1.Name = "label1";
            label1.Size = new Size(204, 36);
            label1.TabIndex = 6;
            label1.Text = "مدیریت اشخاص";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("IRANYekanXFaNum", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(525, 143);
            txtFirstName.MaxLength = 100;
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "نام ";
            txtFirstName.RightToLeft = RightToLeft.Yes;
            txtFirstName.Size = new Size(180, 32);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("IRANYekanXFaNum", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(525, 181);
            txtLastName.MaxLength = 100;
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "نام خانوادگی";
            txtLastName.RightToLeft = RightToLeft.Yes;
            txtLastName.Size = new Size(180, 32);
            txtLastName.TabIndex = 8;
            // 
            // PersonManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "PersonManager";
            Size = new Size(730, 614);
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dgvPerson;
        private Button button2;
        private Button button3;
        private Button btnClose;
        private Button btnRefresh;
        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
    }
}
