namespace KT_THU
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maHN = new System.Windows.Forms.TextBox();
            this.txt_tenHN = new System.Windows.Forms.TextBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.cbo_loaiPH = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.dtgv_HN = new System.Windows.Forms.DataGridView();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hội nghị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hội nghị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại phòng HN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số người tham gia";
            // 
            // txt_maHN
            // 
            this.txt_maHN.Location = new System.Drawing.Point(160, 31);
            this.txt_maHN.Name = "txt_maHN";
            this.txt_maHN.Size = new System.Drawing.Size(416, 25);
            this.txt_maHN.TabIndex = 1;
            // 
            // txt_tenHN
            // 
            this.txt_tenHN.Location = new System.Drawing.Point(160, 66);
            this.txt_tenHN.Name = "txt_tenHN";
            this.txt_tenHN.Size = new System.Drawing.Size(416, 25);
            this.txt_tenHN.TabIndex = 1;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(476, 102);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(100, 25);
            this.txt_soLuong.TabIndex = 1;
            // 
            // cbo_loaiPH
            // 
            this.cbo_loaiPH.FormattingEnabled = true;
            this.cbo_loaiPH.Location = new System.Drawing.Point(160, 102);
            this.cbo_loaiPH.Name = "cbo_loaiPH";
            this.cbo_loaiPH.Size = new System.Drawing.Size(121, 26);
            this.cbo_loaiPH.TabIndex = 2;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(56, 173);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(83, 30);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(198, 173);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(83, 30);
            this.btn_Luu.TabIndex = 3;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(330, 173);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 30);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(493, 173);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(83, 30);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Kết thúc";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // dtgv_HN
            // 
            this.dtgv_HN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HN.Location = new System.Drawing.Point(12, 226);
            this.dtgv_HN.Name = "dtgv_HN";
            this.dtgv_HN.Size = new System.Drawing.Size(624, 169);
            this.dtgv_HN.TabIndex = 4;
            this.dtgv_HN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_HN_CellClick);
            // 
            // btn_Loc
            // 
            this.btn_Loc.Location = new System.Drawing.Point(317, 412);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(302, 30);
            this.btn_Loc.TabIndex = 3;
            this.btn_Loc.Text = "Lọc danh sách theo loại phòng";
            this.btn_Loc.UseVisualStyleBackColor = true;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 418);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dương Thuận Quang";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 454);
            this.Controls.Add(this.dtgv_HN);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Loc);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cbo_loaiPH);
            this.Controls.Add(this.txt_soLuong);
            this.Controls.Add(this.txt_tenHN);
            this.Controls.Add(this.txt_maHN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maHN;
        private System.Windows.Forms.TextBox txt_tenHN;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.ComboBox cbo_loaiPH;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridView dtgv_HN;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.Label label5;
    }
}

