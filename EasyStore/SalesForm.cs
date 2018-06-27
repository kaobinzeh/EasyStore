using EasyStore.Abstract;
using EasyStore.Entities;
using MessagingToolkit.Barcode;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
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
using System.Drawing.Printing;

namespace EasyStore
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private UnitOfWork unitofwork = new UnitOfWork();
        private BarcodeDecoder Scanner;
        private OpenFileDialog OD;

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            OD = new OpenFileDialog();
            OD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (OD.ShowDialog() == DialogResult.OK)
                picBoxBarcode.Load(OD.FileName);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {            
            try
            {
                Scanner = new BarcodeDecoder();
                Result result = Scanner.Decode(new Bitmap(picBoxBarcode.Image));
                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Products";
                dataGridView1.Columns[2].Name = "Quantity";
                dataGridView1.Columns[3].Name = "Price";

                var code = unitofwork.ProductRepository.Get(filter: x => x.Barcode == result.Text);
                string id = "";
                string productName = "";
                decimal price = 0;
                var qty = Convert.ToDecimal(txtQty.Text);
                foreach (var item in code)
                {
                    id = item.Id.ToString();
                    productName = item.Prod_Name;
                    price = item.Price * qty;
                }
                decimal Total = Convert.ToDecimal(lblTotal.Text) + price;
                lblTotal.Text = Total.ToString();

                dataGridView1.Rows.Add(id, productName, qty, price);

            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured, Product does not exist");                
            }

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
        Bitmap bitmap;
        private void btnPay_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var user = userManager.Users.ToList().LastOrDefault();
            
            try
            {

                string userId = user.Id;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    var id = dataGridView1.Rows[i].Cells[0].Value;
                    var price = dataGridView1.Rows[i].Cells[3].Value;
                    var Quantity = dataGridView1.Rows[i].Cells[2].Value;
                    Entities.Transaction T = new Entities.Transaction()
                    {
                        Product_Id = Convert.ToInt16(id),
                        Total = Convert.ToDecimal(price),
                        Quantity = Convert.ToInt16(Quantity),
                        Date = DateTime.Now,
                        UserId = userId
                    };
                    unitofwork.TransactionRepository.Insert(T);
                    unitofwork.Save();
                }
                PrintDocument pd = new PrintDocument();

                pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

                //Print the document
                pd.Print();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please Contact Admin");                
            }
          }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Get the Graphics object
            Graphics g = e.Graphics;

            e.Graphics.Clear(Color.White);           
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            // -- Font chữ, size chữ
            Font drawFont1 = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            Font drawFont2 = new System.Drawing.Font("Arial", 60, FontStyle.Bold);
            Font drawFont3 = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
            Font drawFont4 = new System.Drawing.Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
            // -- Căn giữa
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;

            // Logo
            Image imgLogo = EasyStore.Properties.Resources.store;
            e.Graphics.DrawImage(imgLogo, 400, 0, 60, 60);
            RectangleF recAtZero = new RectangleF(100, 0 , e.PageBounds.Width, e.PageBounds.Height);
            e.Graphics.DrawString("Easy Store Invoice", drawFont3, drawBrush, recAtZero);

            recAtZero = new RectangleF(30, 100, e.PageBounds.Width, e.PageBounds.Height);
            e.Graphics.DrawString("This invoice shows that all product on it where bought from Easy store", drawFont3, drawBrush, recAtZero);

            recAtZero = new RectangleF(7, 200, e.PageBounds.Width, e.PageBounds.Height);
            string printDate = DateTime.Now.ToString();
            e.Graphics.DrawString("Date and Time:  " + printDate, drawFont1, drawBrush, recAtZero, drawFormat);
            // list of product
            recAtZero = new RectangleF(0, 250, e.PageBounds.Width, e.PageBounds.Height);
            e.Graphics.DrawString("List of items", drawFont3, drawBrush, recAtZero, drawFormat);

            recAtZero = new RectangleF(0, 300, e.PageBounds.Width, e.PageBounds.Height);
            e.Graphics.DrawString("product", drawFont1, drawBrush, recAtZero);

            recAtZero = new RectangleF(200, 300, e.PageBounds.Width, e.PageBounds.Height);
            e.Graphics.DrawString("Qty", drawFont1, drawBrush, recAtZero);

            recAtZero = new RectangleF(400, 300, e.PageBounds.Width, e.PageBounds.Height);
            e.Graphics.DrawString("Price", drawFont1, drawBrush, recAtZero);
            // foreach of the product
            int height = 350;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string product = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string price = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string Quantity = dataGridView1.Rows[i].Cells[2].Value.ToString();

                recAtZero = new RectangleF(10, height, e.PageBounds.Width, e.PageBounds.Height);
                e.Graphics.DrawString(product, drawFont1, drawBrush, recAtZero);

                recAtZero = new RectangleF(200, height, e.PageBounds.Width, e.PageBounds.Height);
                e.Graphics.DrawString(Quantity, drawFont1, drawBrush, recAtZero);

                recAtZero = new RectangleF(400, height, e.PageBounds.Width, e.PageBounds.Height);
                e.Graphics.DrawString(price, drawFont1, drawBrush, recAtZero);

                height += 50;
             }

            recAtZero = new RectangleF(0, height += 50, e.PageBounds.Width, e.PageBounds.Height);
            e.Graphics.DrawString("Total:  " + lblTotal.Text, drawFont4, drawBrush, recAtZero, drawFormat);
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
