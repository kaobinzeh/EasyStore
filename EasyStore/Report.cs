using EasyStore.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyStore
{
    public partial class Report : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public Report()
        {
            InitializeComponent();
        }

        private void btnAllSales_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnAllSales.Height;
            pnlAct.Top = btnAllSales.Top;
            Transaction Trans = new Transaction();
            // toggle(sender);
            this.Hide();
            Trans.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnAddProduct.Height;
            pnlAct.Top = btnAddProduct.Top;
            //toggle(sender);
            Products product = new Products();
            this.Hide();
            product.Show();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "SN";
            dataGridView1.Columns[1].Name = "No of Product Sold";
            dataGridView1.Columns[2].Name = "Date";
            dataGridView1.Columns[3].Name = "Total";

            var allTrans = unitOfWork.TransactionRepository.Get();
            if (allTrans != null)
            {               
                var date = allTrans.Select(t => t.Date).ToList().Distinct();
                int i = 0;
                foreach (var item in date)
                {
                   var items = allTrans.Where(x => x.Date == item.Date);
                   var tranSum = items.Sum(x => x.Total);

                    dataGridView1.Rows.Add(i++, items.Count(), item.Date,tranSum);
                }
            }
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnDashboard.Height;
            pnlAct.Top = btnDashboard.Top;
            //toggle(sender);
            Dashboard product = new Dashboard();
            this.Hide();
            product.Show();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnAddCategory.Height;
            pnlAct.Top = btnAddCategory.Top;
            //toggle(sender);
            AddCategory cat = new AddCategory();
            this.Hide();
            cat.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnMakeSales.Height;
            pnlAct.Top = btnMakeSales.Top;
            SalesForm sales = new SalesForm();
            this.Hide();
            //toggle(sender);
            sales.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

    }
}
