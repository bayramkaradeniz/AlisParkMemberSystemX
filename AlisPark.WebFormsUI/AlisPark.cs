using AlisPark.Business.Abstract;
using AlisPark.Business.Concrete;
using AlisPark.Business.DependencyRevolvers.Ninject;
using AlisPark.DataAccess.Concrete;
using AlisPark.Entities.Concrete;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AlisPark.WebFormsUI
{
    public partial class AlisPark : Form
    {
        public AlisPark()
        {
            InitializeComponent();
            _memberService = InstanceFactory.GetInstance<IMemberService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _logEntryService = InstanceFactory.GetInstance<ILogEntryService>();
            _workerService = InstanceFactory.GetInstance<IWorkerService>();
            _messageSenderService = new MessageSenderManager();
            _companyService = InstanceFactory.GetInstance<ICompanyService>();

        }
        private IMemberService _memberService;
        private ICategoryService _categoryService;
        private ILogEntryService _logEntryService;
        private IWorkerService _workerService;
        private IMessageSenderService _messageSenderService;
        private ICompanyService _companyService;
        private void AlisPark_Load(object sender, EventArgs e)
        {
            //CheckStock();
            LoadCurrentWorker();
            LoadCategories();
            LoadMembers();
        }

        //private void CheckStock()
        //{
        //    throw new NotImplementedException();
        //}

        private void LoadCurrentWorker()
        {
            using (var context = new AlisParkContext())
            {
                var AdminId = 1;
                var UserOne = context.CompanyUsers.FirstOrDefault(k => k.AdminId == AdminId);
                if (UserOne != null)
                {
                    tbxCurrentWorker.Text = UserOne.CurrentWorker;
                }
            }

        }

        private void LoadMembers()
        {
            dgvMember.DataSource = _memberService.GetAll();

        }

        public void LoadCategories()
        {

            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";

            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvMember.DataSource = _memberService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }

        }

        private void tbxMemberNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxMemberNameSearch.Text))
            {
                dgvMember.DataSource = _memberService.GetProductsByMemberName(tbxMemberNameSearch.Text);
            }
            else
            {
                LoadMembers();
            }
        }


        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvMember.CurrentRow;
            tbxMemberNameUpdate.Text = row.Cells[1].Value.ToString();
            cbxCategoryUpdate.SelectedValue = row.Cells[5].Value;
            tbxBalanceUpdate.Text = row.Cells[6].Value.ToString();
            tbxMemberSurnameUpdate.Text = row.Cells[2].Value.ToString();
            tbxMemberPhoneUpdate.Text = row.Cells[3].Value.ToString();
            tbxMemberMailUpdate.Text = row.Cells[4].Value.ToString();
        }
        private bool VerifyPassword(string Password, string UserPw)
        {
            return Password == UserPw;
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            //using (var context = new AlisParkContext())
            //{

            //    string Username = tbxUserNameLogLogin.Text;
            //    var User = context.CompanyUsers.FirstOrDefault(p => p.CompanyAdminUsername == Username);

            //    if (User != null)
            //    {

            //        string Password = tbxPasswordLogLogin.Text;

            //        if (VerifyPassword(Password, User.CompanyAdminPassword))
            //        {
            //            AdminPage logs = new AdminPage();
            //            logs.Show();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Parola Hatalı.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Kullanıcı adı Hatalı.");
            //    }
            //}
        }

        private void btnMemberAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxCategoryAdd.Text == "Vip")
                {
                    _memberService.Add(new Member
                    {
                        CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                        MemberName = tbxMemberNameAdd.Text,
                        MemberSurname = tbxMemberSurnameAdd.Text,
                        Balance = Convert.ToDecimal(tbxBalanceAdd.Text)*Convert.ToDecimal(1.3),
                        MemberPhone = tbxMemberPhoneAdd.Text,
                        MemberMail = tbxMemberMailAdd.Text
                    });
                    _logEntryService.LogForAdd(new Worker
                    {
                        WorkerUserName = tbxCurrentWorker.Text,
                    },
                    new Member
                    {
                        MemberId = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value),
                        MemberName = tbxMemberNameAdd.Text,
                        MemberSurname = tbxMemberSurnameAdd.Text,
                        Balance = Convert.ToDecimal(tbxBalanceAdd.Text),
                    });
                    _messageSenderService.SendMessageAsync($"Üyeliğiniz Oluşturularak Bakiyeniz {Convert.ToDecimal(tbxBalanceAdd.Text) * Convert.ToDecimal(1.3)} Olarak Belirlendi. X Cafe",
                        new Member
                        {
                            MemberPhone = tbxMemberPhoneAdd.Text
                        });
                    MessageBox.Show("Üye Eklendi.");
                    LoadMembers();
                }
                else
                {
                    _memberService.Add(new Member
                    {
                        CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                        MemberName = tbxMemberNameAdd.Text,
                        MemberSurname = tbxMemberSurnameAdd.Text,
                        Balance = Convert.ToDecimal(tbxBalanceAdd.Text)*Convert.ToDecimal(1.15),
                        MemberPhone = tbxMemberPhoneAdd.Text
                    });
                    _logEntryService.LogForAdd(new Worker
                    {
                        WorkerUserName = tbxCurrentWorker.Text,
                    },
                    new Member
                    {
                        MemberId = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value),
                        MemberName = tbxMemberNameAdd.Text,
                        MemberSurname = tbxMemberSurnameAdd.Text,
                        Balance = Convert.ToDecimal(tbxBalanceAdd.Text) * Convert.ToDecimal(1.15),
                    });
                    _messageSenderService.SendMessageAsync($"Üyeliğiniz Oluşturularak Bakiyeniz {Convert.ToDecimal(tbxBalanceAdd.Text) * Convert.ToDecimal(1.15)} Olarak Belirlendi. X Cafe",
                        new Member
                        {
                            MemberPhone = tbxMemberPhoneAdd.Text
                        });
                    MessageBox.Show("Üye Eklendi.");
                    LoadMembers();
                }
                
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnMemberUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _memberService.Update(new Member
                {
                    MemberId = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value),
                    MemberName = tbxMemberNameUpdate.Text,
                    MemberSurname = tbxMemberSurnameUpdate.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                    Balance = Convert.ToDecimal(tbxBalanceUpdate.Text),
                    MemberMail = tbxMemberMailUpdate.Text
                });
                _logEntryService.LogForUpdate(new Worker
                {
                    WorkerUserName = tbxCurrentWorker.Text,
                },
                new Member
                {
                    MemberId = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value),
                    MemberName = tbxMemberNameUpdate.Text,
                    MemberSurname = tbxMemberSurnameUpdate.Text,
                    Balance = Convert.ToDecimal(tbxBalanceUpdate.Text),
                });
                _messageSenderService.SendMessageAsync($"Bakiyeniz {tbxBalanceUpdate.Text} Olarak Güncellendi." +
                    $"İşlem Bilginiz Dahilinde Değil İe Lütfen Bizi Arayın. X Cafe",
                        new Member
                        {
                            MemberPhone = dgvMember.CurrentRow.Cells[3].Value.ToString()
                        });
                MessageBox.Show("Üye Güncellendi.");
                LoadMembers();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void btnChangeCurrentWorker_Click(object sender, EventArgs e)
        {
            using (var context = new AlisParkContext())
            {
                string kullaniciAdi = tbxCurrentWorker.Text;

                var User = context.Workers.FirstOrDefault(k => k.WorkerUserName == kullaniciAdi);
                var UserOne = context.CompanyUsers.FirstOrDefault(k => k.CompanyAdminUsername == kullaniciAdi);

                var AdminId = 1;
                var UserTwo = context.CompanyUsers.FirstOrDefault(k => k.AdminId == AdminId);

                if (User != null)
                {
                    string Password = tbxCurrentWorkerPassword.Text;

                    if (VerifyPassword(Password, User.WorkerPassword))
                    {
                        UserTwo.CurrentWorker = tbxCurrentWorker.Text;
                        context.SaveChanges();
                        AlisPark alisPark = new AlisPark();
                        alisPark.Show();
                        _logEntryService.LogForChange(tbxCurrentWorker.Text);
                    }
                    else
                    {
                        MessageBox.Show("Şifre Hatalı.");
                    }
                }
                else if (UserOne != null)
                {
                    string Password = tbxCurrentWorkerPassword.Text;

                    if (VerifyPassword(Password, UserOne.CompanyAdminPassword))
                    {
                        UserTwo.CurrentWorker = tbxCurrentWorkerPassword.Text;
                        context.SaveChanges();
                        AlisPark alisPark = new AlisPark();
                        alisPark.Show();
                        _logEntryService.LogForChange(tbxCurrentWorker.Text);
                    }
                    else
                    {
                        MessageBox.Show("Şifre Hatalı.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı Hatalı.");
                }
            }
        }

        private void btnDeductAccountFromBalance_Click(object sender, EventArgs e)
        {
            using (var context = new AlisParkContext())
            {
                var id = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value);
                var User = context.Members.FirstOrDefault(k => k.MemberId == id);

                if (User != null)
                {
                    User.Balance = Convert.ToDecimal(tbxBalanceUpdate.Text) - Convert.ToDecimal(tbxDeductAccountFromBalance.Text);
                    context.SaveChanges();
                }
                _logEntryService.LogForUpdate(new Worker
                {
                    WorkerUserName = tbxCurrentWorker.Text,
                },
               new Member
               {
                   MemberId = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value),
                   MemberName = tbxMemberNameUpdate.Text,
                   MemberSurname = tbxMemberSurnameUpdate.Text,
                   Balance = Convert.ToDecimal(tbxDeductAccountFromBalance.Text),
               });
                _messageSenderService.SendMessageAsync($"Bakiyenizden {tbxDeductAccountFromBalance.Text} Tl Hesap Kesildi." +
                    $"İşlem Sonrası Bakiyeniz{dgvMember.CurrentRow.Cells[5].Value.ToString()} Tl." +
                    $"İşlem Bilginiz Dahilinde Değil İe Lütfen Bizi Arayın. X Cafe",
                    new Member
                    {
                        MemberPhone = dgvMember.CurrentRow.Cells[3].Value.ToString()
                    });

                MessageBox.Show("Üye  Bakiyesi Güncellendi.");
                LoadMembers();
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"{dgvMember.CurrentRow.Cells[1].Value.ToString()} {dgvMember.CurrentRow.Cells[2].Value.ToString()} adlı ürünü silmek istediğinize emin misiniz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvMember.CurrentRow != null)
                {
                    try
                    {
                        _memberService.Delete(new Member
                        {
                            MemberId = Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value)
                        });
                        //MessageBox.Show("Üye silindi!");
                        LoadMembers();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                }
            }

        }
    }

}
