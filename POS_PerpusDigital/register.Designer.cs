namespace POS_PerpusDigital
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            System.Windows.Forms.Label namaMemberLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.dB_PerpusDigitalDataSet = new POS_PerpusDigital.DB_PerpusDigitalDataSet();
            this.tbl_MembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MembersTableAdapter = new POS_PerpusDigital.DB_PerpusDigitalDataSetTableAdapters.Tbl_MembersTableAdapter();
            this.tableAdapterManager = new POS_PerpusDigital.DB_PerpusDigitalDataSetTableAdapters.TableAdapterManager();
            this.tbl_MembersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_MembersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txt_NamaMember = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            namaMemberLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PerpusDigitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MembersBindingNavigator)).BeginInit();
            this.tbl_MembersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dB_PerpusDigitalDataSet
            // 
            this.dB_PerpusDigitalDataSet.DataSetName = "DB_PerpusDigitalDataSet";
            this.dB_PerpusDigitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_MembersBindingSource
            // 
            this.tbl_MembersBindingSource.DataMember = "Tbl_Members";
            this.tbl_MembersBindingSource.DataSource = this.dB_PerpusDigitalDataSet;
            // 
            // tbl_MembersTableAdapter
            // 
            this.tbl_MembersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl__FinePaymentsTableAdapter = null;
            this.tableAdapterManager.Tbl_BooksTableAdapter = null;
            this.tableAdapterManager.Tbl_LoansTableAdapter = null;
            this.tableAdapterManager.Tbl_MembersTableAdapter = this.tbl_MembersTableAdapter;
            this.tableAdapterManager.UpdateOrder = POS_PerpusDigital.DB_PerpusDigitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_MembersBindingNavigator
            // 
            this.tbl_MembersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_MembersBindingNavigator.BindingSource = this.tbl_MembersBindingSource;
            this.tbl_MembersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_MembersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_MembersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_MembersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_MembersBindingNavigatorSaveItem});
            this.tbl_MembersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_MembersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_MembersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_MembersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_MembersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_MembersBindingNavigator.Name = "tbl_MembersBindingNavigator";
            this.tbl_MembersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_MembersBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tbl_MembersBindingNavigator.TabIndex = 0;
            this.tbl_MembersBindingNavigator.Text = "bindingNavigator1";
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
            // tbl_MembersBindingNavigatorSaveItem
            // 
            this.tbl_MembersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_MembersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_MembersBindingNavigatorSaveItem.Image")));
            this.tbl_MembersBindingNavigatorSaveItem.Name = "tbl_MembersBindingNavigatorSaveItem";
            this.tbl_MembersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tbl_MembersBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_MembersBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_MembersBindingNavigatorSaveItem_Click);
            // 
            // namaMemberLabel
            // 
            namaMemberLabel.AutoSize = true;
            namaMemberLabel.Location = new System.Drawing.Point(599, 44);
            namaMemberLabel.Name = "namaMemberLabel";
            namaMemberLabel.Size = new System.Drawing.Size(100, 16);
            namaMemberLabel.TabIndex = 3;
            namaMemberLabel.Text = "Nama Member:";
            namaMemberLabel.Click += new System.EventHandler(this.namaMemberLabel_Click);
            // 
            // txt_NamaMember
            // 
            this.txt_NamaMember.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_MembersBindingSource, "NamaMember", true));
            this.txt_NamaMember.Location = new System.Drawing.Point(602, 63);
            this.txt_NamaMember.Name = "txt_NamaMember";
            this.txt_NamaMember.Size = new System.Drawing.Size(155, 22);
            this.txt_NamaMember.TabIndex = 4;
            this.txt_NamaMember.TextChanged += new System.EventHandler(this.txt_NamaMember_TextChanged);
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(599, 94);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(73, 16);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Username:";
            usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_MembersBindingSource, "Username", true));
            this.txt_Username.Location = new System.Drawing.Point(602, 113);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(178, 22);
            this.txt_Username.TabIndex = 6;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(599, 138);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(70, 16);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_MembersBindingSource, "Password", true));
            this.txtPassword.Location = new System.Drawing.Point(602, 157);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 22);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.Location = new System.Drawing.Point(602, 210);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.Size = new System.Drawing.Size(155, 22);
            this.txt_confirmPassword.TabIndex = 9;
            this.txt_confirmPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ConfirmPassword";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(602, 254);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 11;
            this.btn_register.Text = "register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(namaMemberLabel);
            this.Controls.Add(this.txt_NamaMember);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.tbl_MembersBindingNavigator);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_PerpusDigitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_MembersBindingNavigator)).EndInit();
            this.tbl_MembersBindingNavigator.ResumeLayout(false);
            this.tbl_MembersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_PerpusDigitalDataSet dB_PerpusDigitalDataSet;
        private System.Windows.Forms.BindingSource tbl_MembersBindingSource;
        private DB_PerpusDigitalDataSetTableAdapters.Tbl_MembersTableAdapter tbl_MembersTableAdapter;
        private DB_PerpusDigitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_MembersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_MembersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txt_NamaMember;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txt_confirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_register;
    }
}