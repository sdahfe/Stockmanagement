using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_App
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            this.ActiveControl = dateTimePicker;
            txtproductstatus.SelectedIndex = 0;
        }

        private void dateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                txtProductcode.Focus();
            }

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
            if (e.KeyCode == Keys.Enter)
            {
                Focus_txtproductname();
            }
        }
        private void Focus_txtproductname()
        {
            if (txtProductcode.TextLength > 0)
            {
                txtproductquantity.Focus();
            }
            else
            {
                txtProductname.Focus();
            }
        }

        private void txtproductquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtproductquantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Focus_txtproductquantity();
            }
        }
        private void Focus_txtproductquantity()
        {
            if (txtproductquantity.TextLength > 0)
            {
                txtproductstatus.Focus();
            }
            else
            {
                txtproductquantity.Focus();
            }
        }

        private void txtproductstatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Focus_txtproductstatus();
            }
        }
        private void Focus_txtproductstatus()
        {
            if (txtproductstatus.SelectedIndex!=-1)
            {
                btn_add1.Focus();
            }
            else
            {
                txtproductstatus.Focus();
            }
        }

        private void btn_add1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
