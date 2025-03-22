namespace View
{
    partial class CustomerManager
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
            dgvCustomers = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            btnClose = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtDateOfBirth = new TextBox();
            Id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(205, 86);
            button1.Name = "button1";
            button1.Size = new Size(84, 43);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvCustomers.ColumnHeadersHeight = 32;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { Id, FullName, DateOfBirth });
            dgvCustomers.Location = new Point(25, 257);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(680, 319);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(115, 86);
            button2.Name = "button2";
            button2.Size = new Size(84, 43);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F);
            button3.Location = new Point(25, 86);
            button3.Name = "button3";
            button3.Size = new Size(84, 43);
            button3.TabIndex = 3;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.Dell_light_3x;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("IRANYekanXFaNum", 9F);
            btnClose.ForeColor = Color.Transparent;
            btnClose.Location = new Point(11, 11);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(48, 43);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = Properties.Resources.Refresh_light_3x;
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Transparent;
            btnRefresh.Location = new Point(662, 212);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(43, 43);
            btnRefresh.TabIndex = 5;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 27);
            label1.Name = "label1";
            label1.Size = new Size(268, 38);
            label1.TabIndex = 6;
            label1.Text = "Customer Manager";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10.2F);
            txtFirstName.ForeColor = SystemColors.ControlText;
            txtFirstName.Location = new Point(25, 141);
            txtFirstName.MaxLength = 100;
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(180, 32);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10.2F);
            txtLastName.ForeColor = SystemColors.ControlText;
            txtLastName.Location = new Point(25, 179);
            txtLastName.MaxLength = 100;
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(180, 32);
            txtLastName.TabIndex = 8;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Font = new Font("Segoe UI", 10.2F);
            txtDateOfBirth.ForeColor = SystemColors.ControlText;
            txtDateOfBirth.Location = new Point(229, 141);
            txtDateOfBirth.MaxLength = 100;
            txtDateOfBirth.Multiline = true;
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.PlaceholderText = "Date Of Birth";
            txtDateOfBirth.Size = new Size(180, 32);
            txtDateOfBirth.TabIndex = 9;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // FullName
            // 
            FullName.HeaderText = "FullName";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.Width = 300;
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "Date Of Birth";
            DateOfBirth.MinimumWidth = 6;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Width = 380;
            // 
            // CustomerManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dgvCustomers);
            Controls.Add(button1);
            Name = "CustomerManager";
            Size = new Size(730, 614);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dgvCustomers;
        private Button button2;
        private Button button3;
        private Button btnClose;
        private Button btnRefresh;
        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDateOfBirth;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn DateOfBirth;
    }
}
