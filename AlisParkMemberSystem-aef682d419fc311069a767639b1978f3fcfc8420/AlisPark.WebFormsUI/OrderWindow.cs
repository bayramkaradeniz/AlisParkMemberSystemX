using AlisPark.Business.Abstract;
using AlisPark.Business.DependencyRevolvers.Ninject;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;
using AlisPark.DataAccess.Abstract;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlisPark.WebFormsUI
{
    public partial class OrderWindow : Form
    {
        string oName;
        int oAmount;
        decimal oPrice;
        BindingSource bSource;

        private IProductService _productService;
        private IOrderService _orderService;
        Table table;

      //  public event Action ReloadMasaPanel;
        public OrderWindow(Table tab, BindingSource bindingSource)
        {
            InitializeComponent();
            
            _productService = InstanceFactory.GetInstance<IProductService>();
            _orderService = InstanceFactory.GetInstance<IOrderService>();

            bSource = bindingSource;
            table = tab;

        }
        private void OrderWindow_Load(object sender, EventArgs e)
        {
            LoadProducts();
            
        }
        private void LoadProducts()
        {
            var products = _productService.GetAll();
            Debug.WriteLine(products);
            foreach(Product product in products)
            {
                RenderProduct(product.ProductName, product.StockAmount, product.UnitPrice);
            }   
        }

        private void AddToDgv(string productName, int productAmount, decimal productPrice)
        {
            var products = _productService.GetAll();
            DataGridViewRow row = (DataGridViewRow)this.dgvProductList.Rows[0].Clone();
            row.Cells[0].Value = productName;

            if (row.Cells[1].Value == null) 
                row.Cells[1].Value = (0 + productAmount);
            else            
                row.Cells[1].Value = ((int)row.Cells[1].Value + productAmount);

            decimal productAmountDecimal = Convert.ToDecimal(productAmount);

            if (row.Cells[2].Value == null)
                row.Cells[2].Value = 0.0m + (productAmountDecimal * productPrice);
            else
                row.Cells[2].Value = (decimal)row.Cells[2].Value + (productAmountDecimal * productPrice);
            
            dgvProductList.Rows.Add(row);
            dgvProductList.DataSource = ((DataRowView)dgvProductList.Rows[0].DataBoundItem).DataView.Table;
            bSource.DataSource = dgvProductList.DataSource;
        }

        public void RenderProduct(string pName = " ", int stockAmount = 0, decimal pPrice = 0.0m) // Load products into screen
        {
            System.Windows.Forms.Panel panel1 = new System.Windows.Forms.Panel();
            System.Windows.Forms.Button button3 = new System.Windows.Forms.Button();
            // 
            // panel1
            //  
            //panel1.Location = new System.Drawing.Point(3, 3);
            //panel1.Name = "panel1";
            //panel1.Size = new System.Drawing.Size(135, 53);
            //panel1.TabIndex = 0;
            ////// 
            ////// label1
            ////// 
            ////label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            ////label1.AutoSize = true;
            ////label1.Location = new System.Drawing.Point(27, 21);
            ////label1.Name = "label1";
            ////label1.Size = new System.Drawing.Size(70, 13);
            ////label1.TabIndex = 0;
            ////label1.Text = productName;

            //stockInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            //stockInfo.AutoSize = true;
            //stockInfo.Location = new System.Drawing.Point(panel1.Width/2, panel1.Height/2);
            //stockInfo.Name = "stockInfo";
            //stockInfo.Size = new System.Drawing.Size(70, 13);
            //stockInfo.TabIndex = 0;
            //stockInfo.Text = "5 kaldı";

            //// 
            //// panel1
            //// 
            //panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            //panel1.Controls.Add(this.productName);
            //panel1.Location = new System.Drawing.Point(3, 3);
            //panel1.Name = "panel1";
            //panel1.Size = new System.Drawing.Size(200, 100);
            //panel1.TabIndex = 0;
            //// 
            //// productName
            //// 
            //productName.AutoSize = true;
            //productName.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //productName.Location = new System.Drawing.Point(64, 48);
            //productName.Name = "productName";
            //productName.Size = new System.Drawing.Size(72, 30);
            //productName.TabIndex = 0;
            //productName.Text = pName;


            //panel1.PerformLayout();

            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(200, 100);
            panel1.TabIndex = 0;

            // 
            // button3
            // 

            button3.BackColor = System.Drawing.Color.LimeGreen;
            button3.ForeColor = System.Drawing.Color.White;
            button3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.Location = new System.Drawing.Point(-3, -3);
            button3.Name = pName;
            button3.Size = new System.Drawing.Size(202, 102);
            button3.TabIndex = 0;
            button3.Text = pName + "\nFiyat: " + pPrice + "\nStok miktarı: " + stockAmount;
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(AddOrder);
            // 
            // panel1
            // 

            panel1.Controls.Add(button3);

            flowLayoutPanel1.Controls.Add(panel1);
        }

        private void button2_Click(object sender, EventArgs e) // Send Order Button
        {
            // Read entire DGV
            // Turn dgv rows into Order Entity - Don't maybe
            // Add them to database as reading continue...
            ITableDal tableDal = InstanceFactory.GetInstance<ITableDal>();
            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                string dgvPName = (string)row.Cells[0].Value;
                int dgvPAmount = Convert.ToInt32(row.Cells[1].Value);
                decimal dgvPPrice = Convert.ToDecimal(row.Cells[2].Value);

                Order order = new Order();
                order.OrderName = dgvPName;
                order.OrderAmount = dgvPAmount;
                order.OrderDate = DateTime.Now;
                order.OrderPrice = dgvPPrice * Convert.ToDecimal(oAmount);
                order.Delivered = false;
                order.Table = tableDal.Get(t => t.Id == table.Id);
                
                _orderService.Add(order);
            }



            //    PopulateDataGridView();
            dgvProductList.Rows.Clear();
            // Force Refresh MasaPanel.cs
            this.Owner.Refresh();
        }

        private void AddOrder(object sender, EventArgs e)
        {
            //string dgvPName = (string)dgvProductList.Rows[0].Cells["Ürün"].Value;
            //int dgvPAmount = Convert.ToInt32(dgvProductList.Rows[0].Cells["Adet"].Value);
            //decimal dgvPPrice = Convert.ToDecimal(dgvProductList.Rows[0].Cells["Fiyat"].Value);

            //Ask how much?

            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            string input = Interaction.InputBox(clickedButton.Name + " ürünün adedi:", "Adet", "1", 500, 500);

            // check input
            int num;
            if (!int.TryParse(input, out num))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz."); 
            }


            List<Product> product = _productService.GetProductsByProductName(clickedButton.Name);
            if (num > product[0].StockAmount)
            {
                MessageBox.Show("Lütfen mevcut stok adedinden (" + product[0].StockAmount + ") düşük bir adet giriniz.");
            }

             AddToDgv(clickedButton.Name, num, product[0].StockAmount);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
             _productService.GetProductsByProductName(searchBox.Text);
        }

        
    }
}
