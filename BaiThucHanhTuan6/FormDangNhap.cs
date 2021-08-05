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
    public partial class frmDangNhap : Form
    {
        QLNHASACHEntities qLNHASACH = new QLNHASACHEntities();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            var query = qLNHASACH.NHANVIENs.Where(x => x.UserName == tenDangNhap && x.Password == matKhau).SingleOrDefault();
            if (tenDangNhap.Trim().Length == 0)
            {
                errorProvider1.SetError(txtTenDangNhap, "Phải nhập tên đăng nhập");
                return;
            }
            errorProvider1.Clear();
            if (matKhau.Trim().Length == 0)
            {
                errorProvider1.SetError(txtMatKhau, "Phải nhập mật khẩu");
                return;
            }
            errorProvider1.Clear();
            if (query == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
                txtMatKhau.Clear();
                return;
            }
            frmMain frmMain = (frmMain)this.MdiParent;
            frmMain.Enabled(1);
            frmMain.taiKhoan = tenDangNhap;
            MessageBox.Show("Đăng nhập thành công", "Thông báo");
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}
