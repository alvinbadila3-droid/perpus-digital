namespace POS_PerpusDigital
{
    partial class Buku
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buku));
            System.Windows.Forms.Label judulBukuLabel;
            System.Windows.Forms.Label namaPengarangLabel;
            System.Windows.Forms.Label kategoryLabel;
            System.Windows.Forms.Label stokLabel;
            this.dB_PerpusDigitalDataSet = new POS_PerpusDigital.DB_PerpusDigitalDataSet();
            this.tbl_BooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_BooksTableAdapter = new POS_PerpusDigital.DB_PerpusDigitalDataSetTableAdapters.Tbl_BooksTableAdapter();
            this.tableAdapterManager = new POS_PerpusDigital.DB_PerpusDigitalDataSetTableAdapters.TableAdapterManager();
            this.tbl_BooksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_BooksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_judulbuku = new System.Windows.Forms.TextBox();
            this.txt_namapengarang = new System.Windows.Forms.TextBox();
            this.txt_kategory = new System.Windows.Forms.TextBox();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            judulBukuLabel = new System.Windows.Forms.Label();
            namaPengarangLabel = new System.Windows.Forms.Label();
            kategoryLabel = new System.Windows.Forms.Label();
            stokLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PerpusDigitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BooksBindingNavigator)).BeginInit();
            this.tbl_BooksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_PerpusDigitalDataSet
            // 
            this.dB_PerpusDigitalDataSet.DataSetName = "DB_PerpusDigitalDataSet";
            this.dB_PerpusDigitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_BooksBindingSource
            // 
            this.tbl_BooksBindingSource.DataMember = "Tbl_Books";
            this.tbl_BooksBindingSource.DataSource = this.dB_PerpusDigitalDataSet;
            // 
            // tbl_BooksTableAdapter
            // 
            this.tbl_BooksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl__FinePaymentsTableAdapter = null;
            this.tableAdapterManager.Tbl_BooksTableAdapter = this.tbl_BooksTableAdapter;
            this.tableAdapterManager.Tbl_LoansTableAdapter = null;
            this.tableAdapterManager.Tbl_MembersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POS_PerpusDigital.DB_PerpusDigitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_BooksBindingNavigator
            // 
            this.tbl_BooksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_BooksBindingNavigator.BindingSource = this.tbl_BooksBindingSource;
            this.tbl_BooksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_BooksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_BooksBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_BooksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_BooksBindingNavigatorSaveItem});
            this.tbl_BooksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_BooksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_BooksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_BooksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_BooksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_BooksBindingNavigator.Name = "tbl_BooksBindingNavigator";
            this.tbl_BooksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_BooksBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tbl_BooksBindingNavigator.TabIndex = 0;
            this.tbl_BooksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tbl_BooksBindingNavigatorSaveItem
            // 
            this.tbl_BooksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_BooksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_BooksBindingNavigatorSaveItem.Image")));
            this.tbl_BooksBindingNavigatorSaveItem.Name = "tbl_BooksBindingNavigatorSaveItem";
            this.tbl_BooksBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tbl_BooksBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_BooksBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_BooksBindingNavigatorSaveItem_Click);
            // 
            // tbl_BooksDataGridView
            // 
            this.tbl_BooksDataGridView.AutoGenerateColumns = false;
            this.tbl_BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_BooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbl_BooksDataGridView.DataSource = this.tbl_BooksBindingSource;
            this.tbl_BooksDataGridView.Location = new System.Drawing.Point(0, 232);
            this.tbl_BooksDataGridView.Name = "tbl_BooksDataGridView";
            this.tbl_BooksDataGridView.RowHeadersWidth = 51;
            this.tbl_BooksDataGridView.RowTemplate.Height = 24;
            this.tbl_BooksDataGridView.Size = new System.Drawing.Size(676, 220);
            this.tbl_BooksDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BukuID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BukuID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "JudulBuku";
            this.dataGridViewTextBoxColumn2.HeaderText = "JudulBuku";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NamaPengarang";
            this.dataGridViewTextBoxColumn3.HeaderText = "NamaPengarang";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kategory";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kategory";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Stok";
            this.dataGridViewTextBoxColumn5.HeaderText = "Stok";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // judulBukuLabel
            // 
            judulBukuLabel.AutoSize = true;
            judulBukuLabel.Location = new System.Drawing.Point(25, 62);
            judulBukuLabel.Name = "judulBukuLabel";
            judulBukuLabel.Size = new System.Drawing.Size(75, 16);
            judulBukuLabel.TabIndex = 4;
            judulBukuLabel.Text = "Judul Buku:";
            // 
            // txt_judulbuku
            // 
            this.txt_judulbuku.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_BooksBindingSource, "JudulBuku", true));
            this.txt_judulbuku.Location = new System.Drawing.Point(148, 59);
            this.txt_judulbuku.Name = "txt_judulbuku";
            this.txt_judulbuku.Size = new System.Drawing.Size(100, 22);
            this.txt_judulbuku.TabIndex = 5;
            this.txt_judulbuku.TextChanged += new System.EventHandler(this.txt_judulbuku_TextChanged);
            // 
            // namaPengarangLabel
            // 
            namaPengarangLabel.AutoSize = true;
            namaPengarangLabel.Location = new System.Drawing.Point(25, 90);
            namaPengarangLabel.Name = "namaPengarangLabel";
            namaPengarangLabel.Size = new System.Drawing.Size(117, 16);
            namaPengarangLabel.TabIndex = 6;
            namaPengarangLabel.Text = "Nama Pengarang:";
            // 
            // txt_namapengarang
            // 
            this.txt_namapengarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_BooksBindingSource, "NamaPengarang", true));
            this.txt_namapengarang.Location = new System.Drawing.Point(148, 87);
            this.txt_namapengarang.Name = "txt_namapengarang";
            this.txt_namapengarang.Size = new System.Drawing.Size(100, 22);
            this.txt_namapengarang.TabIndex = 7;
            this.txt_namapengarang.TextChanged += new System.EventHandler(this.txt_namapengarang_TextChanged);
            // 
            // kategoryLabel
            // 
            kategoryLabel.AutoSize = true;
            kategoryLabel.Location = new System.Drawing.Point(25, 118);
            kategoryLabel.Name = "kategoryLabel";
            kategoryLabel.Size = new System.Drawing.Size(64, 16);
            kategoryLabel.TabIndex = 8;
            kategoryLabel.Text = "Kategory:";
            // 
            // txt_kategory
            // 
            this.txt_kategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_BooksBindingSource, "Kategory", true));
            this.txt_kategory.Location = new System.Drawing.Point(148, 115);
            this.txt_kategory.Name = "txt_kategory";
            this.txt_kategory.Size = new System.Drawing.Size(100, 22);
            this.txt_kategory.TabIndex = 9;
            this.txt_kategory.TextChanged += new System.EventHandler(this.txt_kategory_TextChanged);
            // 
            // stokLabel
            // 
            stokLabel.AutoSize = true;
            stokLabel.Location = new System.Drawing.Point(25, 146);
            stokLabel.Name = "stokLabel";
            stokLabel.Size = new System.Drawing.Size(37, 16);
            stokLabel.TabIndex = 10;
            stokLabel.Text = "Stok:";
            // 
            // txt_stok
            // 
            this.txt_stok.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_BooksBindingSource, "Stok", true));
            this.txt_stok.Location = new System.Drawing.Point(148, 143);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(100, 22);
            this.txt_stok.TabIndex = 11;
            this.txt_stok.TextChanged += new System.EventHandler(this.txt_stok_TextChanged);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(322, 142);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 12;
            this.btn_simpan.Text = "simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(488, 142);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(680, 141);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_hapus.TabIndex = 14;
            this.btn_hapus.Text = "hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // Buku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(judulBukuLabel);
            this.Controls.Add(this.txt_judulbuku);
            this.Controls.Add(namaPengarangLabel);
            this.Controls.Add(this.txt_namapengarang);
            this.Controls.Add(kategoryLabel);
            this.Controls.Add(this.txt_kategory);
            this.Controls.Add(stokLabel);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.tbl_BooksDataGridView);
            this.Controls.Add(this.tbl_BooksBindingNavigator);
            this.Name = "Buku";
            this.Text = "Buku";
            this.Load += new System.EventHandler(this.Buku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_PerpusDigitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BooksBindingNavigator)).EndInit();
            this.tbl_BooksBindingNavigator.ResumeLayout(false);
            this.tbl_BooksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_PerpusDigitalDataSet dB_PerpusDigitalDataSet;
        private System.Windows.Forms.BindingSource tbl_BooksBindingSource;
        private DB_PerpusDigitalDataSetTableAdapters.Tbl_BooksTableAdapter tbl_BooksTableAdapter;
        private DB_PerpusDigitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_BooksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_BooksBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tbl_BooksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txt_judulbuku;
        private System.Windows.Forms.TextBox txt_namapengarang;
        private System.Windows.Forms.TextBox txt_kategory;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_hapus;
    }
}