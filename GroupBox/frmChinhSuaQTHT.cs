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
    public partial class frmChinhSuaQTHT : Form
    {
        String maSV;
        public frmChinhSuaQTHT(String maSV)
        {
            InitializeComponent();
            this.maSV = maSV;
        }
        private void FrmChinhSuaQTHT_Load(object sender, EventArgs e)
        {
            var s = Student.GetStudent(maSV);
            txtMaSV.Text = maSV;
            txtHoTen.Text = s.HoTen;
            var qt = QuaTrinhHocTap.GetList(maSV);
            foreach(var i in qt)
            {
                dgvQTHT.Rows.Add(i.MaQTHT,i.MonHoc, i.Diem);
            }          
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            String monHoc = txtMonHoc.Text;
            erp.Clear();
            if (monHoc == "")
            {
                erp.SetError(txtMonHoc, "Vui lòng nhập môn học!");
                txtMonHoc.Focus();
                return;
            }
            else if (QuaTrinhHocTap.KT(monHoc))
            {
                erp.SetError(txtMonHoc, "Môn học đã tồn tại!");
                txtMonHoc.Focus();
                return;
            }
            else if (txtDiemThi.Text == "")
            {
                erp.SetError(txtDiemThi, "Vui lòng nhập điểm thi!");
                txtDiemThi.Focus();
                return;
            }
            else
            {
                try {
                    long diemThi = Convert.ToInt64(txtDiemThi.Text);
                    if (diemThi < 0 || diemThi > 10)
                    {
                        erp.SetError(txtDiemThi, "Điểm thi phải lớn hơn 0 và nhỏ hơn 10!");
                        txtDiemThi.Focus();
                        return;
                    }
                    else
                    {
                        String maQTHT = QuaTrinhHocTap.TaoMaSV();
                        QuaTrinhHocTap.Them(new QuaTrinhHocTap
                        {
                            MaQTHT = maQTHT,
                            MonHoc = monHoc,
                            Diem = diemThi,
                            MaSV = maSV
                        });
                        dgvQTHT.Rows.Add(maQTHT, monHoc, diemThi);
                        txtMonHoc.Text = "";
                        txtDiemThi.Text = "";
                        erp.Clear();
                    }
                }catch(Exception ex)
                {
                    erp.SetError(txtDiemThi, "Điểm thi phải là một số!");
                    txtDiemThi.Focus();
                    return;
                }
            }
        }
        private void DgvQTHT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                erp.Clear();
                if (dgvQTHT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    String maQTHT = dgvQTHT.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    if (maQTHT != null)
                    {
                        var qt = QuaTrinhHocTap.GetQTHT(maQTHT);
                        txtMonHoc.Text = qt.MonHoc;
                        txtDiemThi.Text = qt.Diem.ToString();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                erp.Clear();
                int hanghientai = dgvQTHT.CurrentCell.RowIndex;
                String maQTHT = dgvQTHT.Rows[hanghientai].Cells[0].Value.ToString();
                if (maQTHT != null)
                {
                    if (MessageBox.Show("Bạn có thực sự muốn xóa môn học này?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                    {
                        dgvQTHT.Rows.RemoveAt(dgvQTHT.CurrentCell.RowIndex);
                        QuaTrinhHocTap.Remove(maQTHT);
                        txtMonHoc.Text = "";
                        txtDiemThi.Text = "";
                    }                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn môn học để xóa!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int hanghientai = dgvQTHT.CurrentCell.RowIndex;
                String maQTHT = dgvQTHT.Rows[hanghientai].Cells[0].Value.ToString();
                if (maQTHT != null)
                {
                    String monHoc = txtMonHoc.Text;
                    if (monHoc == "")
                    {
                        erp.SetError(txtMonHoc, "Vui lòng nhập môn học!");
                        txtMonHoc.Focus();
                        return;
                    }
                    else if (!QuaTrinhHocTap.KT(monHoc))
                    {
                        erp.SetError(txtMonHoc, "Môn học không tồn tại!");
                        txtMonHoc.Focus();
                        return;
                    }
                    else if (txtDiemThi.Text == "")
                    {
                        erp.SetError(txtDiemThi, "Vui lòng nhập điểm thi!");
                        txtDiemThi.Focus();
                        return;
                    }
                    try
                    {
                        long diemThi = Convert.ToInt64(txtDiemThi.Text);
                           QuaTrinhHocTap.Edit(new QuaTrinhHocTap
                            {
                                MaQTHT=maQTHT,
                                MonHoc=monHoc,
                                Diem=diemThi,
                                MaSV=maSV
                            });
                            dgvQTHT.Rows[hanghientai].Cells[2].Value = txtDiemThi.Text;
                            erp.Clear();
                    }
                    catch (Exception ex)
                    {
                        erp.SetError(txtDiemThi, "Điểm thi phải là một số!");
                        txtDiemThi.Focus();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn môn học để sửa!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
