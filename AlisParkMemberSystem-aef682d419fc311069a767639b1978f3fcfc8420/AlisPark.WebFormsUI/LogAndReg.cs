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
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Ink;

namespace AlisPark.WebFormsUI
{
    public partial class LogAndReg : Form
    {
        public LogAndReg()
        {
            InitializeComponent();
            _companyService = InstanceFactory.GetInstance<ICompanyService>();
            _logEntryService = InstanceFactory.GetInstance<ILogEntryService>();

        }
        private ILogEntryService _logEntryService;
        private ICompanyService _companyService;



        private void btnLogin_Click(object sender, EventArgs e)
        {
            AlisPark alisPark = new AlisPark();
            alisPark.Show();
            //using (var context = new AlisParkContext())
            //{
            //    string kullaniciAdi = tbxUsernameLogIn.Text;


            //    var User = context.Workers.FirstOrDefault(k => k.WorkerUserName == kullaniciAdi);
            //    var UserOne = context.CompanyUsers.FirstOrDefault(k => k.CompanyAdminUsername == kullaniciAdi);

            //    var AdminId = 1;
            //    var UserTwo = context.CompanyUsers.FirstOrDefault(k => k.AdminId == AdminId);

            //    if (User != null)
            //    {
            //        string Password = tbxPasswordLogIn.Text;

            //        if (VerifyPassword(Password, User.WorkerPassword))
            //        {

            //            UserTwo.CurrentWorker = tbxUsernameLogIn.Text;
            //            context.SaveChanges();
            //            AlisPark alisPark = new AlisPark();
            //            alisPark.Show();
            //            _logEntryService.LogForLogIn(new Worker
            //            {
            //                WorkerUserName = tbxUsernameLogIn.Text,
            //            });
            //        }
            //        else
            //        {
            //            MessageBox.Show("Şifre Hatalı.");
            //        }
            //    }
            //    else if (UserOne != null)
            //    {
            //        string Password = tbxPasswordLogIn.Text;

            //        if (VerifyPassword(Password, UserOne.CompanyAdminPassword))
            //        {

            //            UserTwo.CurrentWorker = tbxUsernameLogIn.Text;
            //            context.SaveChanges();
            //            AlisPark alisPark = new AlisPark();
            //            alisPark.Show();
            //            _logEntryService.LogForLogIn(new Worker
            //            {
            //                WorkerUserName = tbxUsernameLogIn.Text,
            //            });
            //        }
            //        else
            //        {
            //            MessageBox.Show("Şifre Hatalı.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Kullanıcı adı Hatalı.");
            //    }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        //private bool VerifyPassword(string Password, string UserPw)
        //{
        //    return Password == UserPw;
        //}
    
}
