namespace Project
{
    partial class Frmmonhocdadangkics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDkyMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSMHDky = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHDky)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDkyMoi
            // 
            this.btnDkyMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDkyMoi.BackColor = System.Drawing.Color.Brown;
            this.btnDkyMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDkyMoi.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDkyMoi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDkyMoi.Location = new System.Drawing.Point(1209, 51);
            this.btnDkyMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnDkyMoi.Name = "btnDkyMoi";
            this.btnDkyMoi.Size = new System.Drawing.Size(132, 44);
            this.btnDkyMoi.TabIndex = 7;
            this.btnDkyMoi.Text = "Đăng ký mới";
            this.btnDkyMoi.UseVisualStyleBackColor = false;
            this.btnDkyMoi.Click += new System.EventHandler(this.btnDkyMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.Brown;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimKiem.Location = new System.Drawing.Point(1066, 51);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(126, 44);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimkiem.Location = new System.Drawing.Point(707, 57);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(321, 38);
            this.txtTimkiem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ khóa";
            // 
            // dgvDSMHDky
            // 
            this.dgvDSMHDky.AllowUserToAddRows = false;
            this.dgvDSMHDky.AllowUserToDeleteRows = false;
            this.dgvDSMHDky.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSMHDky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMHDky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMHDky.Location = new System.Drawing.Point(-30, 119);
            this.dgvDSMHDky.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSMHDky.MultiSelect = false;
            this.dgvDSMHDky.Name = "dgvDSMHDky";
            this.dgvDSMHDky.ReadOnly = true;
            this.dgvDSMHDky.RowHeadersWidth = 51;
            this.dgvDSMHDky.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMHDky.Size = new System.Drawing.Size(1459, 473);
            this.dgvDSMHDky.TabIndex = 4;
            this.dgvDSMHDky.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMHDky_CellContentClick);
            // 
            // Frmmonhocdadangkics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 674);
            this.Controls.Add(this.btnDkyMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSMHDky);
            this.Name = "Frmmonhocdadangkics";
            this.Text = "Danh sách môn học đã đăng ký";
            this.Load += new System.EventHandler(this.Frmmonhocdadangkics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHDky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDkyMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSMHDky;
    }
}