using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShopCakeManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_DangNhap());
            //Application.Run(new frm_Menu());
<<<<<<< HEAD
           // Application.Run(new frm_HoaDonOnline());
            //Application.Run(new frm_Menu());
=======
            Application.Run(new frm_HoaDonOnline());
>>>>>>> e198177daf1f8fdc26e3f63c15c6411a3f91d286
=======
            Application.Run(new frm_Menu());
<<<<<<< HEAD
>>>>>>> parent of e198177... Thương: Thiết kế giao diện đơn hàng online
=======
>>>>>>> parent of 675399c... đăng nhaaph và  phân quyền success
>>>>>>> 4c5a7a784bbc0d7505410e305edd7a5e834d57a8
>>>>>>> e57c5c8fedf0d5646031e779644a98649aa73f04
        }
    }
}
