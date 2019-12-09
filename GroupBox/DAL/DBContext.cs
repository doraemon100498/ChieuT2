using GroupBox.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBox.DAL
{
    public class DBContext: DbContext
    {
        public DBContext()
            : base("Data Source=.;Initial Catalog=QLDiemThi;Persist Security Info=True;User ID=sa;Password=1234")
        {
        }
        public DbSet<Student> StudentDbset { get; set; }
        public DbSet<QuaTrinhHocTap> QuaTrinhHocTapDbset { get; set; }
    }
}
