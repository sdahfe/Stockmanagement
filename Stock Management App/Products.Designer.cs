namespace Stock_Management_App
{
    partial class Products
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProductcode = new System.Windows.Forms.TextBox();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.btn_Delect = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Productcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_Code = new System.Windows.Forms.Label();
            this.Product_Name = new System.Windows.Forms.Label();
            this.txtProductstatus = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductcode
            // 
            this.txtProductcode.Location = new System.Drawing.Point(79, 73);
            this.txtProductcode.Name = "txtProductcode";
            this.txtProductcode.Size = new System.Drawing.Size(121, 20);
            this.txtProductcode.TabIndex = 0;
            this.txtProductcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductcode_KeyDown);
            // 
            // txtProductname
            // 
            this.txtProductname.Location = new System.Drawing.Point(225, 73);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(121, 20);
            this.txtProductname.TabIndex = 1;
            this.txtProductname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtProductname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductname_KeyDown);
            // 
            // btn_Delect
            // 
            this.btn_Delect.Location = new System.Drawing.Point(525, 63);
            this.btn_Delect.Name = "btn_Delect";
            this.btn_Delect.Size = new System.Drawing.Size(75, 36);
            this.btn_Delect.TabIndex = 3;
            this.btn_Delect.Text = "Delect";
            this.btn_Delect.UseVisualStyleBackColor = true;
            this.btn_Delect.Click += new System.EventHandler(this.btn_Delect_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(623, 63);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 36);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Productcode,
            this.Productname,
            this.Productstatus});
            this.dataGridView1.Location = new System.Drawing.Point(79, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(653, 298);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Productcode
            // 
            this.Productcode.HeaderText = "Product code";
            this.Productcode.Name = "Productcode";
            // 
            // Productname
            // 
            this.Productname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Productname.HeaderText = "Product name";
            this.Productname.Name = "Productname";
            // 
            // Productstatus
            // 
            this.Productstatus.HeaderText = "Status";
            this.Productstatus.Name = "Productstatus";
            // 
            // product_Code
            // 
            this.product_Code.AutoSize = true;
            this.product_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Code.Location = new System.Drawing.Point(76, 48);
            this.product_Code.Name = "product_Code";
            this.product_Code.Size = new System.Drawing.Size(84, 13);
            this.product_Code.TabIndex = 6;
            this.product_Code.Text = "Product Code";
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSize = true;
            this.Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Name.Location = new System.Drawing.Point(222, 48);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(87, 13);
            this.Product_Name.TabIndex = 7;
            this.Product_Name.Text = "Product Name";
            this.Product_Name.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtProductstatus
            // 
            this.txtProductstatus.FormattingEnabled = true;
            this.txtProductstatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.txtProductstatus.Location = new System.Drawing.Point(371, 72);
            this.txtProductstatus.Name = "txtProductstatus";
            this.txtProductstatus.Size = new System.Drawing.Size(129, 21);
            this.txtProductstatus.TabIndex = 8;
            this.txtProductstatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductstatus_KeyDown);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(368, 48);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(43, 13);
            this.Status.TabIndex = 9;
            this.Status.Text = "Status";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(713, 63);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 36);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.txtProductstatus);
            this.Controls.Add(this.Product_Name);
            this.Controls.Add(this.product_Code);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delect);
            this.Controls.Add(this.txtProductname);
            this.Controls.Add(this.txtProductcode);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductcode;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.Button btn_Delect;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label product_Code;
        private System.Windows.Forms.Label Product_Name;
        private System.Windows.Forms.ComboBox txtProductstatus;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productstatus;
        private System.Windows.Forms.Button btn_reset;
    }
}