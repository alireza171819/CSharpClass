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
            btnSave = new Button();
            dgvCustomers = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClose = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtYear = new TextBox();
            txtMonth = new TextBox();
            txtDay = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.Location = new Point(205, 86);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 43);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeColumns = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvCustomers.ColumnHeadersHeight = 32;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { Id, FullName, DateOfBirth });
            dgvCustomers.Location = new Point(25, 257);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(680, 319);
            dgvCustomers.TabIndex = 10;
            dgvCustomers.TabStop = false;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // FullName
            // 
            FullName.HeaderText = "FullName";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 300;
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "Date Of Birth";
            DateOfBirth.MinimumWidth = 6;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.ReadOnly = true;
            DateOfBirth.Width = 380;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.Location = new Point(115, 86);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 43);
            btnDelete.TabIndex = 7;
            btnDelete.TabStop = false;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F);
            btnUpdate.Location = new Point(25, 86);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 43);
            btnUpdate.TabIndex = 8;
            btnUpdate.TabStop = false;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
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
            btnClose.TabIndex = 5;
            btnClose.TabStop = false;
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
            btnRefresh.TabIndex = 6;
            btnRefresh.TabStop = false;
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
            txtFirstName.TabIndex = 0;
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
            txtLastName.TabIndex = 1;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Segoe UI", 10.2F);
            txtYear.ForeColor = SystemColors.ControlText;
            txtYear.Location = new Point(356, 141);
            txtYear.MaxLength = 4;
            txtYear.Multiline = true;
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "Year";
            txtYear.Size = new Size(79, 32);
            txtYear.TabIndex = 2;
            txtYear.KeyPress += txtYear_KeyPress;
            // 
            // txtMonth
            // 
            txtMonth.Font = new Font("Segoe UI", 10.2F);
            txtMonth.ForeColor = SystemColors.ControlText;
            txtMonth.Location = new Point(441, 141);
            txtMonth.MaxLength = 2;
            txtMonth.Multiline = true;
            txtMonth.Name = "txtMonth";
            txtMonth.PlaceholderText = "Month";
            txtMonth.Size = new Size(60, 32);
            txtMonth.TabIndex = 3;
            txtMonth.KeyPress += txtMonth_KeyPress;
            // 
            // txtDay
            // 
            txtDay.Font = new Font("Segoe UI", 10.2F);
            txtDay.ForeColor = SystemColors.ControlText;
            txtDay.Location = new Point(507, 141);
            txtDay.MaxLength = 0;
            txtDay.Multiline = true;
            txtDay.Name = "txtDay";
            txtDay.PlaceholderText = "Day";
            txtDay.Size = new Size(60, 32);
            txtDay.TabIndex = 4;
            txtDay.KeyPress += txtDay_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(231, 144);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 13;
            label2.Text = "Date Of Birth :";
            // 
            // CustomerManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(txtDay);
            Controls.Add(txtMonth);
            Controls.Add(txtYear);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvCustomers);
            Controls.Add(btnSave);
            Name = "CustomerManager";
            Size = new Size(730, 614);
            Load += CustomerManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private DataGridView dgvCustomers;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClose;
        private Button btnRefresh;
        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtYear;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn DateOfBirth;
        private TextBox txtMonth;
        private TextBox txtDay;
        private Label label2;
    }
}
