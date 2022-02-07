using BilgeAdam.Common.Contracts;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace WFABilgeAdam.StoreManagementMain
{
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void chkForExist_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkForExist.Checked)
            {
                var userEmail = txtEmail.Text;
                txtPassword.Text = String.Empty;
                foreach (var item in CommanConstant.userList)
                {
                    if (item.Email == userEmail)
                    {
                        var pass = item.Password.Substring(0, 2);
                        txtPassword.Text = $"{pass}***";
                        return;
                    }
                }
                MessageBox.Show("Girdiğiniz Email Sistemde Kayıtlı Değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var userEmail = txtEmail.Text;
            var userPass = txtConfirmPassword.Text;

            foreach (var item in CommanConstant.userList)
            {
                if (item.Email == userEmail && item.Password == userPass)
                {
                    if (!(txtConfirmPassword.Text == txtResetPassword.Text))
                    {
                        item.Password = txtResetPassword.Text;
                        return;
                    }
                    errPassword.SetError(txtResetPassword, "Şifreler Aynı Olamaz!");
                    return;
                }
            }

            MessageBox.Show("Şifre Başarıyla Güncellendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmResetPassword_FormClosing(object sender, FormClosingEventArgs e)
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
