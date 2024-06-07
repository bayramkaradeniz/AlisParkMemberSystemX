using AlisPark.Business.Abstract;
using AlisPark.Business.DependencyRevolvers.Ninject;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisPark.WebFormsUI
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
            _companyService = InstanceFactory.GetInstance<ICompanyService>();
        }
        private ICompanyService _companyService;

        private void btnReg_Click(object sender, EventArgs e)
        {
            _companyService.Add(new Company
            {
                CompanyAdminUsername = tbxUsernameReg.Text,
                CompanyAdminPassword = tbxPasswordReg.Text,
                AdminFullName = tbxFullNameReg.Text,
                CompanyAdminPhone = tbxPhoneReg.Text,
                CompanyAdminMail = tbxMailReg.Text,
                CurrentWorker = tbxUsernameReg.Text
            });

            MessageBox.Show("Kaydınız Başarıyla Oluşturulmuştur.");

            LogReg logReg = new LogReg();
            logReg.Show();
            this.Close();



        }
    }
}
