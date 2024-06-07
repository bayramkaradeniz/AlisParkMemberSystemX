﻿using System;
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

namespace AlisPark.WebFormsUI
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
            _tableService = InstanceFactory.GetInstance<ITableService>();
            _tableEventService = InstanceFactory.GetInstance<ITableEventService>();
        }
        private ITableService _tableService;
        private ITableEventService _tableEventService;
        private void Tables_Load(object sender, EventArgs e)
        {
            LoadTableEvents();
            LoadStartedTables();
            LoadTables();
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
            _tableService.CreateTable();
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                dataGridView4.DataSource = _tableEventService.GetByTableId(x);
            }
            else
            {
                dataGridView4.DataSource = _tableEventService.GetAll();
            }
        }
    }
}

