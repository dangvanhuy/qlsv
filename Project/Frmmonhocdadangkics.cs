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
    public partial class Frmmonhocdadangkics : Form
    {
        private string masv;
        public Frmmonhocdadangkics(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }


        private void LoadMonDky()
        {
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@masinhvien",
                    value = masv
                }
            };
            dgvDSMHDky.DataSource = new Database().SelectData("monDaDKy", lst);
        }

        private void Frmmonhocdadangkics_Load(object sender, EventArgs e)
        {
            LoadMonDky();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnDkyMoi_Click(object sender, EventArgs e)
        {
            new Frmdsmh(masv).ShowDialog();
            LoadMonDky();
        }

        private void dgvDSMHDky_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
