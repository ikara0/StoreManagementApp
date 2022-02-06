using BilgeAdam.Common.Contracts;
using InformationModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFABilgeAdam.StoreManagementMain
{
    public partial class frmAddProduct : Form
    {
        private BindingList<Product> products;
        public frmAddProduct()
        {
            this.products = CommanConstant.productList;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errP1.Clear();
            ConditionQuery(txtProductName);
            ConditionQuery(txtProductCode);

            if (cmbCategory.SelectedIndex==-1)
            {
                errP1.SetError(cmbCategory, "Bir Tür Seçmeden Kayıt Oluşturamazsınız.");
                return;
            }

            WriteProductLogs();
            

            MessageBox.Show("Ürün Kaydedildi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);

            this.Close();
           
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
           cmbCategory.DataSource = Enum.GetValues(typeof(Category));
           cmbCategory.SelectedIndex = -1;
        }

        private void ConditionQuery(Control control)
        {
            if (control.Text == string.Empty)
            {
                errP1.SetError(control, "Bu alan boş bırakılamaz.");
                return;
            }
        }

        private void WriteProductLogs()
        {
            var path = CommanConstant.LogsDirectoryPath;

            var product = new Product(txtProductName.Text, txtProductCode.Text, Convert.ToDecimal(nudPrice.Value), new User() { Email = AuthenticatedUser.Email }, DateTime.Now, (Category)cmbCategory.SelectedItem);
            products.Add(product);

            var jsonProductLog = JsonConvert.SerializeObject(product);

            File.AppendAllText(Path.Combine(path, "ProductLog.txt"), jsonProductLog + Environment.NewLine);
        }

    }
}
