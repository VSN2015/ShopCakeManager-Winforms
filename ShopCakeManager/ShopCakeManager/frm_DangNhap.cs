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
        public static int IDNV = 0;
        private static frm_DangNhap inst;

        public ServiceReference.WebServiceSoapClient webservice = new ServiceReference.WebServiceSoapClient();
        public frm_DangNhap()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }
        public static frm_DangNhap getForm
        {
            get
            {
                if(inst==null || inst.IsDisposed){
                    inst = new frm_DangNhap();
                }
                return inst;
            }
        }
        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int tmp = 0;
            tmp=webservice.get_Count_UserNV(txtUsername.Text);
            if (tmp == 0)
            {
                MessageBox.Show("Bạn đã sai tên đăng nhập :))");
                return;
            }
            tmp = webservice.get_CountUser_PassNV(txtUsername.Text,txtPassword.Text);
            if(tmp!=1){
                MessageBox.Show("Bạn đã sai mật khẩu :))");
                return;
            }
            IDNV = webservice.get_IDNV(txtUsername.Text, txtPassword.Text);

            frm_Alert.Alert("Bạn đã đăng nhập thành công",frm_Alert.AlertType.success);
            this.Hide();
            frm_Menu.getForm.Show();
            
        }
    }
}
