using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiHK.DAL.Entity
{
    class LopHoc
    {   
        [Key]
        public String MaLH { get; set; }
        public String TenLH { get; set; }
        public String PhongHoc { get; set; }
        public String NamHoc { get; set; }
        public int SiSo { get; set; }
        public String KhoiHoc { get; set; }
        public static List<LopHoc> GetListLopHoc(String khoihoc="",String namhoc="")
        {

            List<LopHoc> dslh = new ConnectionsDBContext().LopHocDbSet.ToList();
            if (!khoihoc.Equals("") && !namhoc.Equals(""))
            {
                List<LopHoc> lh = new List<LopHoc>();
                foreach (LopHoc i in dslh)
                {
                    if (i.KhoiHoc.Equals(khoihoc) && i.NamHoc.Equals(namhoc))
                    {
                        lh.Add(i);
                    }
                }
                return lh;
            }
            else
                return dslh;
        }
        public static void ThemLH(LopHoc lh)
        {
            try { 
            var db = new ConnectionsDBContext();
            db.LopHocDbSet.Add(lh);
                db.SaveChanges();
            }
            catch(Exception ex) { }
        }
        public static void XoaLH(LopHoc lh)
        {
            var db = new ConnectionsDBContext();
            var obj = db.LopHocDbSet.Where(e => e.MaLH == lh.MaLH).FirstOrDefault();
            if (obj != null)
            {
                db.LopHocDbSet.Remove(obj);
            }
            db.SaveChanges();
        }
    }
}
