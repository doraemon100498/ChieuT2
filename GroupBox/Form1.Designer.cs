namespace GroupBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.tsdBoSung = new System.Windows.Forms.ToolStripDropDownButton();
            this.bổSungSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bổSungQTHTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.tsbCapNhat = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDTB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstVan = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lsbVatLy = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lsbCNTT = new System.Windows.Forms.ListBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbGioiTinh = new System.Windows.Forms.CheckBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtTimKiem,
            this.tsdBoSung,
            this.tsbXoa,
            this.tsbCapNhat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 25);
            this.toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(278, 28);
            this.txtTimKiem.Click += new System.EventHandler(this.TxtTimKiem_Click);
            // 
            // tsdBoSung
            // 
            this.tsdBoSung.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsdBoSung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bổSungSinhViênToolStripMenuItem,
            this.bổSungQTHTToolStripMenuItem});
            this.tsdBoSung.Image = ((System.Drawing.Image)(resources.GetObject("tsdBoSung.Image")));
            this.tsdBoSung.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsdBoSung.Name = "tsdBoSung";
            this.tsdBoSung.Size = new System.Drawing.Size(79, 25);
            this.tsdBoSung.Text = "Bổ sung";
            // 
            // bổSungSinhViênToolStripMenuItem
            // 
            this.bổSungSinhViênToolStripMenuItem.Image = global::GroupBox.Properties.Resources.people;
            this.bổSungSinhViênToolStripMenuItem.Name = "bổSungSinhViênToolStripMenuItem";
            this.bổSungSinhViênToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.bổSungSinhViênToolStripMenuItem.Text = "Bổ sung sinh viên";
            this.bổSungSinhViênToolStripMenuItem.Click += new System.EventHandler(this.BổSungSinhViênToolStripMenuItem_Click_1);
            // 
            // bổSungQTHTToolStripMenuItem
            // 
            this.bổSungQTHTToolStripMenuItem.Image = global::GroupBox.Properties.Resources.book;
            this.bổSungQTHTToolStripMenuItem.Name = "bổSungQTHTToolStripMenuItem";
            this.bổSungQTHTToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.bổSungQTHTToolStripMenuItem.Text = "Bổ sung QTHT";
            this.bổSungQTHTToolStripMenuItem.Click += new System.EventHandler(this.BổSungQTHTToolStripMenuItem_Click);
            // 
            // tsbXoa
            // 
            this.tsbXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbXoa.Image")));
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Size = new System.Drawing.Size(40, 25);
            this.tsbXoa.Text = "Xóa";
            this.tsbXoa.Click += new System.EventHandler(this.TsbXoa_Click);
            // 
            // tsbCapNhat
            // 
            this.tsbCapNhat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("tsbCapNhat.Image")));
            this.tsbCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCapNhat.Name = "tsbCapNhat";
            this.tsbCapNhat.Size = new System.Drawing.Size(76, 25);
            this.tsbCapNhat.Text = "Cập nhật";
            this.tsbCapNhat.Click += new System.EventHandler(this.TsbCapNhat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 439);
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 439);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(366, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 439);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.lblDTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ckbGioiTinh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(48, 411);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(18, 20);
            this.lblDTB.TabIndex = 7;
            this.lblDTB.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "DTB:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 192);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(415, 211);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstVan);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Văn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstVan
            // 
            this.lstVan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVan.FormattingEnabled = true;
            this.lstVan.ItemHeight = 20;
            this.lstVan.Location = new System.Drawing.Point(3, 3);
            this.lstVan.Name = "lstVan";
            this.lstVan.Size = new System.Drawing.Size(401, 172);
            this.lstVan.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lsbVatLy);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 178);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vật lý";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lsbVatLy
            // 
            this.lsbVatLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbVatLy.FormattingEnabled = true;
            this.lsbVatLy.ItemHeight = 20;
            this.lsbVatLy.Location = new System.Drawing.Point(3, 3);
            this.lsbVatLy.Name = "lsbVatLy";
            this.lsbVatLy.Size = new System.Drawing.Size(401, 172);
            this.lsbVatLy.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lsbCNTT);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(407, 178);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CNTT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lsbCNTT
            // 
            this.lsbCNTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbCNTT.FormattingEnabled = true;
            this.lsbCNTT.ItemHeight = 20;
            this.lsbCNTT.Location = new System.Drawing.Point(3, 3);
            this.lsbCNTT.Name = "lsbCNTT";
            this.lsbCNTT.Size = new System.Drawing.Size(401, 172);
            this.lsbCNTT.TabIndex = 0;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(13, 152);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2011, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(187, 26);
            this.dtpNgaySinh.TabIndex = 4;
            this.dtpNgaySinh.Value = new System.DateTime(2011, 12, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày sinh";
            // 
            // ckbGioiTinh
            // 
            this.ckbGioiTinh.AutoSize = true;
            this.ckbGioiTinh.Checked = true;
            this.ckbGioiTinh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbGioiTinh.Location = new System.Drawing.Point(13, 90);
            this.ckbGioiTinh.Name = "ckbGioiTinh";
            this.ckbGioiTinh.Size = new System.Drawing.Size(121, 24);
            this.ckbGioiTinh.TabIndex = 2;
            this.ckbGioiTinh.Text = "Giới tính nam";
            this.ckbGioiTinh.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(13, 55);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(287, 26);
            this.txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên - Nguyễn Thị Như Ý";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lstVan;
        private System.Windows.Forms.ListBox lsbVatLy;
        private System.Windows.Forms.ListBox lsbCNTT;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripButton tsbCapNhat;
        private System.Windows.Forms.ToolStripDropDownButton tsdBoSung;
        private System.Windows.Forms.ToolStripMenuItem bổSungSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bổSungQTHTToolStripMenuItem;
    }
}

