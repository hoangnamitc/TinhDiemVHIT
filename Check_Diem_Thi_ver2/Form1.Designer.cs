namespace Check_Diem_Thi_ver2
{
    partial class frmCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheck));
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblinfomation = new System.Windows.Forms.Label();
            this.lblquatrinh = new System.Windows.Forms.Label();
            this.txtquatrinh = new System.Windows.Forms.TextBox();
            this.lbldiemthi = new System.Windows.Forms.Label();
            this.txtdiemthi = new System.Windows.Forms.TextBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.lbldiemso = new System.Windows.Forms.Label();
            this.lbldiemthishow = new System.Windows.Forms.Label();
            this.lbldiemchu = new System.Windows.Forms.Label();
            this.lbldiemchushow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Red;
            this.lbltitle.Location = new System.Drawing.Point(20, 8);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(341, 37);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "KIỂM TRA ĐIỂM THI ";
            // 
            // lblinfomation
            // 
            this.lblinfomation.AutoSize = true;
            this.lblinfomation.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfomation.ForeColor = System.Drawing.Color.Teal;
            this.lblinfomation.Location = new System.Drawing.Point(21, 54);
            this.lblinfomation.Name = "lblinfomation";
            this.lblinfomation.Size = new System.Drawing.Size(327, 23);
            this.lblinfomation.TabIndex = 1;
            this.lblinfomation.Text = "Mời bạn nhập vào các thông tin sau:";
            // 
            // lblquatrinh
            // 
            this.lblquatrinh.AutoSize = true;
            this.lblquatrinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquatrinh.ForeColor = System.Drawing.Color.Blue;
            this.lblquatrinh.Location = new System.Drawing.Point(11, 109);
            this.lblquatrinh.Name = "lblquatrinh";
            this.lblquatrinh.Size = new System.Drawing.Size(139, 22);
            this.lblquatrinh.TabIndex = 2;
            this.lblquatrinh.Text = "Điểm quá trình:";
            // 
            // txtquatrinh
            // 
            this.txtquatrinh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquatrinh.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtquatrinh.Location = new System.Drawing.Point(147, 105);
            this.txtquatrinh.MaxLength = 4;
            this.txtquatrinh.Name = "txtquatrinh";
            this.txtquatrinh.Size = new System.Drawing.Size(45, 29);
            this.txtquatrinh.TabIndex = 3;
            this.txtquatrinh.Click += new System.EventHandler(this.txtquatrinh_Click);
            // 
            // lbldiemthi
            // 
            this.lbldiemthi.AutoSize = true;
            this.lbldiemthi.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiemthi.ForeColor = System.Drawing.Color.Blue;
            this.lbldiemthi.Location = new System.Drawing.Point(213, 110);
            this.lbldiemthi.Name = "lbldiemthi";
            this.lbldiemthi.Size = new System.Drawing.Size(86, 22);
            this.lbldiemthi.TabIndex = 4;
            this.lbldiemthi.Text = "Điểm thi:";
            // 
            // txtdiemthi
            // 
            this.txtdiemthi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiemthi.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtdiemthi.Location = new System.Drawing.Point(299, 104);
            this.txtdiemthi.MaxLength = 4;
            this.txtdiemthi.Name = "txtdiemthi";
            this.txtdiemthi.Size = new System.Drawing.Size(45, 29);
            this.txtdiemthi.TabIndex = 5;
            this.txtdiemthi.Click += new System.EventHandler(this.txtdiemthi_Click);
            // 
            // btncheck
            // 
            this.btncheck.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.ForeColor = System.Drawing.Color.Fuchsia;
            this.btncheck.Location = new System.Drawing.Point(70, 155);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(206, 50);
            this.btncheck.TabIndex = 6;
            this.btncheck.Text = "Kiểm Tra";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // lbldiemso
            // 
            this.lbldiemso.AutoSize = true;
            this.lbldiemso.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiemso.ForeColor = System.Drawing.Color.Red;
            this.lbldiemso.Location = new System.Drawing.Point(12, 228);
            this.lbldiemso.Name = "lbldiemso";
            this.lbldiemso.Size = new System.Drawing.Size(92, 24);
            this.lbldiemso.TabIndex = 7;
            this.lbldiemso.Text = "Điểm Số:";
            // 
            // lbldiemthishow
            // 
            this.lbldiemthishow.AutoSize = true;
            this.lbldiemthishow.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiemthishow.ForeColor = System.Drawing.Color.Blue;
            this.lbldiemthishow.Location = new System.Drawing.Point(96, 225);
            this.lbldiemthishow.Name = "lbldiemthishow";
            this.lbldiemthishow.Size = new System.Drawing.Size(0, 29);
            this.lbldiemthishow.TabIndex = 8;
            // 
            // lbldiemchu
            // 
            this.lbldiemchu.AutoSize = true;
            this.lbldiemchu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiemchu.ForeColor = System.Drawing.Color.Red;
            this.lbldiemchu.Location = new System.Drawing.Point(174, 228);
            this.lbldiemchu.Name = "lbldiemchu";
            this.lbldiemchu.Size = new System.Drawing.Size(108, 24);
            this.lbldiemchu.TabIndex = 9;
            this.lbldiemchu.Text = "Điểm Chữ:";
            // 
            // lbldiemchushow
            // 
            this.lbldiemchushow.AutoSize = true;
            this.lbldiemchushow.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiemchushow.ForeColor = System.Drawing.Color.Blue;
            this.lbldiemchushow.Location = new System.Drawing.Point(273, 226);
            this.lbldiemchushow.Name = "lbldiemchushow";
            this.lbldiemchushow.Size = new System.Drawing.Size(0, 26);
            this.lbldiemchushow.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(223, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Design by: nhOc Lùn";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(10, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(371, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbldiemchushow);
            this.Controls.Add(this.lbldiemchu);
            this.Controls.Add(this.lbldiemthishow);
            this.Controls.Add(this.lbldiemso);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.txtdiemthi);
            this.Controls.Add(this.lbldiemthi);
            this.Controls.Add(this.txtquatrinh);
            this.Controls.Add(this.lblquatrinh);
            this.Controls.Add(this.lblinfomation);
            this.Controls.Add(this.lbltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm Tra Điểm Thi - Ver3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCheck_FormClosed);
            this.Load += new System.EventHandler(this.frmCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblinfomation;
        private System.Windows.Forms.Label lblquatrinh;
        private System.Windows.Forms.TextBox txtquatrinh;
        private System.Windows.Forms.Label lbldiemthi;
        private System.Windows.Forms.TextBox txtdiemthi;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label lbldiemso;
        private System.Windows.Forms.Label lbldiemthishow;
        private System.Windows.Forms.Label lbldiemchu;
        private System.Windows.Forms.Label lbldiemchushow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

