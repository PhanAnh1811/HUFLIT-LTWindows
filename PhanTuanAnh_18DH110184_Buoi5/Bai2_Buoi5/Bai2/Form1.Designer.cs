namespace Bai2
{
    partial class FormBai2
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
            this.txtBoxTuSoA = new System.Windows.Forms.TextBox();
            this.txtBoxMauSoA = new System.Windows.Forms.TextBox();
            this.txtBoxTuSoB = new System.Windows.Forms.TextBox();
            this.txtBoxMauSoB = new System.Windows.Forms.TextBox();
            this.btnCongPhanSo = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tử số của phân số A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mẫu số của phân số A: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập tử số của phân số B: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập mẫu số của phân số B: ";
            // 
            // txtBoxTuSoA
            // 
            this.txtBoxTuSoA.Location = new System.Drawing.Point(181, 24);
            this.txtBoxTuSoA.Name = "txtBoxTuSoA";
            this.txtBoxTuSoA.Size = new System.Drawing.Size(72, 20);
            this.txtBoxTuSoA.TabIndex = 4;
            // 
            // txtBoxMauSoA
            // 
            this.txtBoxMauSoA.Location = new System.Drawing.Point(181, 68);
            this.txtBoxMauSoA.Name = "txtBoxMauSoA";
            this.txtBoxMauSoA.Size = new System.Drawing.Size(72, 20);
            this.txtBoxMauSoA.TabIndex = 5;
            // 
            // txtBoxTuSoB
            // 
            this.txtBoxTuSoB.Location = new System.Drawing.Point(181, 112);
            this.txtBoxTuSoB.Name = "txtBoxTuSoB";
            this.txtBoxTuSoB.Size = new System.Drawing.Size(72, 20);
            this.txtBoxTuSoB.TabIndex = 6;
            // 
            // txtBoxMauSoB
            // 
            this.txtBoxMauSoB.Location = new System.Drawing.Point(181, 153);
            this.txtBoxMauSoB.Name = "txtBoxMauSoB";
            this.txtBoxMauSoB.Size = new System.Drawing.Size(72, 20);
            this.txtBoxMauSoB.TabIndex = 7;
            // 
            // btnCongPhanSo
            // 
            this.btnCongPhanSo.Location = new System.Drawing.Point(251, 192);
            this.btnCongPhanSo.Name = "btnCongPhanSo";
            this.btnCongPhanSo.Size = new System.Drawing.Size(113, 23);
            this.btnCongPhanSo.TabIndex = 8;
            this.btnCongPhanSo.Text = "Tính tổng 2 phân số";
            this.btnCongPhanSo.UseVisualStyleBackColor = true;
            this.btnCongPhanSo.Click += new System.EventHandler(this.btnCongPhanSo_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(118, 225);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 13);
            this.lblKetQua.TabIndex = 9;
            // 
            // FormBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 358);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnCongPhanSo);
            this.Controls.Add(this.txtBoxMauSoB);
            this.Controls.Add(this.txtBoxTuSoB);
            this.Controls.Add(this.txtBoxMauSoA);
            this.Controls.Add(this.txtBoxTuSoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBai2";
            this.Text = "Bai2_Buoi5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTuSoA;
        private System.Windows.Forms.TextBox txtBoxMauSoA;
        private System.Windows.Forms.TextBox txtBoxTuSoB;
        private System.Windows.Forms.TextBox txtBoxMauSoB;
        private System.Windows.Forms.Button btnCongPhanSo;
        private System.Windows.Forms.Label lblKetQua;
    }
}

