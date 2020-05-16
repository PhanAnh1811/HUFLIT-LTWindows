namespace Bai1
{
    partial class FormBai1
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
            this.txtBoxX = new System.Windows.Forms.TextBox();
            this.btnXuLy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxY = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số hạng X:";
            // 
            // txtBoxX
            // 
            this.txtBoxX.Location = new System.Drawing.Point(105, 29);
            this.txtBoxX.Name = "txtBoxX";
            this.txtBoxX.Size = new System.Drawing.Size(95, 20);
            this.txtBoxX.TabIndex = 1;
            // 
            // btnXuLy
            // 
            this.btnXuLy.Location = new System.Drawing.Point(205, 130);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(86, 31);
            this.btnXuLy.TabIndex = 2;
            this.btnXuLy.Text = "Hiển thị giá trị";
            this.btnXuLy.UseVisualStyleBackColor = true;
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập số mũ Y:";
            // 
            // txtBoxY
            // 
            this.txtBoxY.Location = new System.Drawing.Point(105, 104);
            this.txtBoxY.Name = "txtBoxY";
            this.txtBoxY.Size = new System.Drawing.Size(95, 20);
            this.txtBoxY.TabIndex = 4;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(128, 183);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 13);
            this.lblKetQua.TabIndex = 5;
            // 
            // FormBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 224);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtBoxY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXuLy);
            this.Controls.Add(this.txtBoxX);
            this.Controls.Add(this.label1);
            this.Name = "FormBai1";
            this.Text = "Bai1_Buoi5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxX;
        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxY;
        private System.Windows.Forms.Label lblKetQua;
    }
}

