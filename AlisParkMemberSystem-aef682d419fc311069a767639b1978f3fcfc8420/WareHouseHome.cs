using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlisPark.Business.Abstract;
using AlisPark.Business.DependencyRevolvers.Ninject;
using AlisPark.DataAccess.Concrete;
using AlisPark.Entities.Concrete;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AlisPark.WebFormsUI
{
    public partial class WareHouseHome : Form
    {
        public WareHouseHome()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _logEntryService = InstanceFactory.GetInstance<ILogEntryService>();
            _companyService = InstanceFactory.GetInstance<ICompanyService>();
            _mailSenderService = InstanceFactory.GetInstance<IMailSenderService>();

        }
        private ILogEntryService _logEntryService;
        private IProductService _productService;
        private ICategoryService _categoryService;
        private ICompanyService _companyService;
        private IMailSenderService _mailSenderService;


        private void WareHouseHome_Load(object sender, EventArgs e)
        {
            
            LoadProducts();
            LoadCategories();
            CheckStock();
        }

        private void CheckStock()
        {
            _productService.ChangeStock();
        }

        private void LoadCategories()
        {


            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";

        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = _productService.GetAll();
            dgvProducts.Columns[1].Visible = false;
            dgvProducts.Columns[3].Visible = false;
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProducts.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }
        }

        private void tbxProductNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductNameSearch.Text))
            {
                dgvProducts.DataSource = _productService.GetProductsByProductName(tbxProductNameSearch.Text);
            }
            else
            {
                LoadProducts();
            }
        }



        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvProducts.CurrentRow;
            

            tbxChangeStockProductName.Text = row.Cells[2].Value.ToString();
            tbxChangeStockStockAmount.Text = row.Cells[4].Value.ToString();
            tbxChangeUnitPriceProductName.Text = row.Cells[2].Value.ToString();
            tbxChangeUnitPriceUnitPrice.Text = row.Cells[3].Value.ToString();
        }

        

        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamayı Kapamak istediğinize emin misiniz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }

        

        //private void btnProductAdd_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //Add Product
        //        _productService.Add(new Product
        //        {
        //            CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
        //            ProductName = tbxProductNameAdd.Text,
        //            ProductDescription = tbxProductDescriptionAdd.Text,
        //            StockAmount = Convert.ToInt32(tbxStockAmountAdd.Text),
        //            UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
        //        });

        //        //Logging
        //        _logEntryService.LogForAdd(new Product
        //        {
        //            ProductName = tbxProductNameAdd.Text
        //        });
        //        var lastLog = _logEntryService.GetAll().OrderByDescending(s => s.Id)
        //                .FirstOrDefault().Description.ToString();
        //        string AdminMail = _companyService.GetAdminMail().ToString();
        //        //Sending Mail
        //        _mailSenderService.SendMailAsync(AdminMail, lastLog);
        //        //Recording Mail
        //        _mailSenderService.LogMailForAdd(new Mail
        //        {
        //            ReceiverMail = AdminMail,
        //            MailBody = lastLog
        //        });
        //        LoadProducts();
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message);
        //    }
        //}

        

        //private void btnChangeUnitPrice_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var row = dgvProducts.CurrentRow;
        //        var des = row.Cells[3].Value.ToString();
        //        var name = row.Cells[2].Value.ToString();
        //        var stock = row.Cells[5].Value.ToString();
        //        var catId = row.Cells[6].Value.ToString();
        //        String OldPrice = dgvProducts.CurrentRow.Cells[4].Value.ToString();
        //        _productService.ChangeUnitPrice(new Product
        //        {
        //            ProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells[1].Value.ToString()),
        //            UnitPrice = Convert.ToDecimal(tbxChangeUnitPriceUnitPrice.Text),
        //            StockAmount = Convert.ToInt32(stock), //To avoid getting error from Validation Rules
        //            CategoryId = Convert.ToInt32(catId), //To avoid getting error from Validation Rules
        //            ProductDescription = des, //To avoid getting error from Validation Rules
        //            ProductName = name, //To avoid getting error from Validation Rules
        //        });
        //        //Recording Logs
        //        _logEntryService.LogForUnitPriceUpdate(new Product
        //        {
        //            ProductName = tbxChangeUnitPriceProductName.Text,
        //            UnitPrice = Convert.ToDecimal(tbxChangeUnitPriceUnitPrice.Text),
        //        }, OldPrice);
        //        //Mail Sending
        //        var lastLog = _logEntryService.GetAll().OrderByDescending(s => s.Id)
        //                .FirstOrDefault().Description.ToString();
        //        string AdminMail = _companyService.GetAdminMail().ToString();
        //        _mailSenderService.SendMailAsync(AdminMail, lastLog);
        //        LoadProducts();
        //        //Recording Mail
        //        _mailSenderService.LogMail(new Mail
        //        {
        //            ReceiverMail = AdminMail,
        //            MailBody = lastLog
        //        });
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message);
        //    }
        //}

        //private void btnChangeStock_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var row = dgvProducts.CurrentRow;
        //        var des = row.Cells[3].Value.ToString();
        //        var name = row.Cells[2].Value.ToString();
        //        var unitP = row.Cells[4].Value.ToString();
        //        var catId = row.Cells[6].Value.ToString();
        //        String OldStock = dgvProducts.CurrentRow.Cells[5].Value.ToString();
        //        _productService.ChangeStock(new Product
        //        {
        //            ProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells[1].Value.ToString()),
        //            StockAmount = Convert.ToInt32(tbxChangeStockStockAmount.Text),
        //            CategoryId = Convert.ToInt32(catId), //To avoid getting error from Validation Rules
        //            ProductDescription = des, //To avoid getting error from Validation Rules
        //            ProductName = name, //To avoid getting error from Validation Rules
        //            UnitPrice = Convert.ToDecimal(unitP) //To avoid getting error from Validation Rules
        //        });
        //        //Recording Logs
        //        _logEntryService.LogForStockUpdate(new Product
        //        {
        //            ProductName = tbxChangeStockProductName.Text,
        //            StockAmount = Convert.ToInt32(tbxChangeStockStockAmount.Text),
        //        }, OldStock);
        //        //Mail Sending
        //        var lastLog = _logEntryService.GetAll().OrderByDescending(s => s.Id)
        //                .FirstOrDefault().Description.ToString();
        //        string AdminMail = _companyService.GetAdminMail().ToString();
        //        _mailSenderService.SendMailAsync(AdminMail, lastLog);
        //        LoadProducts();
        //        //Recording Mail
        //        _mailSenderService.LogMail(new Mail
        //        {
        //            ReceiverMail = AdminMail,
        //            MailBody = lastLog
        //        });
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message);
        //    }
        //}

        //private void btnShowMails_Click(object sender, EventArgs e)
        //{
        //    Mails mails = new Mails();
        //    mails.Show();
        //}
    }
}
