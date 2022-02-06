namespace WFABilgeAdam.StoreManagementMain
{
    partial class frmProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductManagement));
            this.dgvListProduct = new System.Windows.Forms.DataGridView();
            this.cmsDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).BeginInit();
            this.cmsDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListProduct
            // 
            this.dgvListProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProduct.ContextMenuStrip = this.cmsDataGridView;
            this.dgvListProduct.Location = new System.Drawing.Point(12, 58);
            this.dgvListProduct.Name = "dgvListProduct";
            this.dgvListProduct.RowHeadersWidth = 82;
            this.dgvListProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListProduct.Size = new System.Drawing.Size(760, 442);
            this.dgvListProduct.TabIndex = 0;
            // 
            // cmsDataGridView
            // 
            this.cmsDataGridView.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsMenuItemEdit,
            this.cmsMenuItemRemove});
            this.cmsDataGridView.Name = "cmsDataGridView";
            this.cmsDataGridView.Size = new System.Drawing.Size(117, 48);
            this.cmsDataGridView.Text = "Edit";
            // 
            // cmsMenuItemEdit
            // 
            this.cmsMenuItemEdit.Name = "cmsMenuItemEdit";
            this.cmsMenuItemEdit.Size = new System.Drawing.Size(116, 22);
            this.cmsMenuItemEdit.Text = "Düzenle";
            this.cmsMenuItemEdit.Click += new System.EventHandler(this.cmsMenuItemEdit_Click);
            // 
            // cmsMenuItemRemove
            // 
            this.cmsMenuItemRemove.Name = "cmsMenuItemRemove";
            this.cmsMenuItemRemove.Size = new System.Drawing.Size(116, 22);
            this.cmsMenuItemRemove.Text = "Sil";
            this.cmsMenuItemRemove.Click += new System.EventHandler(this.cmsMenuItemRemove_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(654, 29);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(118, 23);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Yeni Ürün Ekle";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 528);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dgvListProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Yönetimi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).EndInit();
            this.cmsDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ContextMenuStrip cmsDataGridView;
        private System.Windows.Forms.ToolStripMenuItem cmsMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsMenuItemRemove;
        public System.Windows.Forms.DataGridView dgvListProduct;
    }
}