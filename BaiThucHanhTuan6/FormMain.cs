using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhTuan6
{
    public partial class frmMain : Form
    {
        public string taiKhoan;
        frmDoiMatKhau frmDoiMatKhau;
        public frmMain()
        {
            InitializeComponent();
        }
        public void Enabled(int a)
        {
            if (a == 1)
            {
                mnQuanLySach.Enabled = true;
                mniDangXuat.Enabled = true;
                mniDoiMatKhau.Enabled = true;
            }
            else
            {
                mnQuanLySach.Enabled = false;
                mniDangXuat.Enabled = false;
                mniDoiMatKhau.Enabled = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Enabled(0);
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.Show();
        }

        private void mniThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mniDangXuat_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            frmMain_Load(sender, e);
        }

        private void mniDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (frmDoiMatKhau == null)
            {
                frmDoiMatKhau = new frmDoiMatKhau();
                frmDoiMatKhau.MdiParent = this;
                frmDoiMatKhau.Show();
            }
            else
            {
                frmDoiMatKhau.Activate();
                frmDoiMatKhau.Show();
            }
        }
    }
}
