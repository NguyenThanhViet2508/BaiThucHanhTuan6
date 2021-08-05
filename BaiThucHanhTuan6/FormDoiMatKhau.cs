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
    public partial class frmDoiMatKhau : Form
    {
        QLNHASACHEntities qLNHASACH = new QLNHASACHEntities();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text.Length < 6 || !txtMatKhauMoi.Text.Any(char.IsDigit)
                || !txtMatKhauMoi.Text.Any(char.IsLower) || !txtMatKhauMoi.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txtMatKhauMoi, "Mật khẩu mới phải tối thiểu 6 kí tự, gồm số chữ, chữ in hoa và in thường");
                return;
            }
            errorProvider1.Clear();
            if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng", "Thông báo");
                return;
            }
            frmMain frmMain = (frmMain)this.MdiParent;
            var query = qLNHASACH.NHANVIENs.SingleOrDefault(x => x.UserName == frmMain.taiKhoan);
            query.Password = txtMatKhauMoi.Text;
            qLNHASACH.SaveChanges();
            if (query == null)
            {
                MessageBox.Show("Mật khẩu không hợp lệ", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
