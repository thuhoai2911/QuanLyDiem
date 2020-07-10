﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
        private void hệĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHeDaoTao f1 = new FrmHeDaoTao();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void dânTộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanToc f2 = new FrmDanToc();
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.Show();     
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLop f3 = new FrmLop();
            f3.StartPosition = FormStartPosition.CenterScreen;
            f3.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSinhVien f5 = new FrmSinhVien();
            f5.StartPosition = FormStartPosition.CenterScreen;
            f5.Show();
        }

        private void chuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChuyenNganh f6 = new FrmChuyenNganh();
            f6.StartPosition = FormStartPosition.CenterScreen;
            f6.Show();
        }

        private void thờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThoiKhoaBieu f7 = new FrmThoiKhoaBieu();
            f7.StartPosition = FormStartPosition.CenterScreen;
            f7.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhoa f8 = new FrmKhoa();
            f8.StartPosition = FormStartPosition.CenterScreen;
            f8.Show();
        }

        private void quêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQue f9 = new FrmQue();
            f9.StartPosition = FormStartPosition.CenterScreen;
            f9.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChucVu f10 = new FrmChucVu();
            f10.StartPosition = FormStartPosition.CenterScreen;
            f10.Show();
        }

        private void phòngHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhongHoc f14 = new FrmPhongHoc();
            f14.StartPosition = FormStartPosition.CenterScreen;
            f14.Show();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiem f15 = new FrmTimKiem();
            f15.StartPosition = FormStartPosition.CenterScreen;
            f15.Show();
        }

        private void bảngĐiểmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInBangDiemSV f17 = new FrmInBangDiemSV();
            f17.StartPosition = FormStartPosition.CenterScreen;
            f17.Show();
        }

        private void thờiKhóaBiểuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInTKB f18 = new FrmInTKB();
            f18.StartPosition = FormStartPosition.CenterScreen;
            f18.Show();
        }

        private void mônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMonHoc f12 = new FrmMonHoc();
            f12.StartPosition = FormStartPosition.CenterScreen;
            f12.Show();
        }

        private void lớpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmLop f4 = new FrmLop();
            f4.StartPosition = FormStartPosition.CenterScreen;
            f4.Show();
        }

        private void cậpNhậtĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiem f2 = new FrmDiem();
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMonHoc f3 = new FrmMonHoc();
            f3.StartPosition = FormStartPosition.CenterScreen;
            f3.Show();
        }
    }
}
