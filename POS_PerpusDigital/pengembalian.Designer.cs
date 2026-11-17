namespace POS_PerpusDigital
{
    partial class pengembalian
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
            this.txtLoanID = new System.Windows.Forms.TextBox();
            this.btnCariLoan = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtJudulBuku = new System.Windows.Forms.TextBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblSelisihHari = new System.Windows.Forms.Label();
            this.lblFineAmount = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.btnProsesPengembalian = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLoanID
            // 
            this.txtLoanID.Location = new System.Drawing.Point(28, 48);
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.Size = new System.Drawing.Size(100, 22);
            this.txtLoanID.TabIndex = 0;
            this.txtLoanID.TextChanged += new System.EventHandler(this.txtLoanID_TextChanged);
            // 
            // btnCariLoan
            // 
            this.btnCariLoan.Location = new System.Drawing.Point(28, 94);
            this.btnCariLoan.Name = "btnCariLoan";
            this.btnCariLoan.Size = new System.Drawing.Size(75, 23);
            this.btnCariLoan.TabIndex = 1;
            this.btnCariLoan.Text = "button1";
            this.btnCariLoan.UseVisualStyleBackColor = true;
            this.btnCariLoan.Click += new System.EventHandler(this.btnCariLoan_Click_1);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(41, 41);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 22);
            this.txtMemberID.TabIndex = 2;
            // 
            // txtJudulBuku
            // 
            this.txtJudulBuku.Location = new System.Drawing.Point(41, 80);
            this.txtJudulBuku.Name = "txtJudulBuku";
            this.txtJudulBuku.Size = new System.Drawing.Size(100, 22);
            this.txtJudulBuku.TabIndex = 3;
            this.txtJudulBuku.TextChanged += new System.EventHandler(this.txtJudulBuku_TextChanged);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(41, 153);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 22);
            this.dtpReturnDate.TabIndex = 5;
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // lblSelisihHari
            // 
            this.lblSelisihHari.AutoSize = true;
            this.lblSelisihHari.Location = new System.Drawing.Point(41, 189);
            this.lblSelisihHari.Name = "lblSelisihHari";
            this.lblSelisihHari.Size = new System.Drawing.Size(72, 16);
            this.lblSelisihHari.TabIndex = 6;
            this.lblSelisihHari.Text = "Selisih hari";
            this.lblSelisihHari.Click += new System.EventHandler(this.lblSelisihHari_Click);
            // 
            // lblFineAmount
            // 
            this.lblFineAmount.AutoSize = true;
            this.lblFineAmount.Location = new System.Drawing.Point(41, 228);
            this.lblFineAmount.Name = "lblFineAmount";
            this.lblFineAmount.Size = new System.Drawing.Size(46, 16);
            this.lblFineAmount.TabIndex = 7;
            this.lblFineAmount.Text = "denda";
            this.lblFineAmount.Click += new System.EventHandler(this.lblFineAmount_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(38, 283);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(121, 24);
            this.cmbPaymentMethod.TabIndex = 8;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(38, 120);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(171, 16);
            this.lblDueDate.TabIndex = 4;
            this.lblDueDate.Text = "batas waktu pengembalian:";
            this.lblDueDate.Click += new System.EventHandler(this.lblDueDate_Click);
            // 
            // btnProsesPengembalian
            // 
            this.btnProsesPengembalian.Location = new System.Drawing.Point(350, 322);
            this.btnProsesPengembalian.Name = "btnProsesPengembalian";
            this.btnProsesPengembalian.Size = new System.Drawing.Size(75, 23);
            this.btnProsesPengembalian.TabIndex = 9;
            this.btnProsesPengembalian.Text = "button1";
            this.btnProsesPengembalian.UseVisualStyleBackColor = true;
            this.btnProsesPengembalian.Click += new System.EventHandler(this.btnProsesPengembalian_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Pinjaman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Judul Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Member ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Metode pembarayan";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCariLoan);
            this.groupBox1.Controls.Add(this.txtLoanID);
            this.groupBox1.Location = new System.Drawing.Point(40, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 168);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnProsesPengembalian);
            this.groupBox2.Controls.Add(this.cmbPaymentMethod);
            this.groupBox2.Controls.Add(this.lblFineAmount);
            this.groupBox2.Controls.Add(this.lblSelisihHari);
            this.groupBox2.Controls.Add(this.dtpReturnDate);
            this.groupBox2.Controls.Add(this.lblDueDate);
            this.groupBox2.Controls.Add(this.txtJudulBuku);
            this.groupBox2.Controls.Add(this.txtMemberID);
            this.groupBox2.Location = new System.Drawing.Point(290, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 371);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // pengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "pengembalian";
            this.Text = "pengembalian";
            this.Load += new System.EventHandler(this.pengembalian_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoanID;
        private System.Windows.Forms.Button btnCariLoan;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtJudulBuku;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblSelisihHari;
        private System.Windows.Forms.Label lblFineAmount;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Button btnProsesPengembalian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}