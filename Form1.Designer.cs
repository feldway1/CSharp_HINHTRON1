namespace CSharp_HINHTRON1
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
            this.lblbk = new System.Windows.Forms.Label();
            this.txtbk = new System.Windows.Forms.TextBox();
            this.btncv = new System.Windows.Forms.Button();
            this.btndt = new System.Windows.Forms.Button();
            this.lblkq = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.grbchon1 = new System.Windows.Forms.GroupBox();
            this.grbchon2 = new System.Windows.Forms.GroupBox();
            this.chkcv = new System.Windows.Forms.CheckBox();
            this.chkdt = new System.Windows.Forms.CheckBox();
            this.rdbcv = new System.Windows.Forms.RadioButton();
            this.rdbdt = new System.Windows.Forms.RadioButton();
            this.btntinh1 = new System.Windows.Forms.Button();
            this.btntinh2 = new System.Windows.Forms.Button();
            this.grbchon1.SuspendLayout();
            this.grbchon2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH CHU VI VÀ DIỆN TÍCH HÌNH TRÒN";
            // 
            // lblbk
            // 
            this.lblbk.AutoSize = true;
            this.lblbk.Location = new System.Drawing.Point(56, 94);
            this.lblbk.Name = "lblbk";
            this.lblbk.Size = new System.Drawing.Size(83, 23);
            this.lblbk.TabIndex = 1;
            this.lblbk.Text = "Bán kính";
            // 
            // txtbk
            // 
            this.txtbk.Location = new System.Drawing.Point(215, 87);
            this.txtbk.Name = "txtbk";
            this.txtbk.Size = new System.Drawing.Size(100, 30);
            this.txtbk.TabIndex = 2;
            // 
            // btncv
            // 
            this.btncv.Location = new System.Drawing.Point(60, 166);
            this.btncv.Name = "btncv";
            this.btncv.Size = new System.Drawing.Size(99, 32);
            this.btncv.TabIndex = 3;
            this.btncv.Text = "Chu vi";
            this.btncv.UseVisualStyleBackColor = true;
            this.btncv.Click += new System.EventHandler(this.btncv_Click);
            // 
            // btndt
            // 
            this.btndt.Location = new System.Drawing.Point(215, 167);
            this.btndt.Name = "btndt";
            this.btndt.Size = new System.Drawing.Size(121, 31);
            this.btndt.TabIndex = 4;
            this.btndt.Text = "Diện tích";
            this.btndt.UseVisualStyleBackColor = true;
            this.btndt.Click += new System.EventHandler(this.btndt_Click);
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(60, 286);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(75, 23);
            this.lblkq.TabIndex = 5;
            this.lblkq.Text = "Kết quả";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(215, 279);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 30);
            this.txtkq.TabIndex = 6;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(418, 525);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 30);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // grbchon1
            // 
            this.grbchon1.Controls.Add(this.rdbdt);
            this.grbchon1.Controls.Add(this.rdbcv);
            this.grbchon1.Location = new System.Drawing.Point(436, 87);
            this.grbchon1.Name = "grbchon1";
            this.grbchon1.Size = new System.Drawing.Size(200, 100);
            this.grbchon1.TabIndex = 8;
            this.grbchon1.TabStop = false;
            this.grbchon1.Text = "Chọn";
            // 
            // grbchon2
            // 
            this.grbchon2.Controls.Add(this.chkdt);
            this.grbchon2.Controls.Add(this.chkcv);
            this.grbchon2.Location = new System.Drawing.Point(719, 87);
            this.grbchon2.Name = "grbchon2";
            this.grbchon2.Size = new System.Drawing.Size(200, 100);
            this.grbchon2.TabIndex = 9;
            this.grbchon2.TabStop = false;
            this.grbchon2.Text = "Chọn";
            // 
            // chkcv
            // 
            this.chkcv.AutoSize = true;
            this.chkcv.Location = new System.Drawing.Point(20, 30);
            this.chkcv.Name = "chkcv";
            this.chkcv.Size = new System.Drawing.Size(81, 27);
            this.chkcv.TabIndex = 0;
            this.chkcv.Text = "Chu vi";
            this.chkcv.UseVisualStyleBackColor = true;
            // 
            // chkdt
            // 
            this.chkdt.AutoSize = true;
            this.chkdt.Location = new System.Drawing.Point(20, 64);
            this.chkdt.Name = "chkdt";
            this.chkdt.Size = new System.Drawing.Size(103, 27);
            this.chkdt.TabIndex = 1;
            this.chkdt.Text = "Diện tích";
            this.chkdt.UseVisualStyleBackColor = true;
            // 
            // rdbcv
            // 
            this.rdbcv.AutoSize = true;
            this.rdbcv.Location = new System.Drawing.Point(7, 30);
            this.rdbcv.Name = "rdbcv";
            this.rdbcv.Size = new System.Drawing.Size(80, 27);
            this.rdbcv.TabIndex = 0;
            this.rdbcv.TabStop = true;
            this.rdbcv.Text = "Chu vi";
            this.rdbcv.UseVisualStyleBackColor = true;
            // 
            // rdbdt
            // 
            this.rdbdt.AutoSize = true;
            this.rdbdt.Location = new System.Drawing.Point(7, 64);
            this.rdbdt.Name = "rdbdt";
            this.rdbdt.Size = new System.Drawing.Size(102, 27);
            this.rdbdt.TabIndex = 1;
            this.rdbdt.TabStop = true;
            this.rdbdt.Text = "Diện tích";
            this.rdbdt.UseVisualStyleBackColor = true;
            // 
            // btntinh1
            // 
            this.btntinh1.Location = new System.Drawing.Point(436, 236);
            this.btntinh1.Name = "btntinh1";
            this.btntinh1.Size = new System.Drawing.Size(200, 28);
            this.btntinh1.TabIndex = 10;
            this.btntinh1.Text = "Tính loại 1";
            this.btntinh1.UseVisualStyleBackColor = true;
            this.btntinh1.Click += new System.EventHandler(this.btntinh1_Click);
            // 
            // btntinh2
            // 
            this.btntinh2.Location = new System.Drawing.Point(719, 236);
            this.btntinh2.Name = "btntinh2";
            this.btntinh2.Size = new System.Drawing.Size(200, 28);
            this.btntinh2.TabIndex = 11;
            this.btntinh2.Text = "Tính loại 2";
            this.btntinh2.UseVisualStyleBackColor = true;
            this.btntinh2.Click += new System.EventHandler(this.btntinh2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(979, 599);
            this.Controls.Add(this.btntinh2);
            this.Controls.Add(this.btntinh1);
            this.Controls.Add(this.grbchon2);
            this.Controls.Add(this.grbchon1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.btndt);
            this.Controls.Add(this.btncv);
            this.Controls.Add(this.txtbk);
            this.Controls.Add(this.lblbk);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "HÌNH TRÒN";
            this.grbchon1.ResumeLayout(false);
            this.grbchon1.PerformLayout();
            this.grbchon2.ResumeLayout(false);
            this.grbchon2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbk;
        private System.Windows.Forms.TextBox txtbk;
        private System.Windows.Forms.Button btncv;
        private System.Windows.Forms.Button btndt;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox grbchon1;
        private System.Windows.Forms.RadioButton rdbdt;
        private System.Windows.Forms.RadioButton rdbcv;
        private System.Windows.Forms.GroupBox grbchon2;
        private System.Windows.Forms.CheckBox chkdt;
        private System.Windows.Forms.CheckBox chkcv;
        private System.Windows.Forms.Button btntinh1;
        private System.Windows.Forms.Button btntinh2;
    }
}

