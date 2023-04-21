namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePayModeList = new System.Windows.Forms.TabPage();
            this.tabPagePayModeDetail = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgPayMode = new System.Windows.Forms.DataGridView();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPayModeId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPayModeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPayModeObservation = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPagePayModeList.SuspendLayout();
            this.tabPagePayModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(186, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pay Mode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket_mvp.Properties.Resources.buy;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePayModeList);
            this.tabControl1.Controls.Add(this.tabPagePayModeDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 364);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            this.tabPagePayModeList.Controls.Add(this.BtnClose);
            this.tabPagePayModeList.Controls.Add(this.BtnDelete);
            this.tabPagePayModeList.Controls.Add(this.BtnEdit);
            this.tabPagePayModeList.Controls.Add(this.BtnNew);
            this.tabPagePayModeList.Controls.Add(this.DgPayMode);
            this.tabPagePayModeList.Controls.Add(this.BtnSearch);
            this.tabPagePayModeList.Controls.Add(this.TxtSearch);
            this.tabPagePayModeList.Controls.Add(this.label2);
            this.tabPagePayModeList.Location = new System.Drawing.Point(4, 24);
            this.tabPagePayModeList.Name = "tabPagePayModeList";
            this.tabPagePayModeList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePayModeList.Size = new System.Drawing.Size(706, 336);
            this.tabPagePayModeList.TabIndex = 0;
            this.tabPagePayModeList.Text = "Pay Mode List ";
            this.tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // tabPagePayModeDetail
            // 
            this.tabPagePayModeDetail.Controls.Add(this.BtnCancel);
            this.tabPagePayModeDetail.Controls.Add(this.BtnSave);
            this.tabPagePayModeDetail.Controls.Add(this.TxtPayModeObservation);
            this.tabPagePayModeDetail.Controls.Add(this.label5);
            this.tabPagePayModeDetail.Controls.Add(this.TxtPayModeName);
            this.tabPagePayModeDetail.Controls.Add(this.label4);
            this.tabPagePayModeDetail.Controls.Add(this.TxtPayModeId);
            this.tabPagePayModeDetail.Controls.Add(this.label3);
            this.tabPagePayModeDetail.Location = new System.Drawing.Point(4, 24);
            this.tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            this.tabPagePayModeDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePayModeDetail.Size = new System.Drawing.Size(706, 336);
            this.tabPagePayModeDetail.TabIndex = 1;
            this.tabPagePayModeDetail.Text = "Pay Mode Detail";
            this.tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Pay Mode";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(8, 32);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Data to search";
            this.TxtSearch.Size = new System.Drawing.Size(394, 23);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = global::Supermarket_mvp.Properties.Resources.search_small;
            this.BtnSearch.Location = new System.Drawing.Point(408, 10);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(62, 45);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgPayMode
            // 
            this.DgPayMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPayMode.Location = new System.Drawing.Point(10, 61);
            this.DgPayMode.Name = "DgPayMode";
            this.DgPayMode.RowTemplate.Height = 25;
            this.DgPayMode.Size = new System.Drawing.Size(460, 267);
            this.DgPayMode.TabIndex = 3;
            this.DgPayMode.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPayMode_CellContentClick);
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::Supermarket_mvp.Properties.Resources._new;
            this.BtnNew.Location = new System.Drawing.Point(490, 61);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(195, 56);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::Supermarket_mvp.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(490, 132);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(195, 56);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Supermarket_mvp.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(490, 204);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(195, 56);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::Supermarket_mvp.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(489, 272);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(195, 56);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pay Model Id";
            // 
            // TxtPayModeId
            // 
            this.TxtPayModeId.Location = new System.Drawing.Point(20, 40);
            this.TxtPayModeId.Name = "TxtPayModeId";
            this.TxtPayModeId.Size = new System.Drawing.Size(210, 23);
            this.TxtPayModeId.TabIndex = 2;
            this.TxtPayModeId.TextChanged += new System.EventHandler(this.TxtPayModeId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pay Mode Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtPayModeName
            // 
            this.TxtPayModeName.Location = new System.Drawing.Point(20, 98);
            this.TxtPayModeName.Name = "TxtPayModeName";
            this.TxtPayModeName.PlaceholderText = "Pay Mode Name";
            this.TxtPayModeName.Size = new System.Drawing.Size(332, 23);
            this.TxtPayModeName.TabIndex = 4;
            this.TxtPayModeName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pay Mode Name";
            // 
            // TxtPayModeObservation
            // 
            this.TxtPayModeObservation.Location = new System.Drawing.Point(20, 153);
            this.TxtPayModeObservation.Multiline = true;
            this.TxtPayModeObservation.Name = "TxtPayModeObservation";
            this.TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            this.TxtPayModeObservation.Size = new System.Drawing.Size(332, 99);
            this.TxtPayModeObservation.TabIndex = 6;
            this.TxtPayModeObservation.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Supermarket_mvp.Properties.Resources.save;
            this.BtnSave.Location = new System.Drawing.Point(20, 272);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(103, 56);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Image = global::Supermarket_mvp.Properties.Resources.cancel;
            this.BtnCancel.Location = new System.Drawing.Point(162, 272);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(103, 56);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 464);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "PayModeView";
            this.Text = "Pay Mode Management";
            this.Load += new System.EventHandler(this.PayModeView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePayModeList.ResumeLayout(false);
            this.tabPagePayModeList.PerformLayout();
            this.tabPagePayModeDetail.ResumeLayout(false);
            this.tabPagePayModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabPagePayModeDetail;
        private Button BtnSearch;
        private DataGridView DgPayMode;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtPayModeId;
        private Label label3;
        private Label label4;
        private TextBox TxtPayModeName;
        private Label label5;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
    }
}