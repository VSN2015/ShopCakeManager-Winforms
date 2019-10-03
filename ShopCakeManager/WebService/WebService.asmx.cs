using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int get_Count_UserNV(string username) // đếm số lượng username NV để phân quyền
        {
            using(DatabaseDataContext data = new DatabaseDataContext()){
                return (from u in data.NhanViens
                       where u.Username.Equals(username)
                       select u.Username).Count();
            }
        }

        [WebMethod]
        public int get_CountUser_PassNV(string username,string pass)// đếm số lượng username và pass NV để phân quyền
        {
            using (DatabaseDataContext data = new DatabaseDataContext())
            {
                return (from u in data.NhanViens
                        where u.Username.Equals(username)
                        where u.Password.Equals(pass)
                        select u.Username).Count();
            }
        }

        [WebMethod]
        public int get_IDNV(string username, string pass)//lấy id nhân viên khi đăng nhập
        {
            using (DatabaseDataContext data = new DatabaseDataContext())
            {
                return (from u in data.NhanViens
                                    where u.Username.Equals(username)
                                    where u.Password.Equals(pass)
                                    select u.MaNV).Single();
            }
        }
        [WebMethod]
        public int get_MaQuyenNV(int maNV) // lấy mã quyền của nhân viên
        {
            using(DatabaseDataContext data = new DatabaseDataContext()){
                return (from u in data.NhanVien_Quyens
                            where u.MaNhanVien.Equals(maNV)
                            where u.TrangThai.Equals("True")
                            select u.MaQuyen).Single();
            }
        }

        [WebMethod]
        public List<Int32> get_MaHoatDong(int maQuyen) // lấy list hoạt động của nv
        {
            List<Int32> arr = null;
            using (DatabaseDataContext data = new DatabaseDataContext())
            {
                return (from u in data.Quyen_HoatDongs
                        where u.MaQuyen.Equals(maQuyen)
                        where u.TrangThai.Equals("True")
                        select u.MaHoatDong).ToList();
            }
        }
    }
}
