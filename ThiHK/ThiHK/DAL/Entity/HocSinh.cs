using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiHK.DAL.Entity
{
    class HocSinh
    {
        [Key]
        public String MaHS { get; set; }
        public String Ho { get; set; }
        public String Ten { get; set; }
        public Sex GioiTinh { get; set; }
        public String NoiSinh { get; set; }
        public String QueQuan { get; set; }
        public String MaLH { get; set; }
        [ForeignKey("MaLH")]
        public virtual LopHoc LopHoc { get; set; }
        public static List<HocSinh> GetListHocSinh(String malop="")
        {
            if (!malop.Equals(""))
            {
                List<HocSinh> dshs = new ConnectionsDBContext().HocSinhDbSet.ToList();
                List<HocSinh> hs = new List<HocSinh>();
                foreach (HocSinh i in dshs)
                {
                    if (i.MaLH.Equals(malop))
                    {
                        hs.Add(i);
                    }
                }
                return hs;
            }
            else
                return new ConnectionsDBContext().HocSinhDbSet.ToList();
        }
        public static void ThemHS(HocSinh hs)
        {
            var db = new ConnectionsDBContext();
            db.HocSinhDbSet.Add(hs);
            db.SaveChanges();
        }
        public static void XoaHS(HocSinh hs)
        {
            var db = new ConnectionsDBContext();
            var obj = db.HocSinhDbSet.Where(e => e.MaLH == hs.MaHS).FirstOrDefault();
            if (obj != null)
            {
                db.HocSinhDbSet.Remove(obj);
            }
            db.SaveChanges();
        }
    }
    public enum Sex { Nam,Nu}
}
