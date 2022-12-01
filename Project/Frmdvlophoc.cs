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
    public partial class Frmdvlophoc : Form
    {
        public Frmdvlophoc()
        {
            InitializeComponent();
        }

        private void Frmdvlophoc_Load(object sender, EventArgs e)
        {
            loadDSLH();
        }

        private void dgvLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //new frm(dgvLopHoc.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()).ShowDialog();
                loadDSLH();
            }

        }
        private string tukhoa = "";
        private void loadDSLH()
        {
            string sql = "allLopHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = tukhoa
                }
            };
            dgvLopHoc.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            loadDSLH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new FrmLopHoc(null).ShowDialog();
            loadDSLH();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
