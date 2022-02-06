using BilgeAdam.Common.Contracts;
using InformationModels;
using InformationModels.Models;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace WFABilgeAdam.StoreManagementMain
{
    public partial class frmManageUser : Form
    {
        private BindingList<User> users;
        public frmManageUser()
        {
            users = CommanConstant.userList;
            InitializeComponent();
        }

        private void frmManageUser_Load(object sender, EventArgs e)
        {
            
            dgvUserList.DataSource = users;
            if (AuthenticatedUser.UserRole != UserRole.Admin)
            {
                cmtUserEdit.Enabled = false;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userEmail = dgvUserList.CurrentRow.Cells[1].Value.ToString();

            foreach (var item in users)
            {
                if (item.Email == userEmail)
                {
                    CommanConstant.userList.Remove(item);
                    return;
                }
            }
        }


        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userEmail = dgvUserList.CurrentRow.Cells[1].Value.ToString();

            foreach (var user in users)
            {
                if (userEmail == user.Email)
                {
                    var frmUserEdit = new frmUserEdit(user);
                    this.Hide();
                    frmUserEdit.ShowDialog();
                    this.Show();
                    break;
                }
            }
        }
        private void frmManageUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            var fileName = Path.Combine(CommanConstant.LogsDirectoryPath, "UserList.txt");
            File.Delete(fileName);

            foreach (var user in CommanConstant.userList)
            {
                var json = JsonConvert.SerializeObject(user);

                File.AppendAllText(fileName, json + Environment.NewLine);

            }
        }
    }
}
