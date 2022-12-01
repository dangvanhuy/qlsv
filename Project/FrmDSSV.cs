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
    public partial class FrmDSSV : Form
    {
        public FrmDSSV()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void FrmDSSV_Load(object sender, EventArgs e)
        {
          LoadDSSV();// goi toi ham loaddssv
        }

        private void LoadDSSV()
        { 
            //khai bao list
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            }) ;
         
            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhvien",lstPara);
            //dat ten cot
            dgvSinhVien.Columns["masinhvien"].HeaderText = "Mã SV";
            dgvSinhVien.Columns["hoten"].HeaderText = "Họ Tên";
            dgvSinhVien.Columns["nsinh"].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns["gt"].HeaderText = "Giới tính";
            dgvSinhVien.Columns["quequan"].HeaderText = "Quê quán";
            dgvSinhVien.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện thoại";
        }
        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                var msv = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                //  truyen 
                new FrmSinhVien(msv).ShowDialog();
                // cần load danh sách
                LoadDSSV();
            }
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            new FrmSinhVien(null).ShowDialog();
            LoadDSSV();// load lại danh sach khi them thanh cong
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            LoadDSSV();
        }

        private void txttukhoa_TextChanged(object sender, EventArgs e)
        {
            tukhoa = txttukhoa.Text;
        }
    }
}
