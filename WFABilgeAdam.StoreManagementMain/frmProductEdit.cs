using BilgeAdam.Common.Contracts;
using InformationModels;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WFABilgeAdam.StoreManagementMain
{
    public partial class frmProductEdit : Form
    {
        private BindingList<Product> Products;
        private Product product;
        private int selecetedIndex;
        public frmProductEdit(Product product)
        {
            this.product = product;
            this.Products = CommanConstant.productList;

            InitializeComponent();
        }

        private void frmProductEdit_Load(object sender, EventArgs e)
        {
            selecetedIndex = Products.IndexOf(product);
            txtName.Text = product.Name;
            txtCode.Text = product.Code;
            nudPrice.Value = product.Price;
            cmbCategory.DataSource = Enum.GetValues(typeof(Category));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtCode.Text))
            {
                return;
            }

            product.Name = txtName.Text;
            product.CreatedAt = DateTime.Now;
            product.CreatedBy = new User() { Email = AuthenticatedUser.Email };
            product.Code = txtCode.Text;
            product.Price = nudPrice.Value;
            product.Category = (Category)cmbCategory.SelectedIndex;

            this.Close();


        }

    }
}
