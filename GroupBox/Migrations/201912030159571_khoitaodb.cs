namespace GroupBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class khoitaodb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuaTrinhHocTaps",
                c => new
                    {
                        MaQTHT = c.String(nullable: false, maxLength: 128),
                        MonHoc = c.String(),
                        Diem = c.Long(nullable: false),
                        MaSV = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaQTHT)
                .ForeignKey("dbo.Students", t => t.MaSV)
                .Index(t => t.MaSV);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(),
                        GioiTinh = c.Int(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        TenKhoa = c.String(),
                    })
                .PrimaryKey(t => t.MaSV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuaTrinhHocTaps", "MaSV", "dbo.Students");
            DropIndex("dbo.QuaTrinhHocTaps", new[] { "MaSV" });
            DropTable("dbo.Students");
            DropTable("dbo.QuaTrinhHocTaps");
        }
    }
}
