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
        public BindingSource bindingSource;
        public TableButton()
        {
            InitializeComponent();
            _tableService = InstanceFactory.GetInstance<ITableService>();
            _tableDal = InstanceFactory.GetInstance<ITableDal>();
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
                    if (e.Button == MouseButtons.Left)
                    {
                        MessageBox.Show($"Left double-clicked on table {table.TableName}");
                    }
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
                    MasaPanel mp = new MasaPanel(thisTable, bindingSource);
                    mp.Owner = this;
                    mp.Show();
                    break;
                case "Süreli Masa Aç":
                    // Masa temizlemek için gereken işlemleri yap
                    break;
                case "Masayı Süreliye Çevir":
                    // Masa temizlemek için gereken işlemleri yap
                    break;
                default:
                    break;
            }
        }

        private void TableButton_Load(object sender, EventArgs e)
        {
            var list = GetTablesFromDatabase();
            DisplayTables(list);
        }
    }
}
