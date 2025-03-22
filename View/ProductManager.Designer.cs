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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtDescription = new TextBox();
            txtTitel = new TextBox();
            label1 = new Label();
            btnRefresh = new Button();
            btnClose = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvProducts = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Titel = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Sku = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            txtUnitPrice = new TextBox();
            txtSku = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10.2F);
            txtDescription.Location = new Point(51, 194);
            txtDescription.MaxLength = 100;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(180, 32);
            txtDescription.TabIndex = 2;
            // 
            // txtTitel
            // 
            txtTitel.Font = new Font("Segoe UI", 10.2F);
            txtTitel.Location = new Point(51, 156);
            txtTitel.MaxLength = 100;
            txtTitel.Multiline = true;
            txtTitel.Name = "txtTitel";
            txtTitel.PlaceholderText = "Titel";
            txtTitel.Size = new Size(180, 32);
            txtTitel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 29);
            label1.Name = "label1";
            label1.Size = new Size(257, 38);
            label1.TabIndex = 15;
            label1.Text = "Products Manager";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = Properties.Resources.Refresh_light_3x;
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("IRANYekanXFaNum", 9F);
            btnRefresh.ForeColor = Color.Transparent;
            btnRefresh.Location = new Point(648, 230);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(46, 43);
            btnRefresh.TabIndex = 6;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
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
            btnClose.TabIndex = 9;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F);
            btnUpdate.Location = new Point(51, 100);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 43);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.Location = new Point(141, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 43);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToOrderColumns = true;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { Id, Titel, Description, Sku, UnitPrice });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.Location = new Point(14, 275);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProducts.ScrollBars = ScrollBars.Vertical;
            dgvProducts.Size = new Size(680, 319);
            dgvProducts.TabIndex = 10;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
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
            // Titel
            // 
            Titel.HeaderText = "Titel";
            Titel.MinimumWidth = 6;
            Titel.Name = "Titel";
            Titel.ReadOnly = true;
            Titel.Width = 150;
            // 
            // Description
            // 
            Description.FillWeight = 200F;
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 200;
            // 
            // Sku
            // 
            Sku.HeaderText = "Sku";
            Sku.MinimumWidth = 6;
            Sku.Name = "Sku";
            Sku.ReadOnly = true;
            Sku.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            UnitPrice.Width = 200;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.Location = new Point(231, 100);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 43);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI", 10.2F);
            txtUnitPrice.Location = new Point(248, 194);
            txtUnitPrice.MaxLength = 100;
            txtUnitPrice.Multiline = true;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.PlaceholderText = "UnitPrice";
            txtUnitPrice.Size = new Size(180, 32);
            txtUnitPrice.TabIndex = 4;
            txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
            txtUnitPrice.KeyPress += txtUnitPrice_KeyPress;
            // 
            // txtSku
            // 
            txtSku.Font = new Font("Segoe UI", 10.2F);
            txtSku.Location = new Point(248, 156);
            txtSku.MaxLength = 100;
            txtSku.Multiline = true;
            txtSku.Name = "txtSku";
            txtSku.PlaceholderText = "Sku";
            txtSku.Size = new Size(180, 32);
            txtSku.TabIndex = 3;
            // 
            // ProductManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(txtUnitPrice);
            Controls.Add(txtSku);
            Controls.Add(txtDescription);
            Controls.Add(txtTitel);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvProducts);
            Controls.Add(btnSave);
            Name = "ProductManager";
            Size = new Size(730, 614);
            Load += ProductManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private TextBox txtTitel;
        private Label label1;
        private Button btnRefresh;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvProducts;
        private Button btnSave;
        private TextBox txtUnitPrice;
        private TextBox txtSku;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titel;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Sku;
        private DataGridViewTextBoxColumn UnitPrice;
    }
}
