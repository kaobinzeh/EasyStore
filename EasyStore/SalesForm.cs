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
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Products";
                dataGridView1.Columns[2].Name = "Price";

                var code = unitofwork.ProductRepository.Get(filter: x => x.Barcode == result.Text);
                string id = "";
                string productName = "";
                decimal price = 0;
                
                foreach (var item in code)
                {
                    id = item.Id.ToString();
                    productName = item.Prod_Name;
                    price = item.Price;
                }
                decimal Total = Convert.ToDecimal(lblTotal.Text) + price;
                lblTotal.Text = Total.ToString();

                dataGridView1.Rows.Add(id, productName, price);

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
            try
            {
                string userId = System.Security.Principal.WindowsIdentity.GetCurrent().GetUserId();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    var id = dataGridView1.Rows[i].Cells[0].Value;
                    var price = dataGridView1.Rows[i].Cells[2].Value;

                    Entities.Transaction T = new Entities.Transaction()
                    {
                        Product_Id = Convert.ToInt16(id),
                        Total = Convert.ToDecimal(price),
                        Quantity = 1,
                        Date = DateTime.Now,
                        UserId = "9FFE555B-1F1C-474D-AC6D-126B159C97E0"
                    };

                    unitofwork.TransactionRepository.Insert(T);
                    unitofwork.Save();
                }
                Panel panel = new Panel();
                this.Controls.Add(panel);
                Graphics grp = panel.CreateGraphics();
                Size formSize = Recipt.Size;
                bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
                grp = Graphics.FromImage(bitmap);
                Point panelLocation = PointToScreen(Recipt.Location);
                grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                //PrintDocument recipt = new PrintDocument();
                //recipt.DocumentName = "Recipt";
                ////recipt.PrintPage += Recipt;
                //PrintDialog PD = new PrintDialog()
                //{
                //    Document = recipt,
                //    AllowSelection = true,
                //    AllowPrintToFile = true,
                //    AllowCurrentPage = true
                //};
                //if (PD.ShowDialog() == DialogResult.OK) 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please Contact Admin");                
            }
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
