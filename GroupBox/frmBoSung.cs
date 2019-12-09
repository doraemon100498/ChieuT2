using GroupBox.DAL;
using GroupBox.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox
{
    public partial class frmBoSung : Form
    {
        public frmBoSung()
        {
            InitializeComponent();
        }
        private void BtnDongY_Click(object sender, EventArgs e)
        {
            String maSV = txtMaSV.Text;
            String hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            int index = cbbKhoa.SelectedIndex;
            String khoa = "";
            if (index == 0) khoa = "Văn";
            else if (index == 1) khoa = "Vật lý";
            else if (index == 2) khoa = "CNTT";
            SEX gioiTinh = new SEX();
            if (rdbNam.Checked) gioiTinh = SEX.Male;
            if (rdbNu.Checked) gioiTinh = SEX.Female;
            if (maSV == "")
            {
                erp.SetError(txtMaSV, "Vui lòng nhập mã sinh viên!");
                txtMaSV.Focus();
                return;
            }
            else if (Student.KiemTra(maSV))
            {
                erp.SetError(txtMaSV, "Mã sinh viên đã tồn tại!");
                txtMaSV.Focus();
                return;
            }
            else if (hoTen == "")
            {
                erp.SetError(txtHoTen, "Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return;
            }
            else if (khoa == "")
            {
                erp.SetError(cbbKhoa, "Vui lòng chọn khoa!");
                cbbKhoa.Focus();
                return;
            }
            Student.Add(new Student
            {
                MaSV=maSV,
                HoTen=hoTen,
                GioiTinh=gioiTinh,
                NgaySinh=ngaySinh,
                TenKhoa=khoa
            });
            this.Close();
        }
        private void BtnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
