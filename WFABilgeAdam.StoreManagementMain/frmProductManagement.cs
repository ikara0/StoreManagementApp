using BilgeAdam.Common.Contracts;
using InformationModels;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WFABilgeAdam.StoreManagementMain
{
    public partial class frmProductManagement : Form
    {

        private BindingList<Product> products;
        public frmProductManagement()
        {

            products = CommanConstant.productList;
            InitializeComponent();

        }


        private void frmProductManagement_Load(object sender, EventArgs e)
        {

            dgvListProduct.DataSource = products;
        }



        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var frmAddProduct = new frmAddProduct();

            frmAddProduct.ShowDialog();
            this.Show();

        }

        private void cmsMenuItemEdit_Click(object sender, EventArgs e)
        {
            var productCode = dgvListProduct.CurrentRow.Cells[1].Value.ToString();

            foreach (var product in products)
            {
                if (productCode == product.Code)
                {
                    var frmProductEdit = new frmProductEdit(product);
                    this.Hide();
                    frmProductEdit.ShowDialog();
                    this.Show();
                    break;
                }
            }

        }

        private void cmsMenuItemRemove_Click(object sender, EventArgs e)
        {
            var productCode = dgvListProduct.CurrentRow.Cells[1].Value.ToString();

            foreach (var item in products)
            {
                if (productCode == item.Code)
                {
                    CommanConstant.productList.Remove(item);
                    return;
                }
            }

        }

        private void frmProductManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            var fileName = Path.Combine(CommanConstant.LogsDirectoryPath, "ProductLog.txt");
            File.Delete(fileName);
            
            foreach(var product in CommanConstant.productList)
            {
                var json = JsonConvert.SerializeObject(product);

                File.AppendAllText(fileName, json + Environment.NewLine);
                
            }

        }
}
}
