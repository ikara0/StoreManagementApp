using BilgeAdam.Common.Contracts;
using InformationModels.Models;
using System;
using System.Windows.Forms;

namespace WFABilgeAdam.StoreManagementMain
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            lblUser.Text = $"Hoşgeldiniz->{AuthenticatedUser.UserName}";
            if (AuthenticatedUser.UserRole != UserRole.Admin)
            {
                btnShowUserActivity.Visible = false;
            }

        }

        private void uygulamadanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Oturumu Kapatmak İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (!(result == DialogResult.Yes))
            {
                return;
            }
            frmMenu_FormClosed(null, null);
        }

        private void btnShowUserActivity_Click(object sender, EventArgs e)
        {
            var frmUserActivity = new frmUserActivity();
            this.Hide();
            frmUserActivity.ShowDialog();
            this.Show();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            var frm = new frmProductManagement();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            var frmManageUser = new frmManageUser();
            this.Hide();
            frmManageUser.ShowDialog();
            this.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var frmReport = new frmReport();
            this.Hide();
            frmReport.ShowDialog();
            this.Show();
        }

        private void btnManageCategory_Click(object sender, EventArgs e)
        {
            var frmCategoryManagement  = new frmCategoryManagement();
            this.Hide();
            frmCategoryManagement.ShowDialog();
            this.Show();
        }
    }
}
