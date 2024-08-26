namespace BaiTapWindowsForm_BT3
{
    partial class frmBai3
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
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.txtSoN1 = new System.Windows.Forms.TextBox();
            this.txtSoN2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTachChuoi = new System.Windows.Forms.RadioButton();
            this.rdThuTu = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.AutoSize = true;
            this.btnXemKQ.Location = new System.Drawing.Point(113, 280);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(116, 38);
            this.btnXemKQ.TabIndex = 14;
            this.btnXemKQ.Text = "Xem kết quả";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(220, 331);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(17, 25);
            this.lblKetQua.TabIndex = 12;
            this.lblKetQua.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kết quả là:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Chuỗi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Số N1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số N2:";
            // 
            // txtChuoi
            // 
            this.txtChuoi.Location = new System.Drawing.Point(113, 37);
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(150, 26);
            this.txtChuoi.TabIndex = 16;
            // 
            // txtSoN1
            // 
            this.txtSoN1.Location = new System.Drawing.Point(113, 77);
            this.txtSoN1.Name = "txtSoN1";
            this.txtSoN1.Size = new System.Drawing.Size(150, 26);
            this.txtSoN1.TabIndex = 16;
            this.txtSoN1.Text = "0";
            // 
            // txtSoN2
            // 
            this.txtSoN2.Location = new System.Drawing.Point(113, 117);
            this.txtSoN2.Name = "txtSoN2";
            this.txtSoN2.Size = new System.Drawing.Size(150, 26);
            this.txtSoN2.TabIndex = 16;
            this.txtSoN2.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdThuTu);
            this.groupBox1.Controls.Add(this.rdTachChuoi);
            this.groupBox1.Location = new System.Drawing.Point(113, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng:";
            // 
            // rdTachChuoi
            // 
            this.rdTachChuoi.AutoSize = true;
            this.rdTachChuoi.Checked = true;
            this.rdTachChuoi.Location = new System.Drawing.Point(17, 26);
            this.rdTachChuoi.Name = "rdTachChuoi";
            this.rdTachChuoi.Size = new System.Drawing.Size(124, 24);
            this.rdTachChuoi.TabIndex = 0;
            this.rdTachChuoi.TabStop = true;
            this.rdTachChuoi.Text = "Tách 1 chuỗi";
            this.rdTachChuoi.UseVisualStyleBackColor = true;
            // 
            // rdThuTu
            // 
            this.rdThuTu.AutoSize = true;
            this.rdThuTu.Location = new System.Drawing.Point(17, 56);
            this.rdThuTu.Name = "rdThuTu";
            this.rdThuTu.Size = new System.Drawing.Size(137, 24);
            this.rdThuTu.TabIndex = 0;
            this.rdThuTu.Text = "Hai số liên tiếp";
            this.rdThuTu.UseVisualStyleBackColor = true;
            // 
            // frmBai3
            // 
            this.AcceptButton = this.btnXemKQ;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN2);
            this.Controls.Add(this.txtSoN1);
            this.Controls.Add(this.txtChuoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label3);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.TextBox txtSoN1;
        private System.Windows.Forms.TextBox txtSoN2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdThuTu;
        private System.Windows.Forms.RadioButton rdTachChuoi;
    }
}