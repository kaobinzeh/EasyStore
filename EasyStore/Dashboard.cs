using EasyStore.Abstract;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyStore
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            pnlDasboard.Show();
            loadCount();
        }
        
        private void btn_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnMakeSales.Height;
            pnlAct.Top = btnMakeSales.Top;
            SalesForm sales = new SalesForm();
            toggle(sender);
            this.Hide();
            sales.Show();
        }

        void toggle(object sender)
        {
            btnAllSales.selected = false;
            btnAddProduct.selected = false;
            btnMakeSales.selected = false;
            
            ((Bunifu.Framework.UI.BunifuFlatButton)sender).selected = true;
        }
        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnAddProduct.Height;
            pnlAct.Top = btnAddProduct.Top;
            toggle(sender);
            Products product = new Products();
            this.Hide();
            product.Show();
        }

        private void btnAllSales_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnAllSales.Height;
            pnlAct.Top = btnAllSales.Top;
            toggle(sender);
            Transaction trans = new Transaction();
            this.Hide();
            trans.Show();

        }

        void loadCount()
        {
            using(UnitOfWork U = new UnitOfWork())
            {
                lblProdNum.Text = U.ProductRepository.Get().Count().ToString();
                label4.Text = U.TransactionRepository.Get().Count().ToString();
                label5.Text = U.CategoryRepository.Get().Count().ToString();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashBoardTransactionDataSet.vw_transactions' table. You can move, or remove it, as needed.
            this.vw_transactionsTableAdapter.Fill(this.dashBoardTransactionDataSet.vw_transactions);
            // TODO: This line of code loads data into the 'dashboardProductDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dashboardProductDataSet.Products);

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnAddProduct.Height;
            pnlAct.Top = btnAddProduct.Top;
            //toggle(sender);           
            this.Focus();
            
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
