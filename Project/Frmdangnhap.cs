using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Frmdangnhap : Form
    {
        public Frmdangnhap()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaitk;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            tendangnhap = txtTendangnhap.Text;
            loaitk = "";

            #region swtk
            switch (cbbLoaiTaiKhoan.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                    break;
                case "Giáo viên":
                    loaitk = "gv";
                    break;
                case "Sinh viên":
                    loaitk = "sv";
                    break;
            }
            #endregion


            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@loaitaikhoan",
                    value=loaitk
                },
                 new CustomParameter()
                {
                    key = "@taikhoan",
                    value=txtTendangnhap.Text
                },
                  new CustomParameter()
                {
                    key = "@matkhau",
                    value=txtMatkhau.Text
                },
            };

            var rs = new Database().SelectData("dangnhap", lst);
            if (rs.Rows.Count > 0)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu", "Tài khoản hoặc mật khẩu không hợp lệ");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtTendangnhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
