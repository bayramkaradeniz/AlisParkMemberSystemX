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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            _logEntryService = InstanceFactory.GetInstance<ILogEntryService>();
            _workerService = InstanceFactory.GetInstance<IWorkerService>();
        }
        private ILogEntryService _logEntryService;
        private IWorkerService _workerService;

        private void Logs_Load(object sender, EventArgs e)
        {
            LoadLogs();
            LoadWorkers();
        }

        private void LoadWorkers()
        {
            dgvWorkers.DataSource = _workerService.GetAll();
        }

        private void LoadLogs()
        {
            dgvLogs.DataSource = _logEntryService.GetAll();
        }

        private void tbxMemberNameSearchLog_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxMemberNameSearchLog.Text))
            {
                dgvLogs.DataSource = _logEntryService.GetLogsByWord(tbxMemberNameSearchLog.Text);
            }
            else
            {
                LoadLogs();
            }
        }

        private void btnRemoveLogs_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Kaydı silmek istediğinize emin misiniz?",
               "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvLogs.CurrentRow != null)
                {
                    try
                    {
                        _logEntryService.Delete(new LogEntry
                        {
                            Id = Convert.ToInt32(dgvLogs.CurrentRow.Cells[0].Value)
                        });
                        MessageBox.Show("Kayıt silindi!");
                        LoadLogs();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                }
            }
        }

        private void btnWorkerAdd_Click(object sender, EventArgs e)
        {
            _workerService.Add(new Worker
            {
                WorkerUserName = tbxWorkerUserNameAdd.Text,
                WorkerPassword = tbxWorkerPasswordAdd.Text,
                WorkerPhone = tbxWorkerPhoneAdd.Text
            });
            MessageBox.Show("Çalışan Eklendi.");
            LoadWorkers();
        }

        private void dgvWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvWorkers.CurrentRow;
            tbxWorkerUserNameUpdate.Text = row.Cells[1].Value.ToString();
            tbxWorkerPasswordUpdate.Text = row.Cells[2].Value.ToString();
            tbxWorkerPhoneUpdate.Text = row.Cells[3].Value.ToString();
        }

        private void btnWorkerUpdate_Click(object sender, EventArgs e)
        {
            _workerService.Update(new Worker
            {
                WorkerId = Convert.ToInt32(dgvWorkers.CurrentRow.Cells[0].Value),
                WorkerUserName = tbxWorkerUserNameUpdate.Text,
                WorkerPassword = tbxWorkerPasswordUpdate.Text,
                WorkerPhone = tbxWorkerPhoneUpdate.Text,
            });
            MessageBox.Show("Çalışan Güncellendi.");
            LoadWorkers();
        }

        private void btnWorkerDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"{dgvWorkers.CurrentRow.Cells[1].Value.ToString()} adlı kullanıcıyı istediğinize emin misiniz?",
               "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvWorkers.CurrentRow != null)
                {
                    try
                    {
                        _workerService.Delete(new Worker
                        {
                            WorkerId = Convert.ToInt32(dgvWorkers.CurrentRow.Cells[0].Value)
                        });
                        MessageBox.Show("Çalışan silindi!");
                        LoadWorkers();
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
