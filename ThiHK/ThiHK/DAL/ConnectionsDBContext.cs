using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiHK.DAL.Entity;

namespace ThiHK.DAL
{
    class ConnectionsDBContext:DbContext
    {
        public ConnectionsDBContext():base("Data Source=.;Initial Catalog=LeCongTueQuang;Persist Security Info=True;User ID=sa;Password=123")
        {

        }
        public DbSet<HocSinh> HocSinhDbSet { get; set; }
        public DbSet<LopHoc> LopHocDbSet { get; set; }
    }
}
