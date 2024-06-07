using AlisPark.Business.Abstract;
using AlisPark.Business.DependencyRevolvers.Ninject;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisPark.WebFormsUI
{
    public partial class MasaPanel : Form
    {
        private Panel buttonPanel = new Panel();
        DataGridView dataGridView1 = new System.Windows.Forms.DataGridView();

        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();
        Table table = new Table();
        BindingSource bindingSource;

        IOrderService _orderService;
        public MasaPanel(Table tab, BindingSource bSource)
        {
            InitializeComponent();

            _orderService = InstanceFactory.GetInstance<IOrderService>();
            table = tab;
            
            bindingSource = new BindingSource();
            InitDGV();
            SetupLayout();
            PopulateDataGridView();

            //   ChangePrice( "MASA " + ((TableButton)TableButton.ActiveForm).tableId.ToString() );
            ChangeTableText("MASA " + tab.Id);
            bindingSource = bSource;
        }

        public void ChangeOrdersDgv(object dataSource)
        {
            dataGridView1.DataSource = dataSource;
        }


        private void PopulateDgv()
        {
          //  _tableEventsService.LoadAll();
        }

        private void InitDGV()
        {
            this.Controls.Add(dataGridView1);
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 207);
            this.dataGridView1.TabIndex = 1;
            dataGridView1.DataSource = bindingSource.DataSource;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tarih";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adet";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ürün";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Toplam";
            this.Column4.Name = "Column4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }


        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 &&
                this.dataGridView1.SelectedRows[0].Index !=
                this.dataGridView1.Rows.Count - 1)
            {
                this.dataGridView1.Rows.RemoveAt(
                    this.dataGridView1.SelectedRows[0].Index);
            }
        }

        public void ChangeTableText(string title)
        {
            label3.Text = title;
        }
        private void SetupLayout()
        {
            this.Size = new Size(600, 500);

            // 
            // deleteRowButton
            // 
            this.deleteRowButton.BackColor = System.Drawing.Color.Red;
            this.deleteRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRowButton.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRowButton.ForeColor = System.Drawing.Color.White;
            this.deleteRowButton.Location = new System.Drawing.Point(20, 584);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(211, 59);
            this.deleteRowButton.TabIndex = 4;
            this.deleteRowButton.Text = "Ürün Ekle";
            this.deleteRowButton.UseVisualStyleBackColor = false;
            deleteRowButton.Click += new EventHandler(addNewRowButton_Click);

            // 
            // addNewRowButton
            // 
            this.addNewRowButton.BackColor = System.Drawing.Color.Red;
            this.addNewRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewRowButton.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewRowButton.ForeColor = System.Drawing.Color.White;
            this.addNewRowButton.Location = new System.Drawing.Point(246, 584);
            this.addNewRowButton.Name = "addNewRowButton";
            this.addNewRowButton.Size = new System.Drawing.Size(211, 59);
            this.addNewRowButton.TabIndex = 5;
            this.addNewRowButton.Text = "Ürün Sil";
            this.addNewRowButton.UseVisualStyleBackColor = false;
            deleteRowButton.Click += new EventHandler(deleteRowButton_Click);

            buttonPanel.Controls.Add(addNewRowButton);
            buttonPanel.Controls.Add(deleteRowButton);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;
            this.Controls.Add(this.buttonPanel);
        }

        private void SetupDataGridView()
        {
            dataGridView1.ColumnCount = 3;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Name = "dataGridView1";
            dataGridView1.Location = new Point(8, 8);
            dataGridView1.Size = new Size(500, 250);
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;


            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Dock = DockStyle.Fill;

            //songsDataGridView.CellFormatting += new
            //    DataGridViewCellFormattingEventHandler(
            //    songsDataGridView_CellFormatting);
        }
        public void PopulateDataGridView()
        {
            List<Order> orders = new List<Order>();
            orders = _orderService.GetOrdersByDelivered(); // get orders if they are not delivered yet

            foreach(Order order in orders)
            {
                AddToDgv(order.OrderName, order.OrderAmount, order.OrderPrice);
            }

            dataGridView1.Columns[0].DisplayIndex = 0;
            dataGridView1.Columns[1].DisplayIndex = 1;
            dataGridView1.Columns[2].DisplayIndex = 2;
           
        }

        private void AddToDgv(string productName, int productAmount, decimal productPrice)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = DateTime.Now;
            row.Cells[1].Value = productName;

            if (row.Cells[2].Value == null)
                row.Cells[2].Value = (0 + productAmount);
            else
                row.Cells[2].Value = ((int)row.Cells[2].Value + productAmount);

            decimal productAmountDecimal = Convert.ToDecimal(productAmount);

            if (row.Cells[3].Value == null)
                row.Cells[3].Value = 0.0m + (productAmountDecimal * productPrice);
            else
                row.Cells[3].Value = (decimal)row.Cells[2].Value + (productAmountDecimal * productPrice);

            dataGridView1.Rows.Add(row);
        }

        bool virgulClicked = false;

        private void AddDigit(int number)
        {
            if (!virgulClicked)
                fiyat1.Text = number.ToString() + fiyat1.Text;
            else
                fiyat1.Text = fiyat1.Text + number.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            AddDigit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDigit(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDigit(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDigit(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDigit(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDigit(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDigit(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddDigit(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddDigit(9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddDigit(0);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e) // virgül
        {
            if (virgulClicked)
                virgulClicked = false;
            else
                virgulClicked = true;

            if(fiyat1.Text == null)
            {
                fiyat1.Text = ",";
            }
        }

        private void button12_Click(object sender, EventArgs e) // silme tuşu
        {
            string[] sep = fiyat1.Text.Split(',');
            if(virgulClicked == true)
            {
                if (sep[1].Length == 0)
                {
                    virgulClicked = false;
                    RemoveOneDigit(sep[0]);
                }
                else
                    sep[1] = RemoveOneDigit(sep[1]); 
            }
            else
            {
                if (sep[0].Length == 0)
                {
                    virgulClicked = true;
                    RemoveOneDigit(sep[1]);
                }
                else
                    sep[0] = RemoveOneDigit(sep[0]);
            }

            string newNum = sep[0] + "," + sep[1];
            fiyat1.Text = newNum;
        }

        private string RemoveOneDigit(string num)
        {
            string truncatedStr = "";
            if (virgulClicked)
                truncatedStr = num.Substring(1); // TRY CATCH KOYULACAK
            else
                truncatedStr = num.Remove(num.Length - 1); // TRY CATCH KOYULACAK
            return truncatedStr;
        }

        private void button14_Click(object sender, EventArgs e) // Order Panel Button
        {
            OrderWindow orderPanel = new OrderWindow(table, bindingSource);
            orderPanel.Owner = this;
            orderPanel.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Load(object sender, PaintEventArgs e)
        {
            PopulateDataGridView();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
