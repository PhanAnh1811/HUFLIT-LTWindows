namespace TinhToan
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
            this.txtSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnLapPhuong = new System.Windows.Forms.Button();
            this.btnGiaiThua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số:";
            // 
            // txtSo
            // 
            this.txtSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo.Location = new System.Drawing.Point(53, 22);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(76, 29);
            this.txtSo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(94, 90);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(92, 29);
            this.txtKetQua.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGiaiThua);
            this.groupBox1.Controls.Add(this.btnLapPhuong);
            this.groupBox1.Controls.Add(this.btnBinhPhuong);
            this.groupBox1.Location = new System.Drawing.Point(375, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 259);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép toán";
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinhPhuong.Location = new System.Drawing.Point(104, 37);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(141, 33);
            this.btnBinhPhuong.TabIndex = 0;
            this.btnBinhPhuong.Text = "Bình Phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnLapPhuong
            // 
            this.btnLapPhuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhuong.Location = new System.Drawing.Point(107, 102);
            this.btnLapPhuong.Name = "btnLapPhuong";
            this.btnLapPhuong.Size = new System.Drawing.Size(137, 42);
            this.btnLapPhuong.TabIndex = 1;
            this.btnLapPhuong.Text = "Lập phương";
            this.btnLapPhuong.UseVisualStyleBackColor = true;
            this.btnLapPhuong.Click += new System.EventHandler(this.btnLapPhuong_Click);
            // 
            // btnGiaiThua
            // 
            this.btnGiaiThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiThua.Location = new System.Drawing.Point(107, 181);
            this.btnGiaiThua.Name = "btnGiaiThua";
            this.btnGiaiThua.Size = new System.Drawing.Size(136, 39);
            this.btnGiaiThua.TabIndex = 2;
            this.btnGiaiThua.Text = "Giai thừa";
            this.btnGiaiThua.UseVisualStyleBackColor = true;
            this.btnGiaiThua.Click += new System.EventHandler(this.btnGiaiThua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(107, 212);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 35);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính Toán";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGiaiThua;
        private System.Windows.Forms.Button btnLapPhuong;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnThoat;
    }
}

