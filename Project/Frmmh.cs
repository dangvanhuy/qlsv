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
    public partial class Frmmh : Form
    {
        public Frmmh()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Frmmonhoc(null).ShowDialog();
            LoadDSMH();
        }

        private void dgvmh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mamh = dgvmh.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                new Frmmonhoc(mamh).ShowDialog();
                LoadDSMH();
            }
        }
        private string tukhoa = "";
        private void LoadDSMH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvmh.DataSource = new Database().SelectData("selectAllMonHoc", lstPara);
        }

        private void Frmmh_Load(object sender, EventArgs e)
        {
            //custom column trong sql qua windowns
            LoadDSMH();
            dgvmh.Columns["mamonhoc"].HeaderText = "Mã MH";
            dgvmh.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvmh.Columns["sotinchi"].HeaderText = "Số TC";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            // khai báo từ khóa 
            tukhoa = txttukhoa.Text;
            LoadDSMH();
        }

        private void txttukhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
