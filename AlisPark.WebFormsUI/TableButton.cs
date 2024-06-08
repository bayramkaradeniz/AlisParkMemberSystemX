using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
//using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlisPark.Business.Abstract;
using AlisPark.Business.DependencyRevolvers.Ninject;
using AlisPark.DataAccess.Abstract;
using AlisPark.DataAccess.Concrete;
using AlisPark.Entities.Concrete;

namespace AlisPark.WebFormsUI
{
    public partial class TableButton : Form
    {
        public int tableId { get; set; }
        ITableDal _tableDal;
        private ITableEventDal _tableEventDal;
        public BindingSource bindingSource;
        public TableButton()
        {
            InitializeComponent();
            _tableService = InstanceFactory.GetInstance<ITableService>();
            _tableDal = InstanceFactory.GetInstance<ITableDal>();
            _tableEventDal = InstanceFactory.GetInstance<ITableEventDal>();
        }

        private ITableService _tableService;

        public List<Table> GetTablesFromDatabase()
        {
            using (var context = new AlisParkContext())
            {
                return context.Tables.ToList();
            }
        }

        public void DisplayTables(List<Table> tables)
        {
            flpTable.Controls.Clear();

            foreach (var table in tables)
            {
                var label = new Label()
                {
                    Text = table.TableName,
                    BackColor = table.IsOccupied ? Color.IndianRed : Color.Green,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Size = new Size(80, 80),
                    Margin = new Padding(5),                    
                    Tag = table.Id,
                    BorderStyle= BorderStyle.Fixed3D,
                   
                };


                var contextMenu = new ContextMenu();
                contextMenu.MenuItems.Add(new MenuItem("Sipariş Al", TableMenuItem_Click));
                contextMenu.MenuItems.Add(new MenuItem("Masayı Taşı", TableMenuItem_Click));
                contextMenu.MenuItems.Add(new MenuItem("Masa Detayı", TableMenuItem_Click));
                contextMenu.MenuItems.Add(new MenuItem("Süreli Masa Aç", TableMenuItem_Click));
                contextMenu.MenuItems.Add(new MenuItem("Masayı Süreliye Çevir", TableMenuItem_Click));


                label.MouseDoubleClick += (sender, e) =>
                {
                    // Buraya gerek yok artık
                    //if (e.Button == MouseButtons.Left)
                    //{
                    //    MessageBox.Show($"Left double-clicked on table {table.TableName}");
                    //}

                    PaymentPage pg = new PaymentPage(table.Id);
                    pg.Show();


                };


                label.MouseClick += (sender, e) =>
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        label.ContextMenu.Show(label, new Point(e.X, e.Y));
                    }
                };

                label.ContextMenu = contextMenu;

                flpTable.Controls.Add(label);
            }
        }
        
        private void TableMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var action = menuItem.Text;

            var labelOne = (Label)menuItem.GetContextMenu().SourceControl;
            tableId = (int)labelOne.Tag;
            var IsOccupied = labelOne.BackColor;

            var dataSource = new DataGridView().DataSource;
            Table thisTable = new Table();
            thisTable = _tableDal.Get(t => t.Id == tableId);
            // Seçilen eyleme göre işlem yap
            switch (action)
            {
                case "Sipariş Al":
                    bindingSource = new BindingSource();
                    OrderWindow orderPanel = new OrderWindow(thisTable, bindingSource);
                    orderPanel.Owner = this;
                    orderPanel.Show();
                    break;
                case "Masayı Taşı":

                    if (labelOne.BackColor == Color.IndianRed)
                    {
                        var form = new Form();
                        form.Text = "Hedef Masayı Girin";
                        form.Size = new Size(250, 150);
                        form.FormBorderStyle = FormBorderStyle.FixedDialog;
                        form.MaximizeBox = false;
                        form.MinimizeBox = false;

                        var label = new Label();
                        label.Text = "Hedef Masayı Girin:";
                        label.Location = new Point(30, 30);
                        label.AutoSize = true;

                        var textBox = new TextBox();
                        textBox.Location = new Point(140, 20);
                        textBox.Size = new Size(120, 30);

                        var buttonOk = new Button();
                        buttonOk.Text = "Tamam";
                        buttonOk.DialogResult = DialogResult.OK;
                        buttonOk.Location = new Point(120, 50);

                        form.Controls.Add(label);
                        form.Controls.Add(textBox);
                        form.Controls.Add(buttonOk);

                        form.AcceptButton = buttonOk;

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            int targetTag;

                            if (!int.TryParse(textBox.Text, out targetTag))
                            {
                                MessageBox.Show("Geçerli bir masa numarası girin.");
                                return;
                            }
                            // Önce AcceptButton'u kontrol et
                            if (targetTag == Convert.ToInt32(labelOne.Tag))
                            {
                                MessageBox.Show("Same");
                            }
                            else
                            {
                                var list = GetTablesFromDatabase();

                                if (list.Any(table => table.Id == targetTag))
                                {
                                    MessageBox.Show("Müsait");
                                }
                                else
                                {
                                    MessageBox.Show("Nope");
                                }
                            }


                        }

                    }
                    else
                    {
                        MessageBox.Show("Empty");
                    }
                   
                    
                    break;
                case "Masa Detayı":
                    bindingSource = new BindingSource();
                 //   MasaPanel mp = new MasaPanel(thisTable, bindingSource);
                    MasaPanelInit(thisTable, bindingSource);
                    break;
                case "Süreli Masa Aç":
                    // Masa temizlemek için gereken işlemleri yap
                    break;
                case "Masayı Kapat":
                    UpdateTableEvent(tableId);
                    MessageBox.Show($"Masa {thisTable.TableName} kapatıldı.");
                    break;
                default:
                    break;
            }
        }

        private void UpdateTableEvent(int tableId)
        {
            _tableEventDal.CloseSession(tableId);
        }

        private void TableButton_Load(object sender, EventArgs e)
        {
            var list = GetTablesFromDatabase();
            DisplayTables(list);
        }
    

        private Panel buttonPanel = new Panel();
        DataGridView dataGridView1 = new System.Windows.Forms.DataGridView();

        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();
        Table table = new Table();

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;

        IOrderService _orderService;
        public void MasaPanelInit(Table tab, BindingSource bSource)
        {
            InitializeComponent();

            _orderService = InstanceFactory.GetInstance<IOrderService>();
            table = tab;

            bindingSource = new BindingSource();
            InitDGV();
            SetupLayout();
            PopulateDataGridView();

            //   ChangePrice( "MASA " + ((TableButton)TableButton.ActiveForm).tableId.ToString() );
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 218);
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

            foreach (Order order in orders)
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


     

        //private void button14_Click(object sender, EventArgs e) // Order Panel Button
        //{
        //    OrderWindow orderPanel = new OrderWindow(table, bindingSource);
        //    orderPanel.Owner = this;
        //    orderPanel.Show();
        //}

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tables tab = new Tables();
            tab.Show();
        }
    }
}
