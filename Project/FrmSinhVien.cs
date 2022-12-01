using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FrmSinhVien : Form
    {
        public FrmSinhVien(string msv)
        {
            this.msv = msv;
            //truyền lại mã sinh viên khi form chạy
            InitializeComponent();
        }
        private string msv;
        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))//nếu msv không có => thêm mới sinh viên
            {
                this.Text = "Thêm mới sinh viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin sinh viên";
                //lấy thông tin chi tiết của 1 sinh viên dựa vào msv
                //msv là mã sinh viên đã được truyền từ form dssv (part 4)
                var r = new Database().Select("selectSV '" + msv + "'");
                //MessageBox.Show(r[0].ToString()); //load thành công
                //set các giá trị vào component của form

                txtho.Text = r["ho"].ToString();
                txttendem.Text = r["tendem"].ToString();
                txtten.Text = r["ten"].ToString();
                txtngaysinh.Text = r["ngsinh"].ToString();
                if (int.Parse(r["gioitinh"].ToString()) == 1)
                {
                    txtnam.Checked = true;
                }
                else
                {
                    txtnu.Checked = true;
                }

                txtquequan.Text = r["quequan"].ToString();
                txtdiachi.Text = r["diachi"].ToString();
                txtdienthoai.Text = r["dienthoai"].ToString();
                txtemail.Text = r["email"].ToString();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // button luu xu ly  1 trong 2 tinh huong

            string sql = "";
            string ho = txtho.Text;
            string tendem = txttendem.Text;
            string ten = txtten.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(txtngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ngày sinh không hợp lệ" +ex.Message);
                txtngaysinh.Select();
                return;
            }

            string gioitinh = txtnam.Checked ? "1" : "0";
            string quequan = txtquequan.Text;
            string diachi = txtdiachi.Text;
            string dienthoai = txtdienthoai.Text;
            string email = txtemail.Text;

            // khai bao một danh sach tham so = class  cus
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv)) // them sinh vien
            {
                sql = "ThemMoiSv"; // gọi toi them moi sinh vien
            }
            else //nếu cật nhật sinh viên
            {
                sql = "updateSV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@masinhvien",
                    value = msv
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@ho",
                value = ho
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@tendem",
                value = tendem
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ten",
                value = ten
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@gioitinh",
                value = gioitinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@quequan",
                value = quequan
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@diachi",
                value = diachi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@dienthoai",
                value = dienthoai
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@email",
                value = email
            });

            var rs = new Database().ExeCute(sql, lstPara);// truyen 2 tham so
            if (rs == 1) // thuc hien thanh cong
            {
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
                }

                else
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                this.Dispose();
            }
            else //nêu khong thanh cong
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
