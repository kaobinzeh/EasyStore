using EasyStore.Abstract;
using EasyStore.Entities;
using MessagingToolkit.Barcode;
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
    public partial class Products : Form
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        BarcodeEncoder Generator;
        SaveFileDialog SD;

        public Products()
        {
            InitializeComponent();
            pnlGrid.Show();
            pnlAddProd.Visible = true;
            picBoxBarcode.Visible = false;
            label3.Visible = false;
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
            pnlProd.Show();
            gridProduct.Show();
            this.Focus();

        }

        private void btnAllSales_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnAllSales.Height;
            pnlAct.Top = btnAllSales.Top;
            Transaction Trans = new Transaction();
            toggle(sender);
            this.Hide();
            Trans.Show();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productDataSet.Products);
            //this.productsTableAdapter.FillBy(this.productDataSet.DataTable1);
          var category = unitOfWork.CategoryRepository.Get();
            foreach (var item in category)
            {
                ddlCategory.AddItem(item.Category1);
               // ddlCategory.Items{ };

            }
        }

        void ClearData(object sender)
        {
            ((Bunifu.Framework.UI.BunifuTextbox)sender).text = "";
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            pnlAddProd.Visible = true;
            pnlGrid.Visible = false;
            gridProduct.Visible = false;
            picBoxBarcode.Visible = true;
            label3.Visible = true;
            //gridProduct.Hide();
            pnlAddProd.Show();
            txtName.text = "Product Name";
            txtQuantity.text = "Quantity(10)";
            txtPrice.text = "Price (100)";
            picBoxBarcode.Refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) { MessageBox.Show("Ensure you enter all detail"); return; }

            try
            {
                string str = txtName.text.Substring(0, 3).ToUpper();
                string cat = ddlCategory.selectedIndex.ToString();
                Generator = new BarcodeEncoder();
                Generator.IncludeLabel = true;
              
                string code = str + txtPrice.text + txtQuantity.text;
                Generator.CustomLabel = code;
                picBoxBarcode.Image = new Bitmap(Generator.Encode(BarcodeFormat.Code39, code));
                Barcode barcode = new Barcode()
                {
                    Barcode1 = code,
                    IsUsed = true
                };
                unitOfWork.BarcodeRepository.Insert(barcode);
                unitOfWork.Save();  
                btnPrint.Visible = true;

                Product p = new Product()
                {
                    Prod_Name = txtName.text,
                    Price = Convert.ToDecimal(txtPrice.text),
                    Quantity = Convert.ToInt16(txtQuantity.text),
                    Barcode = code,
                    Category_Id = Convert.ToInt16(cat)
                };
                unitOfWork.ProductRepository.Insert(p);
                unitOfWork.Save();
                             
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured, Unable to generate Barcode");               
            }
           
        }

        bool ValidateData()
        {
            if (txtName.text == "") return false;

            if (txtQuantity.text == "") return false;

            if (txtPrice.text == "") return false;

            return true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SD = new SaveFileDialog();
            SD.Filter = "PNG File|*.png";
            if (SD.ShowDialog() == DialogResult.OK)
                picBoxBarcode.Image.Save(SD.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void btnViewProd_Click(object sender, EventArgs e)
        {
            pnlGrid.Show();
            gridProduct.Visible = true;            
            gridProduct.Visible = true;
            picBoxBarcode.Visible = false;
            label3.Visible = false;
            this.productsTableAdapter.Fill(this.productDataSet.Products);

            //pnlAddProd.Hide();
        }
                
        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.text = "";
            ClearData(sender);
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            txtPrice.text = "";
            ClearData(sender);
        }

        private void txtQuantity_Click(object sender, EventArgs e)
        {
            txtQuantity.text = "";
            ClearData(sender);
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
    }
}
