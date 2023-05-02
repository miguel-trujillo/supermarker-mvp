namespace Supermarket_mvp.Views
{
    partial class ProductsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProductsList = new System.Windows.Forms.TabPage();
            this.tabPageProductsDetail = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgProducts = new System.Windows.Forms.DataGridView();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtProductsObservation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProductsName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtProductsId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageProductsList.SuspendLayout();
            this.tabPageProductsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(298, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageProductsList);
            this.tabControl1.Controls.Add(this.tabPageProductsDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 348);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageProductsList
            // 
            this.tabPageProductsList.Controls.Add(this.BtnClose);
            this.tabPageProductsList.Controls.Add(this.BtnDelete);
            this.tabPageProductsList.Controls.Add(this.BtnEdit);
            this.tabPageProductsList.Controls.Add(this.BtnNew);
            this.tabPageProductsList.Controls.Add(this.DgProducts);
            this.tabPageProductsList.Controls.Add(this.BtnSearch);
            this.tabPageProductsList.Controls.Add(this.TxtSearch);
            this.tabPageProductsList.Controls.Add(this.label2);
            this.tabPageProductsList.Location = new System.Drawing.Point(4, 24);
            this.tabPageProductsList.Name = "tabPageProductsList";
            this.tabPageProductsList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductsList.Size = new System.Drawing.Size(785, 320);
            this.tabPageProductsList.TabIndex = 0;
            this.tabPageProductsList.Text = "Products List";
            this.tabPageProductsList.UseVisualStyleBackColor = true;
            this.tabPageProductsList.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPageProductsDetail
            // 
            this.tabPageProductsDetail.Controls.Add(this.BtnCancel);
            this.tabPageProductsDetail.Controls.Add(this.BtnSave);
            this.tabPageProductsDetail.Controls.Add(this.TxtProductsObservation);
            this.tabPageProductsDetail.Controls.Add(this.label5);
            this.tabPageProductsDetail.Controls.Add(this.TxtProductsName);
            this.tabPageProductsDetail.Controls.Add(this.label4);
            this.tabPageProductsDetail.Controls.Add(this.TxtProductsId);
            this.tabPageProductsDetail.Controls.Add(this.label3);
            this.tabPageProductsDetail.Location = new System.Drawing.Point(4, 24);
            this.tabPageProductsDetail.Name = "tabPageProductsDetail";
            this.tabPageProductsDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductsDetail.Size = new System.Drawing.Size(785, 320);
            this.tabPageProductsDetail.TabIndex = 1;
            this.tabPageProductsDetail.Text = "Products  Detail";
            this.tabPageProductsDetail.UseVisualStyleBackColor = true;
            this.tabPageProductsDetail.Click += new System.EventHandler(this.tabPageProductsDetail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Products";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(22, 30);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Data to search";
            this.TxtSearch.Size = new System.Drawing.Size(277, 23);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(319, 6);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(64, 47);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            this.DgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProducts.Location = new System.Drawing.Point(17, 59);
            this.DgProducts.Name = "DgProducts";
            this.DgProducts.RowTemplate.Height = 25;
            this.DgProducts.Size = new System.Drawing.Size(361, 255);
            this.DgProducts.TabIndex = 3;
            // 
            // BtnNew
            // 
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.Location = new System.Drawing.Point(402, 59);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(64, 47);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(402, 112);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(64, 47);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(402, 165);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(64, 47);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(402, 218);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(64, 47);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Image = global::Supermarket_mvp.Properties.Resources.cancel;
            this.BtnCancel.Location = new System.Drawing.Point(170, 255);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(103, 56);
            this.BtnCancel.TabIndex = 16;
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Supermarket_mvp.Properties.Resources.save;
            this.BtnSave.Location = new System.Drawing.Point(28, 255);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(103, 56);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductsObservation
            // 
            this.TxtProductsObservation.Location = new System.Drawing.Point(28, 136);
            this.TxtProductsObservation.Multiline = true;
            this.TxtProductsObservation.Name = "TxtProductsObservation";
            this.TxtProductsObservation.PlaceholderText = "Products Observation";
            this.TxtProductsObservation.Size = new System.Drawing.Size(332, 99);
            this.TxtProductsObservation.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(28, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Products Observation";
            // 
            // TxtProductsName
            // 
            this.TxtProductsName.Location = new System.Drawing.Point(28, 81);
            this.TxtProductsName.Name = "TxtProductsName";
            this.TxtProductsName.PlaceholderText = "Products Name";
            this.TxtProductsName.Size = new System.Drawing.Size(332, 23);
            this.TxtProductsName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Product Name";
            // 
            // TxtProductsId
            // 
            this.TxtProductsId.Location = new System.Drawing.Point(28, 23);
            this.TxtProductsId.Name = "TxtProductsId";
            this.TxtProductsId.Size = new System.Drawing.Size(210, 23);
            this.TxtProductsId.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Products Id";
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 448);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ProductsView";
            this.Text = "ProductsView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageProductsList.ResumeLayout(false);
            this.tabPageProductsList.PerformLayout();
            this.tabPageProductsDetail.ResumeLayout(false);
            this.tabPageProductsDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductsList;
        private TabPage tabPageProductsDetail;
        private Label label2;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private DataGridView DgProducts;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductsObservation;
        private Label label5;
        private TextBox TxtProductsName;
        private Label label4;
        private TextBox TxtProductsId;
        private Label label3;
    }
}