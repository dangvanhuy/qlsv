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
    public partial class FrmGV : Form
    {
        public FrmGV(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }
        private string mgv;
        private string nguoithucthi = "admin";
        private void FrmGV_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm mới giáo viên";
            }
            else
            {
                this.Text = "Cập nhật giáo viên";
                var r  = new Database().Select("selectGV '" + int.Parse(mgv)+ "'");
                txtho.Text = r["ho"].ToString();
                txtdem.Text = r["tendem"].ToString();
                txtten.Text = r["ten"].ToString();
                txtnam.Checked = r["gioitinh"].ToString()== "1" ?  true : false;
                txtngaysinh.Text = r["ngsinh"].ToString();
                txtdiachi.Text = r["diachi"].ToString();
                txtdienthoai.Text = r["dienthoai"].ToString();
                txtemail.Text = r["email"].ToString();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql = "";
            DateTime ngaysinh;
            List<CustomParameter> lstPara = new List<CustomParameter>(); 
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
            if (string.IsNullOrEmpty(mgv))
            {
                sql = "InsertGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithucthi,
                });
            }
            else
            {
                sql = "updateGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithucthi,
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@magiaovien",
                    value = mgv,
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@ho",
                    value = txtho.Text,
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@tendem",
                    value = txtdem.Text,
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@ten",
                    value = txtten.Text,
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@ngaysinh",
                    value = ngaysinh.ToString("yyyy-MM-dd"),
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@gioitinh",
                    value = txtnam.Checked? "1" : "0",
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@email",
                    value = txtemail.Text,
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@dienthoai",
                    value = txtdienthoai.Text,
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@diachi",
                    value = txtdiachi.Text,
                });

                var rs = new  Database().ExeCute(sql,lstPara);
                if(rs == 1)
                {
                    if( string.IsNullOrEmpty(mgv))
                    {
                        MessageBox.Show("Thêm mới giáo viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("cập nhật mới giáo viên thành công");
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("cập nhật mới giáo viên không thành công");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
