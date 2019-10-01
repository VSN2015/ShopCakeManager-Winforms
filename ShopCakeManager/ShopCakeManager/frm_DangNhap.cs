using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCakeManager
{
    public partial class frm_DangNhap : Form
    {

        //frm_DangKy frm_DK = new frm_DangKy();

        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //frm_Alert alert = new frm_Alert();

            //frm_Alert.Alert("Như Thương",frm_Alert.AlertType.success);
        }

        private void cbxShowPass_OnChange(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                bunifuCustomLabel3.ForeColor = Color.SteelBlue;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                bunifuCustomLabel3.ForeColor = Color.White;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            panel1.BackColor = Color.SteelBlue;
            txtUsername.ForeColor = Color.Red;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            panel2.BackColor = Color.SteelBlue;
            txtPassword.ForeColor = Color.Red;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            txtUsername.ForeColor = Color.Black;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            txtPassword.ForeColor = Color.Black;
        }
    }
}
