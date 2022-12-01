namespace Project
{
    partial class FrmGV
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
            this.txtnu = new System.Windows.Forms.RadioButton();
            this.txtngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtdem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(78, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ";
            // 
            // txtho
            // 
            this.txtho.Location = new System.Drawing.Point(189, 77);
            this.txtho.Multiline = true;
            this.txtho.Name = "txtho";
            this.txtho.Size = new System.Drawing.Size(190, 29);
            this.txtho.TabIndex = 1;
            // 
            // txtnam
            // 
            this.txtnam.AutoSize = true;
            this.txtnam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtnam.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnam.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtnam.Location = new System.Drawing.Point(207, 229);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(67, 23);
            this.txtnam.TabIndex = 2;
            this.txtnam.Text = "Nam";
            this.txtnam.UseVisualStyleBackColor = true;
            // 
            // txtnu
            // 
            this.txtnu.AutoSize = true;
            this.txtnu.Checked = true;
            this.txtnu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtnu.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtnu.Location = new System.Drawing.Point(305, 230);
            this.txtnu.Name = "txtnu";
            this.txtnu.Size = new System.Drawing.Size(52, 23);
            this.txtnu.TabIndex = 3;
            this.txtnu.TabStop = true;
            this.txtnu.Text = "Nữ";
            this.txtnu.UseVisualStyleBackColor = true;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(200, 284);
            this.txtngaysinh.Mask = "00/00/0000";
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(119, 22);
            this.txtngaysinh.TabIndex = 4;
            this.txtngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(78, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Đệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(78, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(78, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới tính";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(189, 169);
            this.txtten.Multiline = true;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(190, 32);
            this.txtten.TabIndex = 8;
            // 
            // txtdem
            // 
            this.txtdem.Location = new System.Drawing.Point(189, 124);
            this.txtdem.Multiline = true;
            this.txtdem.Name = "txtdem";
            this.txtdem.Size = new System.Drawing.Size(190, 30);
            this.txtdem.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(78, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày sinh";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(78, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(78, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(81, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Địa chỉ";
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(189, 321);
            this.txtdienthoai.Multiline = true;
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(190, 31);
            this.txtdienthoai.TabIndex = 14;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(189, 369);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(190, 33);
            this.txtemail.TabIndex = 15;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(189, 426);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(190, 35);
            this.txtdiachi.TabIndex = 16;
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.Gold;
            this.btnluu.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnluu.Location = new System.Drawing.Point(127, 493);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(97, 40);
            this.btnluu.TabIndex = 17;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Gold;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(285, 493);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(94, 40);
            this.btnhuy.TabIndex = 18;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            // 
            // FrmGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(546, 577);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdem);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.txtnu);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtho);
            this.Controls.Add(this.label1);
            this.Name = "FrmGV";
            this.Text = "Thêm giáo viên";
            this.Load += new System.EventHandler(this.FrmGV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtho;
        private System.Windows.Forms.RadioButton txtnam;
        private System.Windows.Forms.RadioButton txtnu;
        private System.Windows.Forms.MaskedTextBox txtngaysinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtdem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
    }
}