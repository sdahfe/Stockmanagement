using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_App
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            txtProductstatus.SelectedIndex = 0;
            Load_Data();
            this.ActiveControl = txtProductcode;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                SqlConnection con = connectionclass.Getconnection();
                con.Open();
                //Insert logic
                bool status = false;
                if (txtProductstatus.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                var sqlQuery = "";
                if (IfProdustsExits(con, txtProductcode.Text))
                {
                    sqlQuery = @"UPDATE [dbo].[Products] SET [Product_name] = '" + txtProductname.Text + "',[Product_status] = '" + status + "'WHERE [Product_code] = '" + txtProductcode.Text + "'";
                }
                else
                {
                    sqlQuery = @"INSERT INTO [dbo].[Products] ([Product_code],[Product_name],[Product_status]) VALUES
                      ('" + txtProductcode.Text + "','" + txtProductname.Text + "','" + status + "')";
                }
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                //Reading data in Gridview
                Load_Data();
                Resetrecord();

            }
            else
            {
                MessageBox.Show("Please write something to add", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private bool IfProdustsExits(SqlConnection con, string Product_code)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Products] WHERE [Product_code] = '"+Product_code+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void Load_Data()
        {
            SqlConnection con = connectionclass.Getconnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Stock].[dbo].[Products] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Product_code"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Product_name"].ToString();
                if ((bool)item["Product_status"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Deactive";
                }

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btn_Add.Text = "update";
            txtProductcode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtProductname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString()== "Acitive")
            {
                txtProductstatus.SelectedIndex = 0; 
            }
            else
            {
                txtProductstatus.SelectedIndex = 1;
            }

        }

        private void btn_Delect_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                if (validation())
                {
                    SqlConnection con = connectionclass.Getconnection();
                    var sqlQuery = "";
                    if (IfProdustsExits(con, txtProductcode.Text))
                    {
                        con.Open();
                        sqlQuery = @"DELETE FROM [Products] WHERE [Product_code] = '" + txtProductcode.Text + "'";
                        SqlCommand cmd = new SqlCommand(sqlQuery, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Record not Eixts...");
                    }

                    //Reading data in Gridview
                    Load_Data();
                    Resetrecord();
                }
                else
                {
                    MessageBox.Show("Please select record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Resetrecord()
        {
            txtProductcode.Clear();
            txtProductname.Clear();
            txtProductstatus.SelectedIndex = -1;
            btn_Add.Text = "Add";
            txtProductcode.Focus();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Resetrecord();
        }
        private bool validation()
        {
            bool result = false;
            if(!string.IsNullOrEmpty(txtProductcode.Text) && !string.IsNullOrEmpty(txtProductname.Text) && txtProductstatus.SelectedIndex > -1)
            {
                result = true;
            }
            return result;
        }

        private void txtProductcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Focus_txtproductcode();
            }  
        }
        private void Focus_txtproductcode()
        {
            if(txtProductcode.TextLength > 0)
            {
                txtProductname.Focus();
            }
            else
            {
                txtProductcode.Focus();
            }
        }

        private void txtProductname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Focus_txtproductname();
            }
        }
        private void Focus_txtproductname()
        {
            if (txtProductcode.TextLength > 0)
            {
                txtProductstatus.Focus();
            }
            else
            {
                txtProductname.Focus();
            }
        }

        private void txtProductstatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Focus_txtproductstatus();
            }
        }
        private void Focus_txtproductstatus()
        {
            if (txtProductstatus.SelectedIndex!=-1)
            {
                btn_Add.Focus();
            }
            else
            {
                txtProductstatus.Focus();
            }
        }
    }
}
