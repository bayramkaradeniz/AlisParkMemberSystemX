using AlisPark.Business.Abstract;
using AlisPark.Business.DependencyRevolvers.Ninject;
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
    public partial class TCategory : Form
    {
        public TCategory()
        {
            InitializeComponent();
            _tableCategoryService = InstanceFactory.GetInstance<ITableCategoryService>();
        }
        private ITableCategoryService _tableCategoryService;
    

        private void TCategory_Load(object sender, EventArgs e)
        {
            LoadTableCategories();
        }

        private void LoadTableCategories()
        {
            dgvTableCategories.DataSource = _tableCategoryService.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _tableCategoryService.Add(new Entities.Concrete.TableCategory
            {
                Name=textBox1.Text,
                PriceForHour=Convert.ToDecimal(textBox2.Text),
            });
            LoadTableCategories();
        }

        private void dgvTableCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvTableCategories.CurrentRow;

            textBox4.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _tableCategoryService.Update(new Entities.Concrete.TableCategory {

                Id = Convert.ToInt32(dgvTableCategories.CurrentRow.Cells[0].Value),
                Name = textBox4.Text,
                PriceForHour =Convert.ToDecimal(textBox3.Text)
            });
            LoadTableCategories();
        }
    }
}
