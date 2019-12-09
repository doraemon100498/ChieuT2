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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> ls = Student.GetList();
            if (ls.Count > 0)
            {
                foreach (var i in ls)
                {
                    if (i.GioiTinh == SEX.Male)
                        listBox1.Items.Add("Anh " + i.HoTen);
                    else if (i.GioiTinh == SEX.Female)
                        listBox1.Items.Add("Chị " + i.HoTen);
                }
                txtHoTen.Text = ls[0].HoTen;
                if (ls[0].GioiTinh == SEX.Female)
                    ckbGioiTinh.Checked = false;
                else if (ls[0].GioiTinh == SEX.Male)
                    ckbGioiTinh.Checked = true;
                dtpNgaySinh.Value = ls[0].NgaySinh;
                lblDTB.Text = Convert.ToString(QuaTrinhHocTap.DTB(ls[0].MaSV));
                List<QuaTrinhHocTap> qt = QuaTrinhHocTap.GetList(ls[0].MaSV);
                if (ls[0].TenKhoa == "CNTT")
                {
                    tabControl1.SelectedTab = tabPage3;
                    foreach (var i in qt)
                        lsbCNTT.Items.Add(i.MonHoc + ":" + i.Diem);
                }
                else if (ls[0].TenKhoa == "Văn")
                {
                    tabControl1.SelectedTab = tabPage1;
                    foreach (var i in qt)
                        lstVan.Items.Add(i.MonHoc + ":" + i.Diem);
                }
                else if (ls[0].TenKhoa == "Vật lý")
                {
                    tabControl1.SelectedTab = tabPage2;
                    foreach (var i in qt)
                        lsbVatLy.Items.Add(i.MonHoc + ":" + i.Diem);
                }
            }
        }
        private void TsbXoa_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int s = listBox1.Items.Count;
                List<Student> ls = Student.GetList();
                int index = listBox1.SelectedIndex;
                listBox1.Items.Clear();
                lsbCNTT.Items.Clear();
                lsbVatLy.Items.Clear();
                lstVan.Items.Clear();
                txtHoTen.Text = "";
                ckbGioiTinh.Checked = false;
                lblDTB.Text = "";
                if (ls.Count == s)
                {
                    QuaTrinhHocTap.Xoa(ls[index].MaSV);
                    Student.Xoa(ls[index].MaSV);
                    ls = Student.GetList();
                    if (ls.Count > 0)
                    {
                        foreach (var i in ls)
                        {
                            if (i.GioiTinh == SEX.Male)
                                listBox1.Items.Add("Anh " + i.HoTen);
                            else if (i.GioiTinh == SEX.Female)
                                listBox1.Items.Add("Chị " + i.HoTen);
                        }
                        txtHoTen.Text = ls[0].HoTen;
                        if (ls[0].GioiTinh == SEX.Female)
                            ckbGioiTinh.Checked = false;
                        else if (ls[0].GioiTinh == SEX.Male)
                            ckbGioiTinh.Checked = true;
                        dtpNgaySinh.Value = ls[0].NgaySinh;
                        lblDTB.Text = Convert.ToString(QuaTrinhHocTap.DTB(ls[0].MaSV));
                        List<QuaTrinhHocTap> qt = QuaTrinhHocTap.GetList(ls[0].MaSV);
                        if (ls[0].TenKhoa == "CNTT")
                        {
                            tabControl1.SelectedTab = tabPage3;
                            foreach (var i in qt)
                                lsbCNTT.Items.Add(i.MonHoc + ":" + i.Diem);
                        }
                        else if (ls[0].TenKhoa == "Văn")
                        {
                            tabControl1.SelectedTab = tabPage1;
                            foreach (var i in qt)
                                lstVan.Items.Add(i.MonHoc + ":" + i.Diem);
                        }
                        else if (ls[0].TenKhoa == "Vật lý")
                        {
                            tabControl1.SelectedTab = tabPage2;
                            foreach (var i in qt)
                                lsbVatLy.Items.Add(i.MonHoc + ":" + i.Diem);
                        }
                    }
                }
                else
                {
                    String key = txtTimKiem.Text;
                    ls = Student.TimKiem(key);
                    if (ls.Count > 0)
                    {
                        txtTimKiem.Text = "";
                        QuaTrinhHocTap.Xoa(ls[index].MaSV);
                        Student.Xoa(ls[index].MaSV);
                        ls = Student.GetList();
                        foreach (var i in ls)
                        {
                            if (i.GioiTinh == SEX.Male)
                                listBox1.Items.Add("Anh " + i.HoTen);
                            else if (i.GioiTinh == SEX.Female)
                                listBox1.Items.Add("Chị " + i.HoTen);
                        }
                        txtHoTen.Text = ls[0].HoTen;
                        if (ls[0].GioiTinh == SEX.Female)
                            ckbGioiTinh.Checked = false;
                        else if (ls[0].GioiTinh == SEX.Male)
                            ckbGioiTinh.Checked = true;
                        dtpNgaySinh.Value = ls[0].NgaySinh;
                        lblDTB.Text = Convert.ToString(QuaTrinhHocTap.DTB(ls[0].MaSV));
                        List<QuaTrinhHocTap> qt = QuaTrinhHocTap.GetList(ls[0].MaSV);
                        if (ls[0].TenKhoa == "CNTT")
                        {
                            tabControl1.SelectedTab = tabPage3;
                            foreach (var i in qt)
                                lsbCNTT.Items.Add(i.MonHoc + ":" + i.Diem);
                        }
                        else if (ls[0].TenKhoa == "Văn")
                        {
                            tabControl1.SelectedTab = tabPage1;
                            foreach (var i in qt)
                                lstVan.Items.Add(i.MonHoc + ":" + i.Diem);
                        }
                        else if (ls[0].TenKhoa == "Vật lý")
                        {
                            tabControl1.SelectedTab = tabPage2;
                            foreach (var i in qt)
                                lsbVatLy.Items.Add(i.MonHoc + ":" + i.Diem);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên muốn xóa!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void TxtTimKiem_Click(object sender, EventArgs e)
        {
            List<Student> ls = new List<Student>();
            String key = txtTimKiem.Text;
            if (key == "")
                ls = Student.GetList();
            else ls = Student.TimKiem(key);
            listBox1.Items.Clear();
            lsbCNTT.Items.Clear();
            lsbVatLy.Items.Clear();
            lstVan.Items.Clear();
            txtHoTen.Text = "";
            ckbGioiTinh.Checked = false;
            lblDTB.Text = "";
            if (ls.Count > 0)
            {
                foreach (var i in ls)
                {
                    if (i.GioiTinh == SEX.Male)
                        listBox1.Items.Add("Anh " + i.HoTen);
                    else if (i.GioiTinh == SEX.Female)
                        listBox1.Items.Add("Chị " + i.HoTen);
                }
                txtHoTen.Text = ls[0].HoTen;
                if (ls[0].GioiTinh == SEX.Female)
                    ckbGioiTinh.Checked = false;
                else if (ls[0].GioiTinh == SEX.Male)
                    ckbGioiTinh.Checked = true;
                dtpNgaySinh.Value = ls[0].NgaySinh;
                lblDTB.Text = Convert.ToString(QuaTrinhHocTap.DTB(ls[0].MaSV));
                List<QuaTrinhHocTap> qt = QuaTrinhHocTap.GetList(ls[0].MaSV);
                if (ls[0].TenKhoa == "CNTT")
                {
                    tabControl1.SelectedTab = tabPage3;
                    foreach (var i in qt)
                        lsbCNTT.Items.Add(i.MonHoc + ":" + i.Diem);
                }
                else if (ls[0].TenKhoa == "Văn")
                {
                    tabControl1.SelectedTab = tabPage1;
                    foreach (var i in qt)
                        lstVan.Items.Add(i.MonHoc + ":" + i.Diem);
                }
                else if (ls[0].TenKhoa == "Vật lý")
                {
                    tabControl1.SelectedTab = tabPage2;
                    foreach (var i in qt)
                        lsbVatLy.Items.Add(i.MonHoc + ":" + i.Diem);
                }
            }
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int s = listBox1.Items.Count;
                List<Student> ls = Student.GetList();
                if (ls.Count == s)
                {
                    int index = listBox1.SelectedIndex;
                    lsbCNTT.Items.Clear();
                    lsbVatLy.Items.Clear();
                    lstVan.Items.Clear();
                    txtHoTen.Text = "";
                    ckbGioiTinh.Checked = false;
                    lblDTB.Text = "";
                    txtHoTen.Text = ls[index].HoTen;
                    if (ls[index].GioiTinh == SEX.Female)
                        ckbGioiTinh.Checked = false;
                    else if (ls[index].GioiTinh == SEX.Male)
                        ckbGioiTinh.Checked = true;
                    dtpNgaySinh.Value = ls[index].NgaySinh;
                    lblDTB.Text = Convert.ToString(QuaTrinhHocTap.DTB(ls[index].MaSV));
                    List<QuaTrinhHocTap> qt = QuaTrinhHocTap.GetList(ls[index].MaSV);
                    if (ls[index].TenKhoa == "CNTT")
                    {
                        tabControl1.SelectedTab = tabPage3;
                        foreach (var i in qt)
                            lsbCNTT.Items.Add(i.MonHoc + ":" + i.Diem);
                    }
                    else if (ls[index].TenKhoa == "Văn")
                    {
                        tabControl1.SelectedTab = tabPage1;
                        foreach (var i in qt)
                            lstVan.Items.Add(i.MonHoc + ":" + i.Diem);
                    }
                    else if (ls[index].TenKhoa == "Vật lý")
                    {
                        tabControl1.SelectedTab = tabPage2;
                        foreach (var i in qt)
                            lsbVatLy.Items.Add(i.MonHoc + ":" + i.Diem);
                    }
                }
                else
                {
                    String key = txtTimKiem.Text;
                    ls = Student.TimKiem(key);
                    int index = listBox1.SelectedIndex;
                    lsbCNTT.Items.Clear();
                    lsbVatLy.Items.Clear();
                    lstVan.Items.Clear();
                    txtHoTen.Text = "";
                    ckbGioiTinh.Checked = false;
                    lblDTB.Text = "";
                    txtHoTen.Text = ls[index].HoTen;
                    if (ls[index].GioiTinh == SEX.Female)
                        ckbGioiTinh.Checked = false;
                    else if (ls[index].GioiTinh == SEX.Male)
                        ckbGioiTinh.Checked = true;
                    dtpNgaySinh.Value = ls[index].NgaySinh;
                    lblDTB.Text = Convert.ToString(QuaTrinhHocTap.DTB(ls[index].MaSV));
                    List<QuaTrinhHocTap> qt = QuaTrinhHocTap.GetList(ls[index].MaSV);
                    if (ls[index].TenKhoa == "CNTT")
                    {
                        tabControl1.SelectedTab = tabPage3;
                        foreach (var i in qt)
                            lsbCNTT.Items.Add(i.MonHoc + ":" + i.Diem);
                    }
                    else if (ls[index].TenKhoa == "Văn")
                    {
                        tabControl1.SelectedTab = tabPage1;
                        foreach (var i in qt)
                            lstVan.Items.Add(i.MonHoc + ":" + i.Diem);
                    }
                    else if (ls[index].TenKhoa == "Vật lý")
                    {
                        tabControl1.SelectedTab = tabPage2;
                        foreach (var i in qt)
                            lsbVatLy.Items.Add(i.MonHoc + ":" + i.Diem);
                    }
                }
            }
        }
        private void TsbCapNhat_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                String hoTen = txtHoTen.Text;
                if (hoTen == "")
                {
                    MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    int index = listBox1.SelectedIndex;
                    int s = listBox1.Items.Count;
                    var ls = Student.GetList();
                    SEX gioiTinh = new SEX();
                    if (ckbGioiTinh.Checked) gioiTinh = SEX.Male;
                    else gioiTinh = SEX.Female;
                    DateTime ngaySinh = dtpNgaySinh.Value;
                    if (ls.Count == s)
                    {
                        Student.Edit(new Student
                        {
                            MaSV = ls[index].MaSV,
                            HoTen = hoTen,
                            GioiTinh = gioiTinh,
                            NgaySinh = ngaySinh
                        });
                        listBox1.Items.Clear();
                        ls = Student.GetList();
                        foreach (var i in ls)
                        {
                            if (i.GioiTinh == SEX.Male)
                                listBox1.Items.Add("Anh " + i.HoTen);
                            else if (i.GioiTinh == SEX.Female)
                                listBox1.Items.Add("Chị " + i.HoTen);
                        }
                    }
                    else
                    {
                        String key = txtTimKiem.Text;
                        ls = Student.TimKiem(key);
                        Student.Edit(new Student
                        {
                            MaSV = ls[index].MaSV,
                            HoTen = hoTen,
                            GioiTinh = gioiTinh,
                            NgaySinh = ngaySinh
                        });
                        listBox1.Items.Clear();
                        ls = Student.GetList();
                        foreach (var i in ls)
                        {
                            if (i.GioiTinh == SEX.Male)
                                listBox1.Items.Add("Anh " + i.HoTen);
                            else if (i.GioiTinh == SEX.Female)
                                listBox1.Items.Add("Chị " + i.HoTen);
                        }
                        txtTimKiem.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void BổSungQTHTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                var ls = Student.GetList();
                frmChinhSuaQTHT f = new frmChinhSuaQTHT(ls[index].MaSV);
                f.ShowDialog();
                ls = Student.GetList();
                lsbCNTT.Items.Clear();
                lsbVatLy.Items.Clear();
                lstVan.Items.Clear();
                List<QuaTrinhHocTap> qt = QuaTrinhHocTap.GetList(ls[index].MaSV);
                if (ls[index].TenKhoa == "CNTT")
                {
                    tabControl1.SelectedTab = tabPage3;
                    foreach (var i in qt)
                        lsbCNTT.Items.Add(i.MonHoc + ":" + i.Diem);
                }
                else if (ls[index].TenKhoa == "Văn")
                {
                    tabControl1.SelectedTab = tabPage1;
                    foreach (var i in qt)
                        lstVan.Items.Add(i.MonHoc + ":" + i.Diem);
                }
                else if (ls[index].TenKhoa == "Vật lý")
                {
                    tabControl1.SelectedTab = tabPage2;
                    foreach (var i in qt)
                        lsbVatLy.Items.Add(i.MonHoc + ":" + i.Diem);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
        private void BổSungSinhViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmBoSung f = new frmBoSung();
            f.ShowDialog();
            listBox1.Items.Clear();
            lsbCNTT.Items.Clear();
            lsbVatLy.Items.Clear();
            lstVan.Items.Clear();
            txtHoTen.Text = "";
            ckbGioiTinh.Checked = false;
            lblDTB.Text = "";
            txtTimKiem.Text = "";
            var ls = Student.GetList();
            if (ls.Count > 0)
            {
                foreach (var i in ls)
                {
                    if (i.GioiTinh == SEX.Male)
                        listBox1.Items.Add("Anh " + i.HoTen);
                    else if (i.GioiTinh == SEX.Female)
                        listBox1.Items.Add("Chị " + i.HoTen);
                }
                txtHoTen.Text = ls[0].HoTen;
                if (ls[0].GioiTinh == SEX.Female)
                    ckbGioiTinh.Checked = false;
                else if (ls[0].GioiTinh == SEX.Male)
                    ckbGioiTinh.Checked = true;
                dtpNgaySinh.Value = ls[0].NgaySinh;
                lblDTB.Text = Convert.ToString(QuaTrinhHocTap.DTB(ls[0].MaSV));
                List<QuaTrinhHocTap> qt = QuaTrinhHocTap.GetList(ls[0].MaSV);
                if (ls[0].TenKhoa == "CNTT")
                {
                    tabControl1.SelectedTab = tabPage3;
                    foreach (var i in qt)
                        lsbCNTT.Items.Add(i.MonHoc + ":" + i.Diem);
                }
                else if (ls[0].TenKhoa == "Văn")
                {
                    tabControl1.SelectedTab = tabPage1;
                    foreach (var i in qt)
                        lstVan.Items.Add(i.MonHoc + ":" + i.Diem);
                }
                else if (ls[0].TenKhoa == "Vật lý")
                {
                    tabControl1.SelectedTab = tabPage2;
                    foreach (var i in qt)
                        lsbVatLy.Items.Add(i.MonHoc + ":" + i.Diem);
                }
            }
        }
    }
}
