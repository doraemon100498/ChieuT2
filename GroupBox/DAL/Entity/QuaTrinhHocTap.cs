using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBox.DAL.Entity
{
    public class QuaTrinhHocTap
    {
        [Key]
        public string MaQTHT { get; set; }
        public string MonHoc { get; set; }
        public long Diem { get; set; }
        public string MaSV { get; set; }
        [ForeignKey("MaSV")]
        public virtual Student Student { get; set; }
        public static List<QuaTrinhHocTap> GetList(String maSV)
        {
            return new DBContext().QuaTrinhHocTapDbset.Where(e => e.MaSV == maSV).ToList();
        }
        public static long DTB(String maSV)
        {
            var db = new DBContext().QuaTrinhHocTapDbset.Where(e => e.MaSV == maSV).ToList();
            int dem = 0;
            long dtb = 0;
            if (db.Count() != 0)
            {
                foreach (var i in db)
                {
                    dtb += i.Diem;
                    dem++;
                }
                dtb = dtb / dem;
            }
            return dtb;
        }
        public static void Xoa(String maSV)
        {
            var db = new DBContext();
            var ls = db.QuaTrinhHocTapDbset.Where(e => e.MaSV == maSV).OrderBy(e=>e.MaQTHT).ToList();
            db.QuaTrinhHocTapDbset.RemoveRange(ls);
            db.SaveChanges();
        }
        public static void Them(QuaTrinhHocTap qt)
        {
            var db = new DBContext();
            db.QuaTrinhHocTapDbset.Add(qt);
            db.SaveChanges();
        }
        public static String TaoMaSV()
        {
            var db = new DBContext();
            var n = db.QuaTrinhHocTapDbset.Count() + 1;
            return Convert.ToString(n);
        }
        public static QuaTrinhHocTap GetQTHT(String maQTHT)
        {
            return new DBContext().QuaTrinhHocTapDbset.Where(e => e.MaQTHT == maQTHT).FirstOrDefault();
        }
        public static void Remove(String maQTHTT)
        {
            var db = new DBContext();
            var obj = db.QuaTrinhHocTapDbset.Where(e => e.MaQTHT == maQTHTT).FirstOrDefault();
            if (obj != null)
                db.QuaTrinhHocTapDbset.Remove(obj);
            db.SaveChanges();
        }
        public static bool KT(String monHoc)
        {
            var db = new DBContext();
            var obj = db.QuaTrinhHocTapDbset.Where(e => e.MonHoc == monHoc).FirstOrDefault();
            if (obj != null)
                return true;
            return false;
        }
        public static void Edit(QuaTrinhHocTap qt)
        {
            var db = new DBContext();
            var obj = db.QuaTrinhHocTapDbset.Where(e => e.MaQTHT == qt.MaQTHT).FirstOrDefault();
            if (obj != null)
            {
                obj.Diem = qt.Diem;
            }
            db.SaveChanges();
        }
    }
}
