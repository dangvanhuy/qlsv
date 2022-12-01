namespace Project
{
    partial class FrmSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtho = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttendem = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtnu = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.txtngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(71, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ";
            // 
            // txtho
            // 
            this.txtho.Location = new System.Drawing.Point(201, 41);
            this.txtho.Multiline = true;
            this.txtho.Name = "txtho";
            this.txtho.Size = new System.Drawing.Size(234, 33);
            this.txtho.TabIndex = 1;
            // 
            // txtnam
            // 
            this.txtnam.AutoSize = true;
            this.txtnam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtnam.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnam.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtnam.Location = new System.Drawing.Point(201, 260);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(67, 23);
            this.txtnam.TabIndex = 2;
            this.txtnam.TabStop = true;
            this.txtnam.Text = "Nam";
            this.txtnam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(71, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Đệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(71, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(66, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày sinh";
            // 
            // txttendem
            // 
            this.txttendem.Location = new System.Drawing.Point(201, 93);
            this.txttendem.Multiline = true;
            this.txttendem.Name = "txttendem";
            this.txttendem.Size = new System.Drawing.Size(234, 30);
            this.txttendem.TabIndex = 6;
            this.txttendem.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(201, 147);
            this.txtten.Multiline = true;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(234, 35);
            this.txtten.TabIndex = 7;
            // 
            // txtnu
            // 
            this.txtnu.AutoSize = true;
            this.txtnu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtnu.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtnu.Location = new System.Drawing.Point(337, 260);
            this.txtnu.Name = "txtnu";
            this.txtnu.Size = new System.Drawing.Size(52, 23);
            this.txtnu.TabIndex = 9;
            this.txtnu.TabStop = true;
            this.txtnu.Text = "Nữ";
            this.txtnu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(66, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giới tính";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(201, 354);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(234, 41);
            this.txtdiachi.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(66, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Địa chỉ";
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(201, 303);
            this.txtquequan.Multiline = true;
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(234, 35);
            this.txtquequan.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(66, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quê quán";
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(201, 493);
            this.txtdienthoai.Multiline = true;
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(234, 41);
            this.txtdienthoai.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(66, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Điện thoại";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(201, 416);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(234, 42);
            this.txtemail.TabIndex = 16;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(71, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email";
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.Gold;
            this.btnluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluu.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(163, 578);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(105, 48);
            this.btnluu.TabIndex = 19;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Gold;
            this.btnhuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(356, 578);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(108, 48);
            this.btnhuy.TabIndex = 20;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(201, 206);
            this.txtngaysinh.Mask = "00/00/0000";
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(100, 22);
            this.txtngaysinh.TabIndex = 21;
            this.txtngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(546, 638);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtquequan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnu);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txttendem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtho);
            this.Controls.Add(this.label1);
            this.Name = "FrmSinhVien";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm sinh viên";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtho;
        private System.Windows.Forms.RadioButton txtnam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttendem;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.RadioButton txtnu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.MaskedTextBox txtngaysinh;
    }
}