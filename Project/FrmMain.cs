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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("bạn chắc chắn thoát chứ ? ",
                           "Exit",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                this.Show();
            }
        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSSV f =new FrmDSSV();
            AddFrom(f);
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmmh f = new Frmmh();
            AddFrom(f);
        }

        private void giaoVienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDSGV f = new frmDSGV();
            AddFrom(f);
        }

        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Frmdvlophoc f = new Frmdvlophoc();
            AddFrom(f);
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
        private string taikhoan;
        private string loaitk;
        private void FrmMain_Load(object sender, EventArgs e)


        {
            var fn = new Frmdangnhap();
            fn.ShowDialog();
            taikhoan = fn.tendangnhap;
            MessageBox.Show("Tài khoản đăng nhập thành công là :" + taikhoan);
            loaitk = fn.loaitk;
            if (loaitk.Equals("admin"))
            {
                //nếu là admin
                //ẩn 2 menu chấm điểm và đăng ký môn học
                //chỉ để lại menu quản lý
                chamDiemToolStripMenuItem.Visible = false;
                chucNangToolStripMenuItem.Visible = false;
            }
            else
            {
                //nếu không phải admin thì ẩn menu quản lý
                quanLyToolStripMenuItem.Visible = false;
                if (loaitk.Equals("gv"))//nếu là giáo viên
                {
                    //ẩn menu đăng ký học -> cái này chỉ dành riêng cho sinh viên
                    chucNangToolStripMenuItem.Visible = false;

                }
                else//chỉ còn lại trường hợp là sinh viên
                {
                    chamDiemToolStripMenuItem.Visible = false;//ẩn menu chấm điểm<-chức năng của gv
                }
            }
            FrmWelcom f = new FrmWelcom();   
            AddFrom(f);
        }
        private void AddFrom(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            this.Text = f.Text;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frmmonhocdadangkics(taikhoan);
            AddFrom(f);

        }

        private void traCuuDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmKqhoctap(taikhoan);//truyền tài khoản đăng nhập  = mã sinh viên
            AddFrom(f);
        }

        private void chamDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmDSSV();//truyền tài khoản đăng nhập  = mã sinh viên
            AddFrom(f);
        }
    }
}
