using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShopCakeManager
{
    public partial class frm_Menu : Form
    {
        public ServiceReference.WebServiceSoapClient webservice = new ServiceReference.WebServiceSoapClient();

        private static frm_Menu inst;

        public int Uid = frm_DangNhap.IDNV;

        List<Int32> listHD = null;
        public frm_Menu()
        {
            InitializeComponent();

            getListHoatDong();
        }
        public static frm_Menu getForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                {
                    inst = new frm_Menu();
                }
                return inst;
            }
        }

        public void getListHoatDong()
        {
          
            int t = webservice.get_MaQuyenNV(Uid);
            //MessageBox.Show(t.ToString());
            listHD = webservice.get_MaHoatDong(t);

            foreach (var item in listHD)
            {
                switch (item)
                {
                    case 1:
                        btnBH.Enabled=true;
                        break;
                    case 2:
                        btnTK.Enabled = true;
                        break;
                    case 3:
                        btnBHH.Enabled = true;
                        break;
                    case 4:
                        btnTTNV.Enabled = true;
                        break;
                    case 5:
                        btnQL.Enabled = true;
                        break;
                    case 6:
                        btnTTKH.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
           

        }
        private void salesTile_Click(object sender, EventArgs e)
        {
            //frm_Alert.Alert("Thương mèo",frm_Alert.AlertType.success);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();

            frm_DangNhap.getForm.Show();
        }   
    }
}
