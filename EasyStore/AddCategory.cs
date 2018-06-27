using EasyStore.Abstract;
using EasyStore.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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
    public partial class AddCategory : Form
    {
        UnitOfWork unitofwork = new UnitOfWork();
        public AddCategory()
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

        private void btn_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnMakeSales.Height;
            pnlAct.Top = btnMakeSales.Top;
            SalesForm sales = new SalesForm();
            //toggle(sender);
            this.Hide();
            sales.Show();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnDashboard.Height;
            pnlAct.Top = btnDashboard.Top;
            //toggle(sender);
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void btnViewProd_Click(object sender, EventArgs e)
        {
            pnlGrid.Show();
            //gridProduct.Visible = true;
            //gridProduct.Visible = true;
           // label3.Visible = false;
            this.categoryTableAdapter.Fill(this.categorystoreDataSet.Category);

        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            pnlAddProd.Show();
            pnlAddProd.Visible = true;
            pnlGrid.Visible = false;
            pnlRemoveCat.Visible = false;
            //gridProduct.Visible = false;
           // label3.Visible = true;
            //gridProduct.Hide();
            //pnlRemoveCat.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var user = userManager.Users.ToList().LastOrDefault();

            if (txtName.text != "")
            {
                Category cat = new Category()
                {
                    Category1 = txtName.text,
                    Date = DateTime.Now,
                    UserId = user.Id
                };
                unitofwork.CategoryRepository.Insert(cat);
                unitofwork.Save();
                MessageBox.Show("Category Created !!!");
            }

        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.text = "";
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categorystoreDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.categorystoreDataSet.Category);

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnAddCategory.Height;
            pnlAct.Top = btnAddCategory.Top;
            //toggle(sender);
           // Dashboard dashboard = new Dashboard();
            this.Focus();
            //dashboard.Show();
        }

        private void btnRemoveCat_Click(object sender, EventArgs e)
        {
            pnlRemoveCat.Show();
            pnlGrid.Visible = false;
            pnlAddProd.Visible = false;
           // pnlAddProd.Hide();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtRemoveCat.text == "" || txtRemoveCat.text == "Category Name") MessageBox.Show("Please Enter a Valid Category");
            try
            {
                var cat = unitofwork.CategoryRepository.Get(filter: c => c.Category1 == txtRemoveCat.text);
                if (cat != null)
                {
                    foreach (var item in cat)
                    {
                        unitofwork.CategoryRepository.Delete(item);
                        unitofwork.Save();
                        MessageBox.Show("Category was removed successfully");
                        return;
                    }
                }
                MessageBox.Show("Category Does not exist");
            }
            catch(Exception ex)
            {
                MessageBox.Show("A product is linked to these category, make sure you delete the product before deleting the Category");
            }
        }

        private void txtRemoveCat_Click(object sender, EventArgs e)
        {
            txtRemoveCat.text = "";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnReport.Height;
            pnlAct.Top = btnReport.Top;
            //toggle(sender);
            Report cat = new Report();
            this.Hide();
            cat.Show();
        }
    }
}
