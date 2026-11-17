namespace POS_PerpusDigital
{
    partial class peminjamann
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
            this.txt_judulbuku = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnProsesPinjam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_judulbuku
            // 
            this.txt_judulbuku.Location = new System.Drawing.Point(17, 58);
            this.txt_judulbuku.Name = "txt_judulbuku";
            this.txt_judulbuku.Size = new System.Drawing.Size(227, 22);
            this.txt_judulbuku.TabIndex = 0;
            this.txt_judulbuku.TextChanged += new System.EventHandler(this.txtBukuID_TextChanged);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(17, 106);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(132, 22);
            this.txtMemberID.TabIndex = 1;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // dtpLoanDate
            // 
            this.dtpLoanDate.Location = new System.Drawing.Point(17, 150);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(200, 22);
            this.dtpLoanDate.TabIndex = 2;
            this.dtpLoanDate.ValueChanged += new System.EventHandler(this.dtpLoanDate_ValueChanged_1);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(17, 202);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDueDate.TabIndex = 3;
            this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpDueDate_ValueChanged);
            // 
            // btnProsesPinjam
            // 
            this.btnProsesPinjam.Location = new System.Drawing.Point(64, 249);
            this.btnProsesPinjam.Name = "btnProsesPinjam";
            this.btnProsesPinjam.Size = new System.Drawing.Size(96, 33);
            this.btnProsesPinjam.TabIndex = 4;
            this.btnProsesPinjam.Text = "Pinjam ";
            this.btnProsesPinjam.UseVisualStyleBackColor = true;
            this.btnProsesPinjam.Click += new System.EventHandler(this.btnProsesPinjam_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Judul Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "MemberID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "TanggalPinjam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "TanggalPengembalian";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnProsesPinjam);
            this.groupBox1.Controls.Add(this.dtpDueDate);
            this.groupBox1.Controls.Add(this.dtpLoanDate);
            this.groupBox1.Controls.Add(this.txtMemberID);
            this.groupBox1.Controls.Add(this.txt_judulbuku);
            this.groupBox1.Location = new System.Drawing.Point(226, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 329);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // peminjamann
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "peminjamann";
            this.Text = "peminjamann";
            this.Load += new System.EventHandler(this.peminjamann_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_judulbuku;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnProsesPinjam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}