using EasyStore.Abstract;
using EasyStore.Models;
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
    public partial class Transaction : Form
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public Transaction()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnMakeSales.Height;
            pnlAct.Top = btnMakeSales.Top;
            SalesForm sales = new SalesForm();
            this.Hide();
            toggle(sender);
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
            this.Focus();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            this.Close();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transactionDataSet.vw_transactions' table. You can move, or remove it, as needed.
            this.vw_transactionsTableAdapter.Fill(this.transactionDataSet.vw_transactions);
                
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
    }
}
