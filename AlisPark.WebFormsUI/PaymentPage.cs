﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
//using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using AlisPark.Business.Abstract;
using AlisPark.Business.DependencyRevolvers.Ninject;
using AlisPark.DataAccess.Abstract;
using AlisPark.DataAccess.Concrete;
using AlisPark.Entities.Concrete;

namespace AlisPark.WebFormsUI
{
    public partial class PaymentPage : Form
    {
        public int tableId { get; set; }
        ITableDal _tableDal;
        private ITableEventDal _tableEventDal;
        public BindingSource bindingSource;
        private int doubleClickedTableId;
        public PaymentPage(int consTableId)
        {
            InitializeComponent();
            _tableService = InstanceFactory.GetInstance<ITableService>();
            _tableDal = InstanceFactory.GetInstance<ITableDal>();
            _tableEventDal = InstanceFactory.GetInstance<ITableEventDal>();

            doubleClickedTableId = consTableId;
            masaIdLabel.Text = doubleClickedTableId.ToString();
        }

        private ITableService _tableService;

        bool virgulClicked = false;
        private void AddDigit(int number)
        {
            if (!virgulClicked)
                fiyat1.Text = number.ToString() + fiyat1.Text;
            else
                fiyat1.Text = fiyat1.Text + number.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddDigit(1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddDigit(2);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AddDigit(3);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AddDigit(4);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AddDigit(5);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            AddDigit(6);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            AddDigit(7);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            AddDigit(8);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            AddDigit(9);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            AddDigit(0);
        }



        private void button26_Click(object sender, EventArgs e) // virgül
        {
            if (virgulClicked)
                virgulClicked = false;
            else
                virgulClicked = true;

            if (fiyat1.Text == null)
            {
                fiyat1.Text = ",";
            }
            else
            {
                if(virgulClicked)
                    fiyat1.Text += ",";
                else 
                    fiyat1.Text.Insert(0, ",");
            }

        }

        private void button24_Click(object sender, EventArgs e) // silme tuşu
        {
            if(fiyat1.Text == ",")
            {
                fiyat1.Text = "";
                return;
            }
            string[] sep = fiyat1.Text.Split(',');
            if (virgulClicked == true)
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
            string newNum = "";

            if (sep[1] == null)
            {
                newNum = sep[0] + ",00";
            }
            else
            {
                newNum = sep[0] + "," + sep[1];
            }

            fiyat1.Text = newNum;
        }

        private string RemoveOneDigit(string num)
        {
            string truncatedStr = "";
            if (num.Length == 0)
                return "";
            if (virgulClicked)
                truncatedStr = num.Substring(1); // TRY CATCH KOYULACAK
            else
                truncatedStr = num.Remove(num.Length - 1); // TRY CATCH KOYULACAK
            return truncatedStr;
        }

        //private void button14_Click(object sender, EventArgs e) // Order Panel Button
        //{
        //    OrderWindow orderPanel = new OrderWindow(table, bindingSource);
        //    orderPanel.Owner = this;
        //    orderPanel.Show();
        //}

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
