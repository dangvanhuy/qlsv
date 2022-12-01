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
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            
            loadDSGV();
            }
        private string tukhoa = "";
        private void loadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa,
            });
            dgvDSGV.DataSource = new Database().SelectData(sql,lstPara);   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var mgv = dgvDSGV.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                new FrmGV(mgv).ShowDialog();
                loadDSGV();
            }
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            loadDSGV();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tukhoa = txttukhoa.Text;
           
        }
    }
}
