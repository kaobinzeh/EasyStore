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
            txtRemoveProd.Visible = false;
            btnRemove.Visible = false;
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
            pnlAddProd.Show();
            pnlAddProd.Visible = true;
            pnlGrid.Visible = false;
            picBoxBarcode.Visible = true;
            label3.Visible = true;
            txtRemoveProd.Visible = false;
            btnRemove.Visible = false;
            //gridProduct.Hide();
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
                MessageBox.Show("Product Added Successfullys");     
            }
            catch (Exception ex)
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
            gridProduct.Visible = true;
            pnlGrid.Show();
           // pnlRemoveCat.Hide();
            picBoxBarcode.Visible = false;
            label3.Visible = false;
            txtRemoveProd.Visible = false;
            btnRemove.Visible = false;
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

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            pnlAct.Height = btnAddCategory.Height;
            pnlAct.Top = btnAddCategory.Top;
            //toggle(sender);
            AddCategory cat = new AddCategory();
            this.Hide();
            cat.Show();
        }

        private void btnRemoveCat_Click(object sender, EventArgs e)
        {
            pnlRemoveCat.Show();
            txtRemoveProd.Visible = true;
            btnRemove.Visible = true;
            pnlAddProd.Hide();
            pnlGrid.Hide();
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtRemoveProd.text == "" || txtRemoveProd.text == "Category Name") MessageBox.Show("Please Enter a Valid Category");
            try
            {
                var cat = unitOfWork.ProductRepository.Get(filter: c => c.Prod_Name == txtRemoveProd.text);
                if (cat != null)
                {
                    foreach (var item in cat)
                    {
                        unitOfWork.ProductRepository.Delete(item);
                        unitOfWork.Save();
                        MessageBox.Show("Product was removed successfully");
                        return;
                    }
                }
                MessageBox.Show("Product Does not exist");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured, Could not remove Product. Try Again later");
            }
        }

        private void txtRemoveProd_Click(object sender, EventArgs e)
        {
            txtRemoveProd.text = "";
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
