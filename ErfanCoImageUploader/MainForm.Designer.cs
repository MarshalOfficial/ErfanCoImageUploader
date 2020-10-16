namespace ErfanCoImageUploader
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.tbxCurrentKalaSalePrice = new System.Windows.Forms.Label();
            this.tbxCurrentKalaBarcode = new System.Windows.Forms.Label();
            this.tbxCurrentKalaName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.K_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_Price_Sail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mojodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBarcodeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImgCurrentKala = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCurrentKala)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.btnRemoveImage);
            this.splitContainer1.Panel2.Controls.Add(this.btnSelectImage);
            this.splitContainer1.Panel2.Controls.Add(this.ImgCurrentKala);
            this.splitContainer1.Panel2.Controls.Add(this.tbxCurrentKalaSalePrice);
            this.splitContainer1.Panel2.Controls.Add(this.tbxCurrentKalaBarcode);
            this.splitContainer1.Panel2.Controls.Add(this.tbxCurrentKalaName);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(984, 561);
            this.splitContainer1.SplitterDistance = 615;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbxSearch);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvMain);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(615, 561);
            this.splitContainer2.SplitterDistance = 46;
            this.splitContainer2.TabIndex = 1;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Location = new System.Drawing.Point(44, 10);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(454, 21);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(501, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "جستجوی محصول :";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeight = 40;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_Name,
            this.KBarcode,
            this.K_Price_Sail,
            this.Mojodi,
            this.ERPCode,
            this.ProductID,
            this.PCompanyID,
            this.PBarcodeID});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 20;
            this.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(615, 511);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.SelectionChanged += new System.EventHandler(this.dgvMain_SelectionChanged);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveImage.Location = new System.Drawing.Point(89, 341);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(95, 40);
            this.btnRemoveImage.TabIndex = 8;
            this.btnRemoveImage.Text = "حذف تصویر";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectImage.Location = new System.Drawing.Point(194, 341);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(95, 40);
            this.btnSelectImage.TabIndex = 7;
            this.btnSelectImage.Text = "انتخاب تصویر";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // tbxCurrentKalaSalePrice
            // 
            this.tbxCurrentKalaSalePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCurrentKalaSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.tbxCurrentKalaSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbxCurrentKalaSalePrice.Location = new System.Drawing.Point(21, 88);
            this.tbxCurrentKalaSalePrice.Name = "tbxCurrentKalaSalePrice";
            this.tbxCurrentKalaSalePrice.Size = new System.Drawing.Size(252, 23);
            this.tbxCurrentKalaSalePrice.TabIndex = 5;
            // 
            // tbxCurrentKalaBarcode
            // 
            this.tbxCurrentKalaBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCurrentKalaBarcode.BackColor = System.Drawing.Color.Transparent;
            this.tbxCurrentKalaBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbxCurrentKalaBarcode.Location = new System.Drawing.Point(21, 65);
            this.tbxCurrentKalaBarcode.Name = "tbxCurrentKalaBarcode";
            this.tbxCurrentKalaBarcode.Size = new System.Drawing.Size(252, 23);
            this.tbxCurrentKalaBarcode.TabIndex = 4;
            // 
            // tbxCurrentKalaName
            // 
            this.tbxCurrentKalaName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCurrentKalaName.BackColor = System.Drawing.Color.Transparent;
            this.tbxCurrentKalaName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbxCurrentKalaName.Location = new System.Drawing.Point(21, 22);
            this.tbxCurrentKalaName.Name = "tbxCurrentKalaName";
            this.tbxCurrentKalaName.Size = new System.Drawing.Size(252, 43);
            this.tbxCurrentKalaName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(271, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "قیمت فروش :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(271, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "بارکد : ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(271, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام محصول :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(58, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "توجه : حجم فایل تصویر بایستی کمتر از 150 کیلوبایت باشد.";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefresh.Location = new System.Drawing.Point(0, 535);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(365, 26);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "بروزرسانی لیست از سرور";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // K_Name
            // 
            this.K_Name.DataPropertyName = "K_Name";
            this.K_Name.FillWeight = 161.8385F;
            this.K_Name.HeaderText = "نام محصول";
            this.K_Name.Name = "K_Name";
            this.K_Name.ReadOnly = true;
            // 
            // KBarcode
            // 
            this.KBarcode.DataPropertyName = "KBarcode";
            this.KBarcode.FillWeight = 58.94049F;
            this.KBarcode.HeaderText = "بارکد";
            this.KBarcode.Name = "KBarcode";
            this.KBarcode.ReadOnly = true;
            // 
            // K_Price_Sail
            // 
            this.K_Price_Sail.DataPropertyName = "K_Price_Sail";
            dataGridViewCellStyle1.Format = "N0";
            this.K_Price_Sail.DefaultCellStyle = dataGridViewCellStyle1;
            this.K_Price_Sail.FillWeight = 77.69819F;
            this.K_Price_Sail.HeaderText = "قیمت فروش";
            this.K_Price_Sail.Name = "K_Price_Sail";
            this.K_Price_Sail.ReadOnly = true;
            // 
            // Mojodi
            // 
            this.Mojodi.DataPropertyName = "Mojodi";
            this.Mojodi.FillWeight = 101.5229F;
            this.Mojodi.HeaderText = "موجودی";
            this.Mojodi.Name = "Mojodi";
            this.Mojodi.ReadOnly = true;
            // 
            // ERPCode
            // 
            this.ERPCode.DataPropertyName = "ERPCode";
            this.ERPCode.HeaderText = "ERPCode";
            this.ERPCode.Name = "ERPCode";
            this.ERPCode.ReadOnly = true;
            this.ERPCode.Visible = false;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // PCompanyID
            // 
            this.PCompanyID.DataPropertyName = "PCompanyID";
            this.PCompanyID.HeaderText = "PCompanyID";
            this.PCompanyID.Name = "PCompanyID";
            this.PCompanyID.ReadOnly = true;
            this.PCompanyID.Visible = false;
            // 
            // PBarcodeID
            // 
            this.PBarcodeID.DataPropertyName = "PBarcodeID";
            this.PBarcodeID.HeaderText = "PBarcodeID";
            this.PBarcodeID.Name = "PBarcodeID";
            this.PBarcodeID.ReadOnly = true;
            this.PBarcodeID.Visible = false;
            // 
            // ImgCurrentKala
            // 
            this.ImgCurrentKala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgCurrentKala.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImgCurrentKala.Image = global::ErfanCoImageUploader.Properties.Resources.Unknown;
            this.ImgCurrentKala.Location = new System.Drawing.Point(89, 135);
            this.ImgCurrentKala.Name = "ImgCurrentKala";
            this.ImgCurrentKala.Size = new System.Drawing.Size(200, 200);
            this.ImgCurrentKala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgCurrentKala.TabIndex = 6;
            this.ImgCurrentKala.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیم تصویر محصولات - بازرگانی عرفان";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCurrentKala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvMain;  
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox ImgCurrentKala;
        private System.Windows.Forms.Label tbxCurrentKalaSalePrice;
        private System.Windows.Forms.Label tbxCurrentKalaBarcode;
        private System.Windows.Forms.Label tbxCurrentKalaName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn KBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_Price_Sail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mojodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERPCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBarcodeID;
    }
}

