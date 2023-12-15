using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.View_User
{
    public partial class FthanhToan : Form
    {
        public string status = "";

        public FthanhToan()
        {
            InitializeComponent();
            btn_acp.Enabled = false;

        }
        public FthanhToan(int price) : this()
        {
            label1.Text = price.ToString();
        }

        public void btn_acp_Click(object sender, EventArgs e)
        {
            status = "Thanh toán";
            MessageBox.Show("Thanh toán thành công");
            this.Close();
        }

        public void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btn_acp.Enabled = true;
            }
            else
            {
                btn_acp.Enabled = false;
            }
        }
    }
}
