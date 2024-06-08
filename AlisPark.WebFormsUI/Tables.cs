using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlisPark.Business.Abstract;
using AlisPark.Business.DependencyRevolvers.Ninject;
using AlisPark.Entities.Concrete;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlisPark.WebFormsUI
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
            _tableService = InstanceFactory.GetInstance<ITableService>();
            _tableCategoryService = InstanceFactory.GetInstance<ITableCategoryService>();
            _tableEventService = InstanceFactory.GetInstance<ITableEventService>();
        }
        private ITableService _tableService;
        private ITableEventService _tableEventService;
        private ITableCategoryService _tableCategoryService;
        private void Tables_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadTableEvents();
            LoadStartedTables();
            LoadTables();
        }

        private void LoadCategories()
        {
            comboBox1.DataSource = _tableCategoryService.GetAll();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void LoadTableEvents()
        {
            dataGridView3.DataSource = _tableEventService.GetAll();
        }

        private void LoadStartedTables()
        {
            dataGridView2.DataSource = _tableService.GetStartedTables();
        }

        private void LoadTables()
        {
            dataGridView1.DataSource = _tableService.GetAll();
        }


        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string x = comboBox1.Text;;
            _tableService.CreateTable(x);
            LoadTables();
        }

        private void btnStartTable_Click(object sender, EventArgs e)
        {
            int tableId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

            _tableEventService.StartSession(new Table
            {
                Id = tableId,
            });
            _tableService.StartTable(new Table
            {
                Id = tableId,
            });

            LoadStartedTables();
            LoadTables(); 
            LoadTableEvents();
        }

        private void btnCloseSession_Click(object sender, EventArgs e)
        {
            var row = dataGridView2.CurrentRow;
            int Id = Convert.ToInt32(row.Cells[1].Value.ToString());
            _tableEventService.CloseSession(new Table
            {
                Id = Id,
            });
            _tableService.CloseTable(new Table
            {
                Id = Id
            });

            
            LoadTableEvents();
            LoadStartedTables();
            LoadTables();
            //ClosedTableEvent(Id);


        }

        //private void ClosedTableEvent(int Id)
        //{
        //    var lastClosedTable = _tableEventService.GetLatestTableEvent(Id);
        //    var table = _tableService.GetStartedTableWithId(Id);

        //    MessageBox.Show(
        //        $"Masa Id: {table.Id}\nMasa Adı: {table.TableName})\nToplam Dakika: {lastClosedTable.Duration}",
        //        "Masa Kapatıldı",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Information
        //    );


        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    int x = Convert.ToInt32(textBox1.Text);
        //    if (!String.IsNullOrEmpty(textBox1.Text))
        //    {
        //        dataGridView4.DataSource = _tableEventService.GetByTableId(x);
        //    }
        //    else
        //    {
        //        dataGridView4.DataSource = _tableEventService.GetAll();
        //    }
        //}

        private void btnTables_Click(object sender, EventArgs e)
        {
            int tableId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            _tableService.RemoveTable(tableId);

            LoadTables();
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            Form tta = new TableButton();
            tta.Show();
            this.Hide();
        }
    }
}

