namespace Bai3
{
    partial class FormBai3
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
            this.txtBoxMSNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxHoTenNV = new System.Windows.Forms.TextBox();
            this.rdBtnNVKD = new System.Windows.Forms.RadioButton();
            this.rdBtnNVSX = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxLCB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxSLHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxSLSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLuongNhanVien = new System.Windows.Forms.Label();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã nhân viên:";
            // 
            // txtBoxMSNV
            // 
            this.txtBoxMSNV.Location = new System.Drawing.Point(151, 26);
            this.txtBoxMSNV.Name = "txtBoxMSNV";
            this.txtBoxMSNV.Size = new System.Drawing.Size(313, 20);
            this.txtBoxMSNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập họ tên nhân viên:";
            // 
            // txtBoxHoTenNV
            // 
            this.txtBoxHoTenNV.Location = new System.Drawing.Point(151, 71);
            this.txtBoxHoTenNV.Name = "txtBoxHoTenNV";
            this.txtBoxHoTenNV.Size = new System.Drawing.Size(313, 20);
            this.txtBoxHoTenNV.TabIndex = 3;
            // 
            // rdBtnNVKD
            // 
            this.rdBtnNVKD.AutoSize = true;
            this.rdBtnNVKD.Location = new System.Drawing.Point(151, 113);
            this.rdBtnNVKD.Name = "rdBtnNVKD";
            this.rdBtnNVKD.Size = new System.Drawing.Size(130, 17);
            this.rdBtnNVKD.TabIndex = 4;
            this.rdBtnNVKD.Text = "Nhân viên kinh doanh";
            this.rdBtnNVKD.UseVisualStyleBackColor = true;
            this.rdBtnNVKD.CheckedChanged += new System.EventHandler(this.rdBtnNVKD_CheckedChanged);
            // 
            // rdBtnNVSX
            // 
            this.rdBtnNVSX.AutoSize = true;
            this.rdBtnNVSX.Location = new System.Drawing.Point(347, 113);
            this.rdBtnNVSX.Name = "rdBtnNVSX";
            this.rdBtnNVSX.Size = new System.Drawing.Size(117, 17);
            this.rdBtnNVSX.TabIndex = 5;
            this.rdBtnNVSX.Text = "Nhân viên sản xuất";
            this.rdBtnNVSX.UseVisualStyleBackColor = true;
            this.rdBtnNVSX.CheckedChanged += new System.EventHandler(this.rdBtnNVSX_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lương cơ bản:";
            // 
            // txtBoxLCB
            // 
            this.txtBoxLCB.Location = new System.Drawing.Point(151, 163);
            this.txtBoxLCB.Name = "txtBoxLCB";
            this.txtBoxLCB.Size = new System.Drawing.Size(148, 20);
            this.txtBoxLCB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng hợp đồng:";
            // 
            // txtBoxSLHD
            // 
            this.txtBoxSLHD.Location = new System.Drawing.Point(151, 202);
            this.txtBoxSLHD.Name = "txtBoxSLHD";
            this.txtBoxSLHD.Size = new System.Drawing.Size(44, 20);
            this.txtBoxSLHD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số lượng sảm phẩm:";
            // 
            // txtBoxSLSP
            // 
            this.txtBoxSLSP.Location = new System.Drawing.Point(444, 147);
            this.txtBoxSLSP.Name = "txtBoxSLSP";
            this.txtBoxSLSP.Size = new System.Drawing.Size(38, 20);
            this.txtBoxSLSP.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lương của nhân viên là:";
            // 
            // lblLuongNhanVien
            // 
            this.lblLuongNhanVien.AutoSize = true;
            this.lblLuongNhanVien.Location = new System.Drawing.Point(305, 279);
            this.lblLuongNhanVien.Name = "lblLuongNhanVien";
            this.lblLuongNhanVien.Size = new System.Drawing.Size(13, 13);
            this.lblLuongNhanVien.TabIndex = 13;
            this.lblLuongNhanVien.Text = "0";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Location = new System.Drawing.Point(347, 202);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(146, 27);
            this.btnTinhLuong.TabIndex = 14;
            this.btnTinhLuong.Text = "Tính lương của nhân viên";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // FormBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 338);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.lblLuongNhanVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxSLSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxSLHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxLCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdBtnNVSX);
            this.Controls.Add(this.rdBtnNVKD);
            this.Controls.Add(this.txtBoxHoTenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMSNV);
            this.Controls.Add(this.label1);
            this.Name = "FormBai3";
            this.Text = "Bai3_Buoi5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMSNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxHoTenNV;
        private System.Windows.Forms.RadioButton rdBtnNVKD;
        private System.Windows.Forms.RadioButton rdBtnNVSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxLCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxSLHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxSLSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLuongNhanVien;
        private System.Windows.Forms.Button btnTinhLuong;
    }
}

