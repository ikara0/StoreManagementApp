using BilgeAdam.Common.Contracts;
using InformationModels.Dtos;
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
    public partial class frmUserActivity : Form
    {
        public frmUserActivity()
        {
            InitializeComponent();
        }

        private void frmUserActivity_Load(object sender, EventArgs e)
        {

            var jsonUserLogs = File.ReadAllLines(Path.Combine(CommanConstant.LogsDirectoryPath,"UserLog.txt"));
            var userLogs = new BindingList<UserLogDto>();
            foreach (var log in jsonUserLogs)
            {
                userLogs.Add((UserLogDto)JsonConvert.DeserializeObject(log, typeof(UserLogDto)));
            }

            dgvListUserLogs.DataSource = userLogs;
        }
    }
}
