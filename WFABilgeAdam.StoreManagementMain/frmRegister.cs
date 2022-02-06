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
    public partial class frmRegister : Form
    {
        public BindingList<User> Users { get; set; }
        public User newUser { get; set; }
        public string path = CommanConstant.LogsDirectoryPath;

        public frmRegister()
        {
    
            Users = CommanConstant.userList;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            errP1.Clear();
            ConditionQuery(txtEmail);
            ConditionQuery(txtName);
            ConditionQuery(txtPassWord);


            if (txtPassWord.Text != txtPassWordAgain.Text)
            {
                errP1.SetError(txtPassWord, "Şifre Uyuşmazlığı!");
                return;
            }

            newUser = new User()
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Password = txtPassWord.Text,
                UserRole = UserRole.LimitedCustomer
            };

            foreach (var user in Users)
            {
                if (user.Email == newUser.Email)
                {
                    errP1.SetError(txtEmail, "E-Mail Sistemde Mevcut");
                    return;
                }
            }
            Users.Add(newUser);
            WriteUserData();
            MessageBox.Show("Kullanıcı Kaydı Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            errP1.Clear();
            if (chkPass.Checked)
            {
                if (!string.IsNullOrEmpty(txtPassWord.Text))
                {
                    txtPassWord.UseSystemPasswordChar = false;
                    txtPassWordAgain.UseSystemPasswordChar = false;
                }
                else
                {
                    errP1.SetError(txtPassWord, "Herhangi Bir Giriş Yapılmadı.");
                    return;
                }
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
                txtPassWordAgain.UseSystemPasswordChar = true;
            }
        }

        private void txtPassWordAgain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null, null);
            }
        }

        private void ConditionQuery(Control control)
        {
            if (control.Text == string.Empty)
            {
                errP1.SetError(control, "Bu alan boş bırakılamaz.");
                return;
            }
        }

        private BindingList<User> GetUserDataList()
        {
            var data = File.ReadAllLines(Path.Combine(path, "UserList.txt"));
            var userList = new BindingList<User>();

            foreach (var item in data)
            {
                userList.Add((User)JsonConvert.DeserializeObject(item, typeof(User)));
            }
            return userList;
        }


        private void WriteUserData()
        {
            var jsonLog = JsonConvert.SerializeObject(newUser);

            File.AppendAllText(Path.Combine(path, "UserList.txt"), jsonLog + Environment.NewLine);
        }

    }
}
