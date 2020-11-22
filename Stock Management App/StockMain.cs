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
    public partial class StockMain : Form
    {
        private int childFormNumber = 0;

        public StockMain()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products pd = new Products();
            pd.MdiParent = this;
            pd.StartPosition = FormStartPosition.CenterScreen;
            pd.Show();
            
        }

        private void StockMain_Load(object sender, EventArgs e)
        {
            
        }
        //This is for close icon in StockMain page
        bool cancel = true;
        private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancel)
            {
                DialogResult d;
                d = MessageBox.Show("Are you sure", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    cancel = false;
                    Application.Exit(); //This will terminat all processes and close the application
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stk = new Stock();
            stk.MdiParent = this;
            stk.StartPosition = FormStartPosition.CenterScreen;
            stk.Show();
        }
    }
}
