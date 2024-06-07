namespace AlisPark.WebFormsUI
{
    partial class AlisPark
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
            this.gbxGetByCategoryName = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.gbxSearchByMemberName = new System.Windows.Forms.GroupBox();
            this.tbxMemberNameSearch = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.gbxAddMember = new System.Windows.Forms.GroupBox();
            this.btnMemberAdd = new System.Windows.Forms.Button();
            this.tbxBalanceAdd = new System.Windows.Forms.TextBox();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.tbxMemberPhoneAdd = new System.Windows.Forms.TextBox();
            this.tbxMemberSurnameAdd = new System.Windows.Forms.TextBox();
            this.tbxMemberNameAdd = new System.Windows.Forms.TextBox();
            this.lblBalanceAdd = new System.Windows.Forms.Label();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.lblMemberPhoneAdd = new System.Windows.Forms.Label();
            this.lblSurnameAdd = new System.Windows.Forms.Label();
            this.lblMemberNameAdd = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.gbxLogLogin = new System.Windows.Forms.GroupBox();
            this.tbxPasswordLogLogin = new System.Windows.Forms.TextBox();
            this.tbxUserNameLogLogin = new System.Windows.Forms.TextBox();
            this.lblPasswordLog = new System.Windows.Forms.Label();
            this.lblUserNameLog = new System.Windows.Forms.Label();
            this.gbxCurrentWorker = new System.Windows.Forms.GroupBox();
            this.btnChangeCurrentWorker = new System.Windows.Forms.Button();
            this.tbxCurrentWorkerPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentWorkerPassword = new System.Windows.Forms.Label();
            this.tbxCurrentWorker = new System.Windows.Forms.TextBox();
            this.lblCurrentWorker = new System.Windows.Forms.Label();
            this.gbxUpdateMember = new System.Windows.Forms.GroupBox();
            this.btnMemberUpdate = new System.Windows.Forms.Button();
            this.tbxBalanceUpdate = new System.Windows.Forms.TextBox();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.tbxMemberPhoneUpdate = new System.Windows.Forms.TextBox();
            this.tbxMemberSurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxMemberNameUpdate = new System.Windows.Forms.TextBox();
            this.lblBalanceUpdate = new System.Windows.Forms.Label();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.lblMemberPhoneUpdate = new System.Windows.Forms.Label();
            this.lblMemberSurnameUpdate = new System.Windows.Forms.Label();
            this.lblMemberNameUpdate = new System.Windows.Forms.Label();
            this.tbxDeductAccountFromBalance = new System.Windows.Forms.TextBox();
            this.btnDeductAccountFromBalance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMemberMailAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMemberMailUpdate = new System.Windows.Forms.TextBox();
            this.gbxGetByCategoryName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.gbxSearchByMemberName.SuspendLayout();
            this.gbxAddMember.SuspendLayout();
            this.gbxLogLogin.SuspendLayout();
            this.gbxCurrentWorker.SuspendLayout();
            this.gbxUpdateMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGetByCategoryName
            // 
            this.gbxGetByCategoryName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxGetByCategoryName.Controls.Add(this.cbxCategory);
            this.gbxGetByCategoryName.Controls.Add(this.lblCategory);
            this.gbxGetByCategoryName.Location = new System.Drawing.Point(13, 14);
            this.gbxGetByCategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxGetByCategoryName.Name = "gbxGetByCategoryName";
            this.gbxGetByCategoryName.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.gbxGetByCategoryName.Size = new System.Drawing.Size(533, 74);
            this.gbxGetByCategoryName.TabIndex = 0;
            this.gbxGetByCategoryName.TabStop = false;
            this.gbxGetByCategoryName.Text = "Kategoriye Göre Arama";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(173, 37);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(265, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 37);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(63, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori :";
            // 
            // dgvMember
            // 
            this.dgvMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvMember.Location = new System.Drawing.Point(13, 186);
            this.dgvMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.Size = new System.Drawing.Size(1067, 185);
            this.dgvMember.TabIndex = 1;
            this.dgvMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellClick);
            // 
            // gbxSearchByMemberName
            // 
            this.gbxSearchByMemberName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxSearchByMemberName.Controls.Add(this.tbxMemberNameSearch);
            this.gbxSearchByMemberName.Controls.Add(this.lblMemberName);
            this.gbxSearchByMemberName.Location = new System.Drawing.Point(13, 91);
            this.gbxSearchByMemberName.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSearchByMemberName.Name = "gbxSearchByMemberName";
            this.gbxSearchByMemberName.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.gbxSearchByMemberName.Size = new System.Drawing.Size(533, 74);
            this.gbxSearchByMemberName.TabIndex = 2;
            this.gbxSearchByMemberName.TabStop = false;
            this.gbxSearchByMemberName.Text = "Üye Adına Göre Arama";
            // 
            // tbxMemberNameSearch
            // 
            this.tbxMemberNameSearch.Location = new System.Drawing.Point(173, 37);
            this.tbxMemberNameSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMemberNameSearch.Name = "tbxMemberNameSearch";
            this.tbxMemberNameSearch.Size = new System.Drawing.Size(265, 22);
            this.tbxMemberNameSearch.TabIndex = 1;
            this.tbxMemberNameSearch.TextChanged += new System.EventHandler(this.tbxMemberNameSearch_TextChanged);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(20, 37);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(61, 16);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Üye Adı :";
            // 
            // gbxAddMember
            // 
            this.gbxAddMember.Controls.Add(this.tbxMemberMailAdd);
            this.gbxAddMember.Controls.Add(this.label1);
            this.gbxAddMember.Controls.Add(this.btnMemberAdd);
            this.gbxAddMember.Controls.Add(this.tbxBalanceAdd);
            this.gbxAddMember.Controls.Add(this.cbxCategoryAdd);
            this.gbxAddMember.Controls.Add(this.tbxMemberPhoneAdd);
            this.gbxAddMember.Controls.Add(this.tbxMemberSurnameAdd);
            this.gbxAddMember.Controls.Add(this.tbxMemberNameAdd);
            this.gbxAddMember.Controls.Add(this.lblBalanceAdd);
            this.gbxAddMember.Controls.Add(this.lblCategoryAdd);
            this.gbxAddMember.Controls.Add(this.lblMemberPhoneAdd);
            this.gbxAddMember.Controls.Add(this.lblSurnameAdd);
            this.gbxAddMember.Controls.Add(this.lblMemberNameAdd);
            this.gbxAddMember.Location = new System.Drawing.Point(13, 448);
            this.gbxAddMember.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAddMember.Name = "gbxAddMember";
            this.gbxAddMember.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAddMember.Size = new System.Drawing.Size(1067, 212);
            this.gbxAddMember.TabIndex = 3;
            this.gbxAddMember.TabStop = false;
            this.gbxAddMember.Text = "Üye Ekle";
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.Location = new System.Drawing.Point(949, 159);
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMemberAdd.TabIndex = 21;
            this.btnMemberAdd.Text = "Ekle";
            this.btnMemberAdd.UseVisualStyleBackColor = true;
            this.btnMemberAdd.Click += new System.EventHandler(this.btnMemberAdd_Click);
            // 
            // tbxBalanceAdd
            // 
            this.tbxBalanceAdd.Location = new System.Drawing.Point(133, 153);
            this.tbxBalanceAdd.Name = "tbxBalanceAdd";
            this.tbxBalanceAdd.Size = new System.Drawing.Size(247, 22);
            this.tbxBalanceAdd.TabIndex = 20;
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(667, 92);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(247, 24);
            this.cbxCategoryAdd.TabIndex = 19;
            // 
            // tbxMemberPhoneAdd
            // 
            this.tbxMemberPhoneAdd.Location = new System.Drawing.Point(133, 94);
            this.tbxMemberPhoneAdd.Name = "tbxMemberPhoneAdd";
            this.tbxMemberPhoneAdd.Size = new System.Drawing.Size(247, 22);
            this.tbxMemberPhoneAdd.TabIndex = 18;
            // 
            // tbxMemberSurnameAdd
            // 
            this.tbxMemberSurnameAdd.Location = new System.Drawing.Point(667, 36);
            this.tbxMemberSurnameAdd.Name = "tbxMemberSurnameAdd";
            this.tbxMemberSurnameAdd.Size = new System.Drawing.Size(247, 22);
            this.tbxMemberSurnameAdd.TabIndex = 17;
            // 
            // tbxMemberNameAdd
            // 
            this.tbxMemberNameAdd.Location = new System.Drawing.Point(133, 36);
            this.tbxMemberNameAdd.Name = "tbxMemberNameAdd";
            this.tbxMemberNameAdd.Size = new System.Drawing.Size(247, 22);
            this.tbxMemberNameAdd.TabIndex = 16;
            // 
            // lblBalanceAdd
            // 
            this.lblBalanceAdd.AutoSize = true;
            this.lblBalanceAdd.Location = new System.Drawing.Point(46, 159);
            this.lblBalanceAdd.Name = "lblBalanceAdd";
            this.lblBalanceAdd.Size = new System.Drawing.Size(55, 16);
            this.lblBalanceAdd.TabIndex = 15;
            this.lblBalanceAdd.Text = "Bakiye :";
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Location = new System.Drawing.Point(586, 101);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(63, 16);
            this.lblCategoryAdd.TabIndex = 14;
            this.lblCategoryAdd.Text = "Kategori :";
            // 
            // lblMemberPhoneAdd
            // 
            this.lblMemberPhoneAdd.AutoSize = true;
            this.lblMemberPhoneAdd.Location = new System.Drawing.Point(40, 102);
            this.lblMemberPhoneAdd.Name = "lblMemberPhoneAdd";
            this.lblMemberPhoneAdd.Size = new System.Drawing.Size(59, 16);
            this.lblMemberPhoneAdd.TabIndex = 13;
            this.lblMemberPhoneAdd.Text = "Telefon :";
            // 
            // lblSurnameAdd
            // 
            this.lblSurnameAdd.AutoSize = true;
            this.lblSurnameAdd.Location = new System.Drawing.Point(573, 43);
            this.lblSurnameAdd.Name = "lblSurnameAdd";
            this.lblSurnameAdd.Size = new System.Drawing.Size(84, 16);
            this.lblSurnameAdd.TabIndex = 12;
            this.lblSurnameAdd.Text = "Üye Soyadı :";
            // 
            // lblMemberNameAdd
            // 
            this.lblMemberNameAdd.AutoSize = true;
            this.lblMemberNameAdd.Location = new System.Drawing.Point(40, 43);
            this.lblMemberNameAdd.Name = "lblMemberNameAdd";
            this.lblMemberNameAdd.Size = new System.Drawing.Size(61, 16);
            this.lblMemberNameAdd.TabIndex = 11;
            this.lblMemberNameAdd.Text = "Üye Adı :";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(984, 101);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 80);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Üye Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.Location = new System.Drawing.Point(349, 30);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(117, 40);
            this.btnLoginAdmin.TabIndex = 14;
            this.btnLoginAdmin.Text = "Admin Sayfası";
            this.btnLoginAdmin.UseVisualStyleBackColor = true;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // gbxLogLogin
            // 
            this.gbxLogLogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxLogLogin.Controls.Add(this.tbxPasswordLogLogin);
            this.gbxLogLogin.Controls.Add(this.tbxUserNameLogLogin);
            this.gbxLogLogin.Controls.Add(this.lblPasswordLog);
            this.gbxLogLogin.Controls.Add(this.lblUserNameLog);
            this.gbxLogLogin.Controls.Add(this.btnLoginAdmin);
            this.gbxLogLogin.Location = new System.Drawing.Point(565, 14);
            this.gbxLogLogin.Name = "gbxLogLogin";
            this.gbxLogLogin.Size = new System.Drawing.Size(472, 83);
            this.gbxLogLogin.TabIndex = 15;
            this.gbxLogLogin.TabStop = false;
            // 
            // tbxPasswordLogLogin
            // 
            this.tbxPasswordLogLogin.Location = new System.Drawing.Point(98, 51);
            this.tbxPasswordLogLogin.Name = "tbxPasswordLogLogin";
            this.tbxPasswordLogLogin.PasswordChar = '*';
            this.tbxPasswordLogLogin.Size = new System.Drawing.Size(212, 22);
            this.tbxPasswordLogLogin.TabIndex = 18;
            // 
            // tbxUserNameLogLogin
            // 
            this.tbxUserNameLogLogin.Location = new System.Drawing.Point(98, 23);
            this.tbxUserNameLogLogin.Name = "tbxUserNameLogLogin";
            this.tbxUserNameLogLogin.Size = new System.Drawing.Size(212, 22);
            this.tbxUserNameLogLogin.TabIndex = 17;
            // 
            // lblPasswordLog
            // 
            this.lblPasswordLog.AutoSize = true;
            this.lblPasswordLog.Location = new System.Drawing.Point(7, 54);
            this.lblPasswordLog.Name = "lblPasswordLog";
            this.lblPasswordLog.Size = new System.Drawing.Size(34, 16);
            this.lblPasswordLog.TabIndex = 16;
            this.lblPasswordLog.Text = "Şifre";
            // 
            // lblUserNameLog
            // 
            this.lblUserNameLog.AutoSize = true;
            this.lblUserNameLog.Location = new System.Drawing.Point(7, 22);
            this.lblUserNameLog.Name = "lblUserNameLog";
            this.lblUserNameLog.Size = new System.Drawing.Size(85, 16);
            this.lblUserNameLog.TabIndex = 15;
            this.lblUserNameLog.Text = "Kullanıcı Adı :";
            // 
            // gbxCurrentWorker
            // 
            this.gbxCurrentWorker.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxCurrentWorker.Controls.Add(this.btnChangeCurrentWorker);
            this.gbxCurrentWorker.Controls.Add(this.tbxCurrentWorkerPassword);
            this.gbxCurrentWorker.Controls.Add(this.lblCurrentWorkerPassword);
            this.gbxCurrentWorker.Controls.Add(this.tbxCurrentWorker);
            this.gbxCurrentWorker.Controls.Add(this.lblCurrentWorker);
            this.gbxCurrentWorker.Location = new System.Drawing.Point(565, 103);
            this.gbxCurrentWorker.Name = "gbxCurrentWorker";
            this.gbxCurrentWorker.Size = new System.Drawing.Size(412, 78);
            this.gbxCurrentWorker.TabIndex = 16;
            this.gbxCurrentWorker.TabStop = false;
            // 
            // btnChangeCurrentWorker
            // 
            this.btnChangeCurrentWorker.Location = new System.Drawing.Point(315, 22);
            this.btnChangeCurrentWorker.Name = "btnChangeCurrentWorker";
            this.btnChangeCurrentWorker.Size = new System.Drawing.Size(75, 43);
            this.btnChangeCurrentWorker.TabIndex = 4;
            this.btnChangeCurrentWorker.Text = "Yetkili Değiştir";
            this.btnChangeCurrentWorker.UseVisualStyleBackColor = true;
            this.btnChangeCurrentWorker.Click += new System.EventHandler(this.btnChangeCurrentWorker_Click);
            // 
            // tbxCurrentWorkerPassword
            // 
            this.tbxCurrentWorkerPassword.Location = new System.Drawing.Point(83, 46);
            this.tbxCurrentWorkerPassword.Name = "tbxCurrentWorkerPassword";
            this.tbxCurrentWorkerPassword.Size = new System.Drawing.Size(208, 22);
            this.tbxCurrentWorkerPassword.TabIndex = 3;
            // 
            // lblCurrentWorkerPassword
            // 
            this.lblCurrentWorkerPassword.AutoSize = true;
            this.lblCurrentWorkerPassword.Location = new System.Drawing.Point(7, 49);
            this.lblCurrentWorkerPassword.Name = "lblCurrentWorkerPassword";
            this.lblCurrentWorkerPassword.Size = new System.Drawing.Size(53, 16);
            this.lblCurrentWorkerPassword.TabIndex = 2;
            this.lblCurrentWorkerPassword.Text = "Parola :";
            // 
            // tbxCurrentWorker
            // 
            this.tbxCurrentWorker.Location = new System.Drawing.Point(83, 16);
            this.tbxCurrentWorker.Name = "tbxCurrentWorker";
            this.tbxCurrentWorker.Size = new System.Drawing.Size(208, 22);
            this.tbxCurrentWorker.TabIndex = 1;
            // 
            // lblCurrentWorker
            // 
            this.lblCurrentWorker.AutoSize = true;
            this.lblCurrentWorker.Location = new System.Drawing.Point(7, 22);
            this.lblCurrentWorker.Name = "lblCurrentWorker";
            this.lblCurrentWorker.Size = new System.Drawing.Size(49, 16);
            this.lblCurrentWorker.TabIndex = 0;
            this.lblCurrentWorker.Text = "Yetkili :";
            // 
            // gbxUpdateMember
            // 
            this.gbxUpdateMember.Controls.Add(this.tbxMemberMailUpdate);
            this.gbxUpdateMember.Controls.Add(this.label2);
            this.gbxUpdateMember.Controls.Add(this.btnMemberUpdate);
            this.gbxUpdateMember.Controls.Add(this.tbxBalanceUpdate);
            this.gbxUpdateMember.Controls.Add(this.cbxCategoryUpdate);
            this.gbxUpdateMember.Controls.Add(this.tbxMemberPhoneUpdate);
            this.gbxUpdateMember.Controls.Add(this.tbxMemberSurnameUpdate);
            this.gbxUpdateMember.Controls.Add(this.tbxMemberNameUpdate);
            this.gbxUpdateMember.Controls.Add(this.lblBalanceUpdate);
            this.gbxUpdateMember.Controls.Add(this.lblCategoryUpdate);
            this.gbxUpdateMember.Controls.Add(this.lblMemberPhoneUpdate);
            this.gbxUpdateMember.Controls.Add(this.lblMemberSurnameUpdate);
            this.gbxUpdateMember.Controls.Add(this.lblMemberNameUpdate);
            this.gbxUpdateMember.Location = new System.Drawing.Point(13, 680);
            this.gbxUpdateMember.Margin = new System.Windows.Forms.Padding(4);
            this.gbxUpdateMember.Name = "gbxUpdateMember";
            this.gbxUpdateMember.Padding = new System.Windows.Forms.Padding(4);
            this.gbxUpdateMember.Size = new System.Drawing.Size(1067, 227);
            this.gbxUpdateMember.TabIndex = 21;
            this.gbxUpdateMember.TabStop = false;
            this.gbxUpdateMember.Text = "Üye Güncelle";
            // 
            // btnMemberUpdate
            // 
            this.btnMemberUpdate.Location = new System.Drawing.Point(949, 153);
            this.btnMemberUpdate.Name = "btnMemberUpdate";
            this.btnMemberUpdate.Size = new System.Drawing.Size(85, 23);
            this.btnMemberUpdate.TabIndex = 21;
            this.btnMemberUpdate.Text = "Güncelle";
            this.btnMemberUpdate.UseVisualStyleBackColor = true;
            this.btnMemberUpdate.Click += new System.EventHandler(this.btnMemberUpdate_Click);
            // 
            // tbxBalanceUpdate
            // 
            this.tbxBalanceUpdate.Location = new System.Drawing.Point(133, 153);
            this.tbxBalanceUpdate.Name = "tbxBalanceUpdate";
            this.tbxBalanceUpdate.Size = new System.Drawing.Size(247, 22);
            this.tbxBalanceUpdate.TabIndex = 20;
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(667, 92);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(247, 24);
            this.cbxCategoryUpdate.TabIndex = 19;
            // 
            // tbxMemberPhoneUpdate
            // 
            this.tbxMemberPhoneUpdate.Location = new System.Drawing.Point(133, 94);
            this.tbxMemberPhoneUpdate.Name = "tbxMemberPhoneUpdate";
            this.tbxMemberPhoneUpdate.Size = new System.Drawing.Size(247, 22);
            this.tbxMemberPhoneUpdate.TabIndex = 18;
            // 
            // tbxMemberSurnameUpdate
            // 
            this.tbxMemberSurnameUpdate.Location = new System.Drawing.Point(667, 36);
            this.tbxMemberSurnameUpdate.Name = "tbxMemberSurnameUpdate";
            this.tbxMemberSurnameUpdate.Size = new System.Drawing.Size(247, 22);
            this.tbxMemberSurnameUpdate.TabIndex = 17;
            // 
            // tbxMemberNameUpdate
            // 
            this.tbxMemberNameUpdate.Location = new System.Drawing.Point(133, 36);
            this.tbxMemberNameUpdate.Name = "tbxMemberNameUpdate";
            this.tbxMemberNameUpdate.Size = new System.Drawing.Size(247, 22);
            this.tbxMemberNameUpdate.TabIndex = 16;
            // 
            // lblBalanceUpdate
            // 
            this.lblBalanceUpdate.AutoSize = true;
            this.lblBalanceUpdate.Location = new System.Drawing.Point(46, 159);
            this.lblBalanceUpdate.Name = "lblBalanceUpdate";
            this.lblBalanceUpdate.Size = new System.Drawing.Size(55, 16);
            this.lblBalanceUpdate.TabIndex = 15;
            this.lblBalanceUpdate.Text = "Bakiye :";
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(586, 101);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(63, 16);
            this.lblCategoryUpdate.TabIndex = 14;
            this.lblCategoryUpdate.Text = "Kategori :";
            // 
            // lblMemberPhoneUpdate
            // 
            this.lblMemberPhoneUpdate.AutoSize = true;
            this.lblMemberPhoneUpdate.Location = new System.Drawing.Point(40, 102);
            this.lblMemberPhoneUpdate.Name = "lblMemberPhoneUpdate";
            this.lblMemberPhoneUpdate.Size = new System.Drawing.Size(59, 16);
            this.lblMemberPhoneUpdate.TabIndex = 13;
            this.lblMemberPhoneUpdate.Text = "Telefon :";
            // 
            // lblMemberSurnameUpdate
            // 
            this.lblMemberSurnameUpdate.AutoSize = true;
            this.lblMemberSurnameUpdate.Location = new System.Drawing.Point(573, 43);
            this.lblMemberSurnameUpdate.Name = "lblMemberSurnameUpdate";
            this.lblMemberSurnameUpdate.Size = new System.Drawing.Size(84, 16);
            this.lblMemberSurnameUpdate.TabIndex = 12;
            this.lblMemberSurnameUpdate.Text = "Üye Soyadı :";
            // 
            // lblMemberNameUpdate
            // 
            this.lblMemberNameUpdate.AutoSize = true;
            this.lblMemberNameUpdate.Location = new System.Drawing.Point(40, 43);
            this.lblMemberNameUpdate.Name = "lblMemberNameUpdate";
            this.lblMemberNameUpdate.Size = new System.Drawing.Size(61, 16);
            this.lblMemberNameUpdate.TabIndex = 11;
            this.lblMemberNameUpdate.Text = "Üye Adı :";
            // 
            // tbxDeductAccountFromBalance
            // 
            this.tbxDeductAccountFromBalance.Location = new System.Drawing.Point(14, 386);
            this.tbxDeductAccountFromBalance.Multiline = true;
            this.tbxDeductAccountFromBalance.Name = "tbxDeductAccountFromBalance";
            this.tbxDeductAccountFromBalance.Size = new System.Drawing.Size(568, 40);
            this.tbxDeductAccountFromBalance.TabIndex = 23;
            // 
            // btnDeductAccountFromBalance
            // 
            this.btnDeductAccountFromBalance.Location = new System.Drawing.Point(589, 386);
            this.btnDeductAccountFromBalance.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeductAccountFromBalance.Name = "btnDeductAccountFromBalance";
            this.btnDeductAccountFromBalance.Size = new System.Drawing.Size(491, 40);
            this.btnDeductAccountFromBalance.TabIndex = 22;
            this.btnDeductAccountFromBalance.Text = "Hesabı Bakiyeden Düşür";
            this.btnDeductAccountFromBalance.UseVisualStyleBackColor = true;
            this.btnDeductAccountFromBalance.Click += new System.EventHandler(this.btnDeductAccountFromBalance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mail :";
            // 
            // tbxMemberMailAdd
            // 
            this.tbxMemberMailAdd.Location = new System.Drawing.Point(667, 162);
            this.tbxMemberMailAdd.Name = "tbxMemberMailAdd";
            this.tbxMemberMailAdd.Size = new System.Drawing.Size(247, 22);
            this.tbxMemberMailAdd.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mail :";
            // 
            // tbxMemberMailUpdate
            // 
            this.tbxMemberMailUpdate.Location = new System.Drawing.Point(667, 160);
            this.tbxMemberMailUpdate.Name = "tbxMemberMailUpdate";
            this.tbxMemberMailUpdate.Size = new System.Drawing.Size(247, 22);
            this.tbxMemberMailUpdate.TabIndex = 23;
            // 
            // AlisPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1451, 1047);
            this.Controls.Add(this.tbxDeductAccountFromBalance);
            this.Controls.Add(this.btnDeductAccountFromBalance);
            this.Controls.Add(this.gbxUpdateMember);
            this.Controls.Add(this.gbxCurrentWorker);
            this.Controls.Add(this.gbxLogLogin);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxAddMember);
            this.Controls.Add(this.gbxSearchByMemberName);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.gbxGetByCategoryName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AlisPark";
            this.Text = "Üye İşlemleri";
            this.Load += new System.EventHandler(this.AlisPark_Load);
            this.gbxGetByCategoryName.ResumeLayout(false);
            this.gbxGetByCategoryName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.gbxSearchByMemberName.ResumeLayout(false);
            this.gbxSearchByMemberName.PerformLayout();
            this.gbxAddMember.ResumeLayout(false);
            this.gbxAddMember.PerformLayout();
            this.gbxLogLogin.ResumeLayout(false);
            this.gbxLogLogin.PerformLayout();
            this.gbxCurrentWorker.ResumeLayout(false);
            this.gbxCurrentWorker.PerformLayout();
            this.gbxUpdateMember.ResumeLayout(false);
            this.gbxUpdateMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGetByCategoryName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.GroupBox gbxSearchByMemberName;
        private System.Windows.Forms.TextBox tbxMemberNameSearch;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.GroupBox gbxAddMember;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.GroupBox gbxLogLogin;
        private System.Windows.Forms.TextBox tbxPasswordLogLogin;
        private System.Windows.Forms.TextBox tbxUserNameLogLogin;
        private System.Windows.Forms.Label lblPasswordLog;
        private System.Windows.Forms.Label lblUserNameLog;
        private System.Windows.Forms.GroupBox gbxCurrentWorker;
        private System.Windows.Forms.Label lblCurrentWorker;
        private System.Windows.Forms.TextBox tbxMemberNameAdd;
        private System.Windows.Forms.Label lblBalanceAdd;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.Label lblMemberPhoneAdd;
        private System.Windows.Forms.Label lblSurnameAdd;
        private System.Windows.Forms.Label lblMemberNameAdd;
        private System.Windows.Forms.TextBox tbxBalanceAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.TextBox tbxMemberPhoneAdd;
        private System.Windows.Forms.TextBox tbxMemberSurnameAdd;
        private System.Windows.Forms.GroupBox gbxUpdateMember;
        private System.Windows.Forms.TextBox tbxBalanceUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private System.Windows.Forms.TextBox tbxMemberPhoneUpdate;
        private System.Windows.Forms.TextBox tbxMemberSurnameUpdate;
        private System.Windows.Forms.TextBox tbxMemberNameUpdate;
        private System.Windows.Forms.Label lblBalanceUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.Label lblMemberPhoneUpdate;
        private System.Windows.Forms.Label lblMemberSurnameUpdate;
        private System.Windows.Forms.Label lblMemberNameUpdate;
        private System.Windows.Forms.Button btnMemberAdd;
        private System.Windows.Forms.Button btnMemberUpdate;
        private System.Windows.Forms.TextBox tbxCurrentWorker;
        private System.Windows.Forms.TextBox tbxCurrentWorkerPassword;
        private System.Windows.Forms.Label lblCurrentWorkerPassword;
        private System.Windows.Forms.Button btnChangeCurrentWorker;
        private System.Windows.Forms.TextBox tbxDeductAccountFromBalance;
        private System.Windows.Forms.Button btnDeductAccountFromBalance;
        private System.Windows.Forms.TextBox tbxMemberMailAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMemberMailUpdate;
        private System.Windows.Forms.Label label2;
    }
}