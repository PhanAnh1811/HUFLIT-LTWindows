namespace Bai1_Buoi8
{
    partial class FormDetailBill
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
            this.btnComplete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewDSThucUong = new System.Windows.Forms.ListView();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.tbNgayBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(154, 330);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(73, 26);
            this.btnComplete.TabIndex = 8;
            this.btnComplete.Text = "Hoàn tất";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngày bán:";
            // 
            // listViewDSThucUong
            // 
            this.listViewDSThucUong.HideSelection = false;
            this.listViewDSThucUong.Location = new System.Drawing.Point(28, 89);
            this.listViewDSThucUong.Name = "listViewDSThucUong";
            this.listViewDSThucUong.Size = new System.Drawing.Size(341, 182);
            this.listViewDSThucUong.TabIndex = 12;
            this.listViewDSThucUong.UseCompatibleStateImageBehavior = false;
            // 
            // tbMaHD
            // 
            this.tbMaHD.Location = new System.Drawing.Point(89, 20);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.ReadOnly = true;
            this.tbMaHD.Size = new System.Drawing.Size(127, 20);
            this.tbMaHD.TabIndex = 13;
            // 
            // tbNgayBan
            // 
            this.tbNgayBan.Location = new System.Drawing.Point(89, 54);
            this.tbNgayBan.Name = "tbNgayBan";
            this.tbNgayBan.ReadOnly = true;
            this.tbNgayBan.Size = new System.Drawing.Size(127, 20);
            this.tbNgayBan.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tổng cộng:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(83, 290);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 17;
            // 
            // FormDetailBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 368);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNgayBan);
            this.Controls.Add(this.tbMaHD);
            this.Controls.Add(this.listViewDSThucUong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComplete);
            this.Name = "FormDetailBill";
            this.Text = "ThemThucUongForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewDSThucUong;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.TextBox tbNgayBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTotal;
    }
}