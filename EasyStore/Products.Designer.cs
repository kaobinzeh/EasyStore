namespace EasyStore
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlAct = new System.Windows.Forms.Panel();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAllSales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMakeSales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlProd = new System.Windows.Forms.Panel();
            this.pnlAddProd = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.picBoxBarcode = new System.Windows.Forms.PictureBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet = new EasyStore.ProductDataSet();
            this.btnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ddlCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnSubmit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPrice = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtQuantity = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnViewProd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddProd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.productsTableAdapter = new EasyStore.ProductDataSetTableAdapters.ProductsTableAdapter();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            this.pnlProd.SuspendLayout();
            this.pnlAddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBarcode)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(214, 52);
            this.pnlLogo.TabIndex = 5;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(22, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(49, 45);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Easy Store";
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.Teal;
            this.pnlSideBar.Controls.Add(this.pnlAct);
            this.pnlSideBar.Controls.Add(this.btnAddProduct);
            this.pnlSideBar.Controls.Add(this.btnDashboard);
            this.pnlSideBar.Controls.Add(this.bunifuFlatButton2);
            this.pnlSideBar.Controls.Add(this.pnlLogo);
            this.pnlSideBar.Controls.Add(this.btnAllSales);
            this.pnlSideBar.Controls.Add(this.btnMakeSales);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(205, 576);
            this.pnlSideBar.TabIndex = 2;
            // 
            // pnlAct
            // 
            this.pnlAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.pnlAct.Location = new System.Drawing.Point(0, 91);
            this.pnlAct.Name = "pnlAct";
            this.pnlAct.Size = new System.Drawing.Size(10, 47);
            this.pnlAct.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddProduct.BackColor = System.Drawing.Color.Teal;
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.BorderRadius = 0;
            this.btnAddProduct.ButtonText = "Product";
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Iconimage = null;
            this.btnAddProduct.Iconimage_right = null;
            this.btnAddProduct.Iconimage_right_Selected = null;
            this.btnAddProduct.Iconimage_Selected = null;
            this.btnAddProduct.IconMarginLeft = 0;
            this.btnAddProduct.IconMarginRight = 0;
            this.btnAddProduct.IconRightVisible = false;
            this.btnAddProduct.IconRightZoom = 0D;
            this.btnAddProduct.IconVisible = false;
            this.btnAddProduct.IconZoom = 90D;
            this.btnAddProduct.IsTab = true;
            this.btnAddProduct.Location = new System.Drawing.Point(12, 91);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Normalcolor = System.Drawing.Color.Teal;
            this.btnAddProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProduct.selected = false;
            this.btnAddProduct.Size = new System.Drawing.Size(193, 47);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Product";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProduct.Textcolor = System.Drawing.Color.White;
            this.btnAddProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "DashBoard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = null;
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = false;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = false;
            this.btnDashboard.IconZoom = 90D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 50);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(205, 43);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "DashBoard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Teal;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(6, 250);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(199, 35);
            this.bunifuFlatButton2.TabIndex = 4;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAllSales
            // 
            this.btnAllSales.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllSales.BackColor = System.Drawing.Color.Teal;
            this.btnAllSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllSales.BorderRadius = 0;
            this.btnAllSales.ButtonText = "Transactions";
            this.btnAllSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllSales.DisabledColor = System.Drawing.Color.Gray;
            this.btnAllSales.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAllSales.Iconimage = null;
            this.btnAllSales.Iconimage_right = null;
            this.btnAllSales.Iconimage_right_Selected = null;
            this.btnAllSales.Iconimage_Selected = null;
            this.btnAllSales.IconMarginLeft = 0;
            this.btnAllSales.IconMarginRight = 0;
            this.btnAllSales.IconRightVisible = false;
            this.btnAllSales.IconRightZoom = 0D;
            this.btnAllSales.IconVisible = false;
            this.btnAllSales.IconZoom = 90D;
            this.btnAllSales.IsTab = false;
            this.btnAllSales.Location = new System.Drawing.Point(9, 197);
            this.btnAllSales.Name = "btnAllSales";
            this.btnAllSales.Normalcolor = System.Drawing.Color.Teal;
            this.btnAllSales.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllSales.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAllSales.selected = false;
            this.btnAllSales.Size = new System.Drawing.Size(193, 47);
            this.btnAllSales.TabIndex = 3;
            this.btnAllSales.Text = "Transactions";
            this.btnAllSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAllSales.Textcolor = System.Drawing.Color.White;
            this.btnAllSales.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllSales.Click += new System.EventHandler(this.btnAllSales_Click);
            // 
            // btnMakeSales
            // 
            this.btnMakeSales.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMakeSales.BackColor = System.Drawing.Color.Teal;
            this.btnMakeSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMakeSales.BorderRadius = 0;
            this.btnMakeSales.ButtonText = "Make Sales";
            this.btnMakeSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeSales.DisabledColor = System.Drawing.Color.Gray;
            this.btnMakeSales.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMakeSales.Iconimage = null;
            this.btnMakeSales.Iconimage_right = null;
            this.btnMakeSales.Iconimage_right_Selected = null;
            this.btnMakeSales.Iconimage_Selected = null;
            this.btnMakeSales.IconMarginLeft = 0;
            this.btnMakeSales.IconMarginRight = 0;
            this.btnMakeSales.IconRightVisible = true;
            this.btnMakeSales.IconRightZoom = 0D;
            this.btnMakeSales.IconVisible = true;
            this.btnMakeSales.IconZoom = 90D;
            this.btnMakeSales.IsTab = false;
            this.btnMakeSales.Location = new System.Drawing.Point(9, 144);
            this.btnMakeSales.Name = "btnMakeSales";
            this.btnMakeSales.Normalcolor = System.Drawing.Color.Teal;
            this.btnMakeSales.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMakeSales.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMakeSales.selected = false;
            this.btnMakeSales.Size = new System.Drawing.Size(193, 47);
            this.btnMakeSales.TabIndex = 2;
            this.btnMakeSales.Text = "Make Sales";
            this.btnMakeSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMakeSales.Textcolor = System.Drawing.Color.White;
            this.btnMakeSales.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeSales.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(205, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 52);
            this.panel1.TabIndex = 3;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(662, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(31, 26);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 6;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightGray;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageActive = null;
            this.btnLogOut.Location = new System.Drawing.Point(696, 11);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(31, 26);
            this.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Zoom = 10;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlProd
            // 
            this.pnlProd.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlProd.Controls.Add(this.pnlAddProd);
            this.pnlProd.Controls.Add(this.btnViewProd);
            this.pnlProd.Controls.Add(this.btnAddProd);
            this.pnlProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProd.Location = new System.Drawing.Point(205, 52);
            this.pnlProd.Name = "pnlProd";
            this.pnlProd.Size = new System.Drawing.Size(739, 524);
            this.pnlProd.TabIndex = 6;
            // 
            // pnlAddProd
            // 
            this.pnlAddProd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlAddProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddProd.Controls.Add(this.label3);
            this.pnlAddProd.Controls.Add(this.picBoxBarcode);
            this.pnlAddProd.Controls.Add(this.pnlGrid);
            this.pnlAddProd.Controls.Add(this.btnPrint);
            this.pnlAddProd.Controls.Add(this.ddlCategory);
            this.pnlAddProd.Controls.Add(this.btnSubmit);
            this.pnlAddProd.Controls.Add(this.txtPrice);
            this.pnlAddProd.Controls.Add(this.txtQuantity);
            this.pnlAddProd.Controls.Add(this.txtName);
            this.pnlAddProd.Location = new System.Drawing.Point(39, 77);
            this.pnlAddProd.Name = "pnlAddProd";
            this.pnlAddProd.Size = new System.Drawing.Size(639, 299);
            this.pnlAddProd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "ADD PRODUCT";
            // 
            // picBoxBarcode
            // 
            this.picBoxBarcode.Location = new System.Drawing.Point(319, 82);
            this.picBoxBarcode.Name = "picBoxBarcode";
            this.picBoxBarcode.Size = new System.Drawing.Size(293, 153);
            this.picBoxBarcode.TabIndex = 8;
            this.picBoxBarcode.TabStop = false;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlGrid.Controls.Add(this.label2);
            this.pnlGrid.Controls.Add(this.gridProduct);
            this.pnlGrid.Location = new System.Drawing.Point(3, 3);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(639, 299);
            this.pnlGrid.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ALL PRODUCT";
            // 
            // gridProduct
            // 
            this.gridProduct.AutoGenerateColumns = false;
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.barcodeDataGridViewTextBoxColumn});
            this.gridProduct.DataSource = this.productsBindingSource;
            this.gridProduct.Location = new System.Drawing.Point(3, 38);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.ReadOnly = true;
            this.gridProduct.Size = new System.Drawing.Size(633, 150);
            this.gridProduct.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prod_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prod_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.productDataSet;
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "ProductDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrint
            // 
            this.btnPrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 0;
            this.btnPrint.ButtonText = "Save";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = null;
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 90D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(411, 243);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(134, 47);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Save";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Textcolor = System.Drawing.Color.White;
            this.btnPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ddlCategory
            // 
            this.ddlCategory.BackColor = System.Drawing.Color.Transparent;
            this.ddlCategory.BorderRadius = 3;
            this.ddlCategory.DisabledColor = System.Drawing.Color.Gray;
            this.ddlCategory.ForeColor = System.Drawing.Color.White;
            this.ddlCategory.Items = new string[] {
        "Select Category "};
            this.ddlCategory.Location = new System.Drawing.Point(38, 243);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ddlCategory.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ddlCategory.selectedIndex = 0;
            this.ddlCategory.Size = new System.Drawing.Size(250, 35);
            this.ddlCategory.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.BorderRadius = 0;
            this.btnSubmit.ButtonText = "Submit";
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmit.Iconimage = null;
            this.btnSubmit.Iconimage_right = null;
            this.btnSubmit.Iconimage_right_Selected = null;
            this.btnSubmit.Iconimage_Selected = null;
            this.btnSubmit.IconMarginLeft = 0;
            this.btnSubmit.IconMarginRight = 0;
            this.btnSubmit.IconRightVisible = true;
            this.btnSubmit.IconRightZoom = 0D;
            this.btnSubmit.IconVisible = true;
            this.btnSubmit.IconZoom = 90D;
            this.btnSubmit.IsTab = false;
            this.btnSubmit.Location = new System.Drawing.Point(411, 27);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSubmit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSubmit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmit.selected = false;
            this.btnSubmit.Size = new System.Drawing.Size(134, 47);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.Textcolor = System.Drawing.Color.White;
            this.btnSubmit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Silver;
            this.txtPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPrice.BackgroundImage")));
            this.txtPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtPrice.Icon = ((System.Drawing.Image)(resources.GetObject("txtPrice.Icon")));
            this.txtPrice.Location = new System.Drawing.Point(38, 99);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(250, 42);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.text = "Price";
            this.txtPrice.UseWaitCursor = true;
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Silver;
            this.txtQuantity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtQuantity.BackgroundImage")));
            this.txtQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtQuantity.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtQuantity.Icon = ((System.Drawing.Image)(resources.GetObject("txtQuantity.Icon")));
            this.txtQuantity.Location = new System.Drawing.Point(38, 173);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(250, 42);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.text = "Quantity";
            this.txtQuantity.Click += new System.EventHandler(this.txtQuantity_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Silver;
            this.txtName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtName.BackgroundImage")));
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtName.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtName.Icon = ((System.Drawing.Image)(resources.GetObject("txtName.Icon")));
            this.txtName.Location = new System.Drawing.Point(38, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 42);
            this.txtName.TabIndex = 1;
            this.txtName.text = "Product Name";
            this.txtName.UseWaitCursor = true;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // btnViewProd
            // 
            this.btnViewProd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewProd.BackColor = System.Drawing.Color.Teal;
            this.btnViewProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewProd.BorderRadius = 0;
            this.btnViewProd.ButtonText = "All Product";
            this.btnViewProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewProd.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewProd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewProd.Iconimage = null;
            this.btnViewProd.Iconimage_right = null;
            this.btnViewProd.Iconimage_right_Selected = null;
            this.btnViewProd.Iconimage_Selected = null;
            this.btnViewProd.IconMarginLeft = 0;
            this.btnViewProd.IconMarginRight = 0;
            this.btnViewProd.IconRightVisible = true;
            this.btnViewProd.IconRightZoom = 0D;
            this.btnViewProd.IconVisible = true;
            this.btnViewProd.IconZoom = 90D;
            this.btnViewProd.IsTab = false;
            this.btnViewProd.Location = new System.Drawing.Point(15, 19);
            this.btnViewProd.Name = "btnViewProd";
            this.btnViewProd.Normalcolor = System.Drawing.Color.Teal;
            this.btnViewProd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewProd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewProd.selected = false;
            this.btnViewProd.Size = new System.Drawing.Size(146, 38);
            this.btnViewProd.TabIndex = 8;
            this.btnViewProd.Text = "All Product";
            this.btnViewProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewProd.Textcolor = System.Drawing.Color.White;
            this.btnViewProd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProd.Click += new System.EventHandler(this.btnViewProd_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddProd.BackColor = System.Drawing.Color.Teal;
            this.btnAddProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProd.BorderRadius = 0;
            this.btnAddProd.ButtonText = "Add Product";
            this.btnAddProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProd.Iconimage = null;
            this.btnAddProd.Iconimage_right = null;
            this.btnAddProd.Iconimage_right_Selected = null;
            this.btnAddProd.Iconimage_Selected = null;
            this.btnAddProd.IconMarginLeft = 0;
            this.btnAddProd.IconMarginRight = 0;
            this.btnAddProd.IconRightVisible = true;
            this.btnAddProd.IconRightZoom = 0D;
            this.btnAddProd.IconVisible = true;
            this.btnAddProd.IconZoom = 90D;
            this.btnAddProd.IsTab = false;
            this.btnAddProd.Location = new System.Drawing.Point(547, 19);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Normalcolor = System.Drawing.Color.Teal;
            this.btnAddProd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddProd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProd.selected = false;
            this.btnAddProd.Size = new System.Drawing.Size(146, 38);
            this.btnAddProd.TabIndex = 7;
            this.btnAddProd.Text = "Add Product";
            this.btnAddProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProd.Textcolor = System.Drawing.Color.White;
            this.btnAddProd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 576);
            this.Controls.Add(this.pnlProd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            this.pnlProd.ResumeLayout(false);
            this.pnlAddProd.ResumeLayout(false);
            this.pnlAddProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBarcode)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlAct;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAllSales;
        private Bunifu.Framework.UI.BunifuFlatButton btnMakeSales;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton btnLogOut;
        private System.Windows.Forms.Panel pnlProd;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewProd;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProd;
        private System.Windows.Forms.DataGridView gridProduct;
        private ProductDataSet productDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ProductDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlAddProd;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrint;
        private Bunifu.Framework.UI.BunifuDropdown ddlCategory;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmit;
        private Bunifu.Framework.UI.BunifuTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuTextbox txtQuantity;
        private Bunifu.Framework.UI.BunifuTextbox txtName;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxBarcode;
        private System.Windows.Forms.Label label3;
    }
}