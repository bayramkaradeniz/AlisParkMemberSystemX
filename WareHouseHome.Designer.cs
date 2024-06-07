namespace AlisPark.WebFormsUI
{
    partial class WareHouseHome
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxGetByCategoryName = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxProductNameSearch = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.tbxStockAmountAdd = new System.Windows.Forms.TextBox();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxProductDescriptionAdd = new System.Windows.Forms.TextBox();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.lblBalanceAdd = new System.Windows.Forms.Label();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.lblMemberPhoneAdd = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblMemberNameAdd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeStock = new System.Windows.Forms.Button();
            this.tbxChangeStockStockAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxChangeStockProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChangeUnitPrice = new System.Windows.Forms.Button();
            this.tbxChangeUnitPriceUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxChangeUnitPriceProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowMails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbxGetByCategoryName.SuspendLayout();
            this.gbxAddProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category});
            this.dgvProducts.Location = new System.Drawing.Point(12, 92);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(938, 176);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // Category
            // 
            this.Category.Frozen = true;
            this.Category.HeaderText = "Column1";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Visible = false;
            // 
            // gbxGetByCategoryName
            // 
            this.gbxGetByCategoryName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxGetByCategoryName.Controls.Add(this.label6);
            this.gbxGetByCategoryName.Controls.Add(this.tbxProductNameSearch);
            this.gbxGetByCategoryName.Controls.Add(this.cbxCategory);
            this.gbxGetByCategoryName.Controls.Add(this.lblCategory);
            this.gbxGetByCategoryName.Location = new System.Drawing.Point(12, 11);
            this.gbxGetByCategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxGetByCategoryName.Name = "gbxGetByCategoryName";
            this.gbxGetByCategoryName.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.gbxGetByCategoryName.Size = new System.Drawing.Size(938, 76);
            this.gbxGetByCategoryName.TabIndex = 1;
            this.gbxGetByCategoryName.TabStop = false;
            this.gbxGetByCategoryName.Text = "Kategoriye Göre Arama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ürün Adı :";
            // 
            // tbxProductNameSearch
            // 
            this.tbxProductNameSearch.Location = new System.Drawing.Point(536, 22);
            this.tbxProductNameSearch.Name = "tbxProductNameSearch";
            this.tbxProductNameSearch.Size = new System.Drawing.Size(388, 22);
            this.tbxProductNameSearch.TabIndex = 2;
            this.tbxProductNameSearch.TextChanged += new System.EventHandler(this.tbxProductNameSearch_TextChanged);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(133, 22);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(168, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(41, 25);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(63, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori :";
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.btnProductAdd);
            this.gbxAddProduct.Controls.Add(this.tbxStockAmountAdd);
            this.gbxAddProduct.Controls.Add(this.cbxCategoryAdd);
            this.gbxAddProduct.Controls.Add(this.tbxUnitPriceAdd);
            this.gbxAddProduct.Controls.Add(this.tbxProductDescriptionAdd);
            this.gbxAddProduct.Controls.Add(this.tbxProductNameAdd);
            this.gbxAddProduct.Controls.Add(this.lblBalanceAdd);
            this.gbxAddProduct.Controls.Add(this.lblCategoryAdd);
            this.gbxAddProduct.Controls.Add(this.lblMemberPhoneAdd);
            this.gbxAddProduct.Controls.Add(this.lblProductDescription);
            this.gbxAddProduct.Controls.Add(this.lblMemberNameAdd);
            this.gbxAddProduct.Location = new System.Drawing.Point(13, 458);
            this.gbxAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAddProduct.Size = new System.Drawing.Size(938, 212);
            this.gbxAddProduct.TabIndex = 4;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Ürrün Ekle";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(829, 153);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductAdd.TabIndex = 21;
            this.btnProductAdd.Text = "Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // tbxStockAmountAdd
            // 
            this.tbxStockAmountAdd.Location = new System.Drawing.Point(133, 138);
            this.tbxStockAmountAdd.Name = "tbxStockAmountAdd";
            this.tbxStockAmountAdd.Size = new System.Drawing.Size(247, 22);
            this.tbxStockAmountAdd.TabIndex = 20;
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(667, 92);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(247, 24);
            this.cbxCategoryAdd.TabIndex = 19;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(133, 94);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(247, 22);
            this.tbxUnitPriceAdd.TabIndex = 18;
            // 
            // tbxProductDescriptionAdd
            // 
            this.tbxProductDescriptionAdd.Location = new System.Drawing.Point(667, 36);
            this.tbxProductDescriptionAdd.Name = "tbxProductDescriptionAdd";
            this.tbxProductDescriptionAdd.Size = new System.Drawing.Size(247, 22);
            this.tbxProductDescriptionAdd.TabIndex = 17;
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(133, 36);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(247, 22);
            this.tbxProductNameAdd.TabIndex = 16;
            // 
            // lblBalanceAdd
            // 
            this.lblBalanceAdd.AutoSize = true;
            this.lblBalanceAdd.Location = new System.Drawing.Point(46, 159);
            this.lblBalanceAdd.Name = "lblBalanceAdd";
            this.lblBalanceAdd.Size = new System.Drawing.Size(76, 16);
            this.lblBalanceAdd.TabIndex = 15;
            this.lblBalanceAdd.Text = "Stok Adedi:";
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
            this.lblMemberPhoneAdd.Size = new System.Drawing.Size(45, 16);
            this.lblMemberPhoneAdd.TabIndex = 13;
            this.lblMemberPhoneAdd.Text = "Fiyat  :";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(573, 43);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(69, 16);
            this.lblProductDescription.TabIndex = 12;
            this.lblProductDescription.Text = "Açıklama :";
            // 
            // lblMemberNameAdd
            // 
            this.lblMemberNameAdd.AutoSize = true;
            this.lblMemberNameAdd.Location = new System.Drawing.Point(40, 43);
            this.lblMemberNameAdd.Name = "lblMemberNameAdd";
            this.lblMemberNameAdd.Size = new System.Drawing.Size(64, 16);
            this.lblMemberNameAdd.TabIndex = 11;
            this.lblMemberNameAdd.Text = "Ürün Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeStock);
            this.groupBox1.Controls.Add(this.tbxChangeStockStockAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxChangeStockProductName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 98);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btnChangeStock
            // 
            this.btnChangeStock.Location = new System.Drawing.Point(332, 31);
            this.btnChangeStock.Name = "btnChangeStock";
            this.btnChangeStock.Size = new System.Drawing.Size(108, 61);
            this.btnChangeStock.TabIndex = 29;
            this.btnChangeStock.Text = "Change Stock";
            this.btnChangeStock.UseVisualStyleBackColor = true;
            this.btnChangeStock.Click += new System.EventHandler(this.btnChangeStock_Click);
            // 
            // tbxChangeStockStockAmount
            // 
            this.tbxChangeStockStockAmount.Location = new System.Drawing.Point(111, 74);
            this.tbxChangeStockStockAmount.Name = "tbxChangeStockStockAmount";
            this.tbxChangeStockStockAmount.Size = new System.Drawing.Size(215, 22);
            this.tbxChangeStockStockAmount.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock Amount : ";
            // 
            // tbxChangeStockProductName
            // 
            this.tbxChangeStockProductName.Location = new System.Drawing.Point(111, 35);
            this.tbxChangeStockProductName.Name = "tbxChangeStockProductName";
            this.tbxChangeStockProductName.Size = new System.Drawing.Size(215, 22);
            this.tbxChangeStockProductName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChangeUnitPrice);
            this.groupBox2.Controls.Add(this.tbxChangeUnitPriceUnitPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxChangeUnitPriceProductName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(471, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 112);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // btnChangeUnitPrice
            // 
            this.btnChangeUnitPrice.Location = new System.Drawing.Point(357, 32);
            this.btnChangeUnitPrice.Name = "btnChangeUnitPrice";
            this.btnChangeUnitPrice.Size = new System.Drawing.Size(108, 61);
            this.btnChangeUnitPrice.TabIndex = 30;
            this.btnChangeUnitPrice.Text = "Change UnitPrice";
            this.btnChangeUnitPrice.UseVisualStyleBackColor = true;
            this.btnChangeUnitPrice.Click += new System.EventHandler(this.btnChangeUnitPrice_Click);
            // 
            // tbxChangeUnitPriceUnitPrice
            // 
            this.tbxChangeUnitPriceUnitPrice.Location = new System.Drawing.Point(111, 74);
            this.tbxChangeUnitPriceUnitPrice.Name = "tbxChangeUnitPriceUnitPrice";
            this.tbxChangeUnitPriceUnitPrice.Size = new System.Drawing.Size(228, 22);
            this.tbxChangeUnitPriceUnitPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unit Price  : ";
            // 
            // tbxChangeUnitPriceProductName
            // 
            this.tbxChangeUnitPriceProductName.Location = new System.Drawing.Point(111, 35);
            this.tbxChangeUnitPriceProductName.Name = "tbxChangeUnitPriceProductName";
            this.tbxChangeUnitPriceProductName.Size = new System.Drawing.Size(228, 22);
            this.tbxChangeUnitPriceProductName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Product Name :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(22, 279);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(327, 61);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnShowMails
            // 
            this.btnShowMails.Location = new System.Drawing.Point(473, 286);
            this.btnShowMails.Name = "btnShowMails";
            this.btnShowMails.Size = new System.Drawing.Size(477, 47);
            this.btnShowMails.TabIndex = 28;
            this.btnShowMails.Text = "Mails";
            this.btnShowMails.UseVisualStyleBackColor = true;
            this.btnShowMails.Click += new System.EventHandler(this.btnShowMails_Click);
            // 
            // WareHouseHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1078, 688);
            this.Controls.Add(this.btnShowMails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.gbxGetByCategoryName);
            this.Controls.Add(this.dgvProducts);
            this.Name = "WareHouseHome";
            this.Text = "WareHouseHome";
            this.Load += new System.EventHandler(this.WareHouseHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbxGetByCategoryName.ResumeLayout(false);
            this.gbxGetByCategoryName.PerformLayout();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox gbxGetByCategoryName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox tbxStockAmountAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.TextBox tbxProductDescriptionAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Label lblBalanceAdd;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.Label lblMemberPhoneAdd;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblMemberNameAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxProductNameSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxChangeStockProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxChangeStockStockAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxChangeUnitPriceUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxChangeUnitPriceProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangeStock;
        private System.Windows.Forms.Button btnChangeUnitPrice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowMails;
    }
}