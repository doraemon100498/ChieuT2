namespace GroupBox.Migrations
{
    using GroupBox.DAL;
    using GroupBox.DAL.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GroupBox.DAL.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GroupBox.DAL.DBContext context)
        {
            context.StudentDbset.AddOrUpdate(new Student
            {
                MaSV="1",
                HoTen="Maruko",
                GioiTinh=SEX.Female,
                NgaySinh=new DateTime(1998, 2, 15),
                TenKhoa="CNTT"
            }, new Student
            {
                MaSV = "2",
                HoTen = "Doraemon",
                GioiTinh = SEX.Male,
                NgaySinh = new DateTime(1998, 6, 28),
                TenKhoa = "Văn"
            }, new Student
            {
                MaSV = "3",
                HoTen = "Nobita",
                GioiTinh = SEX.Male,
                NgaySinh = new DateTime(2000, 9, 2),
                TenKhoa = "Vật lý"
            }, new Student
            {
                MaSV = "4",
                HoTen = "Ran",
                GioiTinh = SEX.Female,
                NgaySinh = new DateTime(1998, 2, 15),
                TenKhoa = "CNTT"
            }, new Student
            {
                MaSV = "5",
                HoTen = "Conan",
                GioiTinh = SEX.Male,
                NgaySinh = new DateTime(1998, 7, 21),
                TenKhoa = "Văn"
            }, new Student
            {
                MaSV = "6",
                HoTen = "Sonoko",
                GioiTinh = SEX.Female,
                NgaySinh = new DateTime(1998, 10, 4),
                TenKhoa = "Vật lý"
            });
            context.QuaTrinhHocTapDbset.AddOrUpdate(new QuaTrinhHocTap
            {
                MaQTHT="1",
                MonHoc="PHP in OPP",
                Diem=9,
                MaSV="1"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "2",
                MonHoc = "Python in OPP",
                Diem = 10,
                MaSV = "1"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "3",
                MonHoc = "PHP in OPP",
                Diem = 9,
                MaSV = "1"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "4",
                MonHoc = "Văn học cổ điển",
                Diem = 8,
                MaSV = "2"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "5",
                MonHoc = "Văn học hiện đại",
                Diem = 7,
                MaSV = "2"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "6",
                MonHoc = "Vật lý cơ bản",
                Diem = 9,
                MaSV = "3"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "7",
                MonHoc = "Vật lý nâng cao",
                Diem = 7,
                MaSV = "3"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "8",
                MonHoc = "PHP in OPP",
                Diem = 7,
                MaSV = "4"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "9",
                MonHoc = "Python in OPP",
                Diem = 6,
                MaSV = "4"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "10",
                MonHoc = "PHP in OPP",
                Diem = 6,
                MaSV = "4"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "11",
                MonHoc = "Văn học cổ điển",
                Diem = 9,
                MaSV = "5"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "12",
                MonHoc = "Văn học hiện đại",
                Diem = 9,
                MaSV = "5"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "13",
                MonHoc = "Vật lý cơ bản",
                Diem = 7,
                MaSV = "6"
            }, new QuaTrinhHocTap
            {
                MaQTHT = "14",
                MonHoc = "Vật lý nâng cao",
                Diem = 8,
                MaSV = "6"
            });
        }
    }
}
