using BilgeAdam.Common.Contracts;
using InformationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFABilgeAdam.StoreManagementMain
{
    public partial class frmCategoryManagement : Form
    {
        public frmCategoryManagement()
        {
            InitializeComponent();
        }

        private void frmCategoryManagement_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = Enum.GetValues(typeof(Category));

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Düzeltilecek","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
           this.Close();
        }

    }
}
