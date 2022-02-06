using BilgeAdam.Common.Contracts;
using InformationModels;
using InformationModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFABilgeAdam.StoreManagementMain
{
    public partial class frmUserEdit : Form
    {
        private BindingList<User> users;
        private User user;
        public frmUserEdit(User user)
        {
            this.user = user;
            this.users = CommanConstant.userList;
            InitializeComponent();
        }

        private void frmUserEdit_Load(object sender, EventArgs e)
        {
            cmbUserRole.DataSource = Enum.GetValues(typeof(UserRole));
            txtUserEmail.Text = user.Email;
            txtUserName.Text = user.Name;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtUserEmail.Text))
            {
                return;
            }
            user.Name = txtUserName.Text;
            user.Email = txtUserEmail.Text;
            user.UserRole = (UserRole)cmbUserRole.SelectedIndex;

            this.Close();
        }


    }
}
