namespace Stock_Management_App
{
    partial class Stock
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
            this.txtproductquantity = new System.Windows.Forms.TextBox();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.txtproductstatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_add1 = new System.Windows.Forms.Button();
            this.btn_Delete1 = new System.Windows.Forms.Button();
            this.btn_Reset1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.libproduct = new System.Windows.Forms.Label();
            this.libQuantity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductcode
            // 
            this.txtProductcode.Location = new System.Drawing.Point(175, 69);
            this.txtProductcode.Name = "txtProductcode";
            this.txtProductcode.Size = new System.Drawing.Size(126, 20);
            this.txtProductcode.TabIndex = 0;
            this.txtProductcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductcode_KeyDown);
            // 
            // txtproductquantity
            // 
            this.txtproductquantity.Location = new System.Drawing.Point(483, 69);
            this.txtproductquantity.Name = "txtproductquantity";
            this.txtproductquantity.Size = new System.Drawing.Size(123, 20);
            this.txtproductquantity.TabIndex = 1;
            this.txtproductquantity.TextChanged += new System.EventHandler(this.txtproductquantity_TextChanged);
            this.txtproductquantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtproductquantity_KeyDown);
            // 
            // txtProductname
            // 
            this.txtProductname.Location = new System.Drawing.Point(333, 69);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(120, 20);
            this.txtProductname.TabIndex = 2;
            this.txtProductname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductname_KeyDown);
            // 
            // txtproductstatus
            // 
            this.txtproductstatus.FormattingEnabled = true;
            this.txtproductstatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.txtproductstatus.Location = new System.Drawing.Point(626, 69);
            this.txtproductstatus.Name = "txtproductstatus";
            this.txtproductstatus.Size = new System.Drawing.Size(121, 21);
            this.txtproductstatus.TabIndex = 3;
            this.txtproductstatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtproductstatus_KeyDown);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(41, 69);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker_KeyDown);
            // 
            // btn_add1
            // 
            this.btn_add1.Location = new System.Drawing.Point(275, 117);
            this.btn_add1.Name = "btn_add1";
            this.btn_add1.Size = new System.Drawing.Size(75, 40);
            this.btn_add1.TabIndex = 5;
            this.btn_add1.Text = "Add";
            this.btn_add1.UseVisualStyleBackColor = true;
            this.btn_add1.Click += new System.EventHandler(this.button1_Click);
            this.btn_add1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_add1_KeyDown);
            // 
            // btn_Delete1
            // 
            this.btn_Delete1.Location = new System.Drawing.Point(368, 117);
            this.btn_Delete1.Name = "btn_Delete1";
            this.btn_Delete1.Size = new System.Drawing.Size(75, 40);
            this.btn_Delete1.TabIndex = 6;
            this.btn_Delete1.Text = "Delete";
            this.btn_Delete1.UseVisualStyleBackColor = true;
            this.btn_Delete1.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Reset1
            // 
            this.btn_Reset1.Location = new System.Drawing.Point(460, 117);
            this.btn_Reset1.Name = "btn_Reset1";
            this.btn_Reset1.Size = new System.Drawing.Size(75, 40);
            this.btn_Reset1.TabIndex = 7;
            this.btn_Reset1.Text = "Reset";
            this.btn_Reset1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(41, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 237);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S.No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product code";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Product name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(623, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Status";
            // 
            // libproduct
            // 
            this.libproduct.AutoSize = true;
            this.libproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libproduct.Location = new System.Drawing.Point(102, 441);
            this.libproduct.Name = "libproduct";
            this.libproduct.Size = new System.Drawing.Size(113, 18);
            this.libproduct.TabIndex = 14;
            this.libproduct.Text = "Total Products: \r\n";
            // 
            // libQuantity
            // 
            this.libQuantity.AutoSize = true;
            this.libQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libQuantity.Location = new System.Drawing.Point(537, 441);
            this.libQuantity.Name = "libQuantity";
            this.libQuantity.Size = new System.Drawing.Size(103, 18);
            this.libQuantity.TabIndex = 15;
            this.libQuantity.Text = "Total Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "0";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 484);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.libQuantity);
            this.Controls.Add(this.libproduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Reset1);
            this.Controls.Add(this.btn_Delete1);
            this.Controls.Add(this.btn_add1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtproductstatus);
            this.Controls.Add(this.txtProductname);
            this.Controls.Add(this.txtproductquantity);
            this.Controls.Add(this.txtProductcode);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductcode;
        private System.Windows.Forms.TextBox txtproductquantity;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.ComboBox txtproductstatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btn_add1;
        private System.Windows.Forms.Button btn_Delete1;
        private System.Windows.Forms.Button btn_Reset1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label libproduct;
        private System.Windows.Forms.Label libQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}