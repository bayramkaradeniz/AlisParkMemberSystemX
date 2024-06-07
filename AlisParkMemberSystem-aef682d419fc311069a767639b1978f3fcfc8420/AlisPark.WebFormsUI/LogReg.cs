using AlisPark.Business.Abstract;
using AlisPark.Business.DependencyRevolvers.Ninject;
using AlisPark.DataAccess.Concrete;
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
    public partial class LogReg : Form
    {
        public LogReg()
        {
            InitializeComponent();
            _logEntryService = InstanceFactory.GetInstance<ILogEntryService>();
            _companyService = InstanceFactory.GetInstance<ICompanyService>();
        }
        private ILogEntryService _logEntryService;
        private ICompanyService _companyService;
        private void btnLog_Click(object sender, EventArgs e)
        {
            AlisPark alisPark = new AlisPark();
            alisPark.Show();
            //string result = _companyService.CheckLogin(tbxUsernameLogIn.Text, tbxPasswordLogIn.Text);

            //switch (result)
            //{
            //    case "A":
            //        MessageBox.Show("Giriş Başarılı");
            //        _logEntryService.LogForLogIn(new Worker
            //        {
            //            WorkerUserName = tbxUsernameLogIn.Text,
            //        });
            //        AlisPark alisPark = new AlisPark();
            //        alisPark.Show();

            //        this.Hide();
            //        break;
            //    case "B":
            //        MessageBox.Show("Şifre Hatalı.");
            //        break;
            //    case "C":
            //        MessageBox.Show("Böyle Bir Kullanıcı Yok.");
            //        break;
            //}



        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Hide();
        }
        private bool VerifyPassword(string Password, string UserPw)
        {
            return Password == UserPw;
        }
    }
}