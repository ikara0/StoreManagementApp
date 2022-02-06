using BilgeAdam.Common.Contracts;
using InformationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace WFABilgeAdam.StoreManagementMain
{
    public partial class frmReport : Form
    {
        private BindingList<Product> products;
        public frmReport()
        {
            this.products = CommanConstant.productList;
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            SortedDictionary<Category, List<Product>> dict = CategoryList();

            CategoryReport(dict);

        }

        #region Methods
        private SortedDictionary<Category, List<Product>> CategoryList()
        {
            var dict = new SortedDictionary<Category, List<Product>>();

            foreach (var product in products)
            {
                if (dict.ContainsKey(product.Category))
                {
                    dict[product.Category].Add(product);
                }
                else
                {
                    dict.Add(product.Category, new List<Product> { product });
                }
            }

            return dict;
        }

        private void CategoryReport(SortedDictionary<Category, List<Product>> dict)
        {
            var count = 1;
            foreach (var item in dict.Keys)
            {
                rtbReport.AppendText($"Ürün Kategorisi => {item}" + Environment.NewLine);

                foreach (var product in dict[item])
                {
                    rtbReport.AppendText($" --------------{count}---->Ürün Adı: {product.Name}/ Ürün Kodu: {product.Code}/ Fiyatı: {product.Price}");
                    rtbReport.AppendText(Environment.NewLine);
                    count++;
                }
                count = 1;
                rtbReport.AppendText(Environment.NewLine);
                rtbReport.AppendText(Environment.NewLine);
            }
        } 
        #endregion

    }
}
