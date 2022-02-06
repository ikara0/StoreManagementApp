using BilgeAdam.Common.Contracts;
using InformationModels;
using InformationModels.Dtos;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace WFABilgeAdam.StoreManagementMain
{
    public partial class frmLogin : Form
    {

        public BindingList<User> Users { get; set; }
        public string path = CommanConstant.LogsDirectoryPath;
        public frmLogin()
        {
            CommanConstant.userList = GetUserDataList();
            CommanConstant.productList = GetProductData();

            InitializeComponent();
            Users = CommanConstant.userList;
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            var isAuthorized = false;
            foreach (var user in Users)
            {
                errP1.Clear();
                if (user.Email == txtEmail.Text && user.Password == txtPassWord.Text)
                {
                    MessageBox.Show($"Hoşgeldiniz! {user.Name}");
                    isAuthorized = true;
                    AuthenticatedUser.UserName = user.Name;
                    AuthenticatedUser.Email = user.Email;
                    AuthenticatedUser.UserRole = user.UserRole;
                    break;
                }

            }
            if (!isAuthorized)
            {
                errP1.SetError(txtEmail, "E-mail veya Şifre Hatalı, Lütfen Tekrar Deneyiniz.");
                txtEmail.Clear();
                txtPassWord.Clear();
                txtEmail.Focus();
                return;
            }

            WriteLoginLogs();
            var frmMenu = new frmMenu();
            Hide();
            frmMenu.ShowDialog();
            txtPassWord.Text = string.Empty;
            Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var frm = new frmRegister();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkPass.Checked)
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
        }

        #region Methods

        private void WriteLoginLogs()
        {
            var path = CommanConstant.LogsDirectoryPath;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var newLog = new UserLogDto { Email = AuthenticatedUser.Email, LoginDate = DateTime.Now, Role = AuthenticatedUser.UserRole, UserName = AuthenticatedUser.UserName };

            var jsonLog = JsonConvert.SerializeObject(newLog);

            File.AppendAllText(Path.Combine(path, "UserLog.txt"), jsonLog + Environment.NewLine);
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

        private BindingList<Product> GetProductData()
        {
            var data = File.ReadAllLines(Path.Combine(path, "ProductLog.txt"));
            var productList = new BindingList<Product>();

            foreach (var item in data)
            {
                productList.Add((Product)JsonConvert.DeserializeObject(item, typeof(Product)));
            }
            return productList;
        }


        #endregion

    }
}
