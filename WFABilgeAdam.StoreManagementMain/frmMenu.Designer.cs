namespace WFABilgeAdam.StoreManagementMain
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uygulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.oturumuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uygulamadanÇıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnManageCategory = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnShowUserActivity = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uygulamaToolStripMenuItem
            // 
            this.uygulamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.oturumuKapatToolStripMenuItem,
            this.toolStripSeparator2,
            this.uygulamadanÇıkToolStripMenuItem});
            this.uygulamaToolStripMenuItem.Name = "uygulamaToolStripMenuItem";
            this.uygulamaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.uygulamaToolStripMenuItem.Text = "Uygulama";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // oturumuKapatToolStripMenuItem
            // 
            this.oturumuKapatToolStripMenuItem.Name = "oturumuKapatToolStripMenuItem";
            this.oturumuKapatToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.oturumuKapatToolStripMenuItem.Text = "Oturumu Kapat";
            this.oturumuKapatToolStripMenuItem.Click += new System.EventHandler(this.oturumuKapatToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // uygulamadanÇıkToolStripMenuItem
            // 
            this.uygulamadanÇıkToolStripMenuItem.Name = "uygulamadanÇıkToolStripMenuItem";
            this.uygulamadanÇıkToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.uygulamadanÇıkToolStripMenuItem.Text = "Uygulamadan Çık";
            this.uygulamadanÇıkToolStripMenuItem.Click += new System.EventHandler(this.uygulamadanÇıkToolStripMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(306, 1);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(217, 23);
            this.lblUser.TabIndex = 1;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.Location = new System.Drawing.Point(160, 108);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(188, 36);
            this.btnManageProduct.TabIndex = 2;
            this.btnManageProduct.Text = "Ürün Yönetimi";
            this.btnManageProduct.UseVisualStyleBackColor = true;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Location = new System.Drawing.Point(160, 164);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(188, 36);
            this.btnManageUser.TabIndex = 3;
            this.btnManageUser.Text = "Kullanıcı Yönetimi";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnManageCategory
            // 
            this.btnManageCategory.Location = new System.Drawing.Point(160, 218);
            this.btnManageCategory.Name = "btnManageCategory";
            this.btnManageCategory.Size = new System.Drawing.Size(188, 36);
            this.btnManageCategory.TabIndex = 4;
            this.btnManageCategory.Text = "Kategori Yönetimi";
            this.btnManageCategory.UseVisualStyleBackColor = true;
            this.btnManageCategory.Click += new System.EventHandler(this.btnManageCategory_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(160, 271);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(188, 36);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Kategori/Ürün Raporu";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnShowUserActivity
            // 
            this.btnShowUserActivity.Location = new System.Drawing.Point(160, 323);
            this.btnShowUserActivity.Name = "btnShowUserActivity";
            this.btnShowUserActivity.Size = new System.Drawing.Size(188, 36);
            this.btnShowUserActivity.TabIndex = 6;
            this.btnShowUserActivity.Text = "Kullanıcı Hareketlerini Göster";
            this.btnShowUserActivity.UseVisualStyleBackColor = true;
            this.btnShowUserActivity.Click += new System.EventHandler(this.btnShowUserActivity_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 458);
            this.Controls.Add(this.btnShowUserActivity);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnManageCategory);
            this.Controls.Add(this.btnManageUser);
            this.Controls.Add(this.btnManageProduct);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ana Menü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uygulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem oturumuKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem uygulamadanÇıkToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnManageProduct;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnManageCategory;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnShowUserActivity;
    }
}