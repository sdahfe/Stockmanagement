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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();//Required method for designer support
        }
        //Button for canceling the login process
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_UserName.Text = "";
            txt_Password.Clear();
            txt_UserName.Focus();
        }
        //Button for login in application 
        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0EGE15A;Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[Login] where User_Name='"+txt_UserName.Text+"' and Password='"+txt_Password.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                StockMain main = new StockMain();// Here we are creating object of StockMain page objcet is main
                main.Show();// This will show the main form
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_cancel_Click(sender, e);
            }
        }

        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode== Keys.Enter)
            {
                Focus_user();
            }
        }
        private void Focus_user()
        {
            if (txt_UserName.TextLength > 0)
            {
                txt_Password.Focus();
            }
            else
            {
                txt_UserName.Focus();
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Focus_password();
            }
        }
        private void Focus_password()
        {
            if (txt_Password.TextLength > 0)
            {
                btn_Login.Focus();
            }
            else
            {
                txt_Password.Focus();
            }
        }
    }
}
