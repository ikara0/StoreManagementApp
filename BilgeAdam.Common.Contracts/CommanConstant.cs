using InformationModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Common.Contracts
{
    public static class CommanConstant
    {
        public static string LogsDirectoryPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Logs");

        public static BindingList<User> userList = new BindingList<User>();
        public static BindingList<Product> productList = new BindingList<Product>();

        public static void RefreshLogs<T>(BindingList<T> listOfItem,string log)
        {
            var fileName = Path.Combine(LogsDirectoryPath, log);
            File.Delete(fileName);

            foreach (var item in listOfItem)
            {
                var json = JsonConvert.SerializeObject(item);

                File.AppendAllText(fileName, json + Environment.NewLine);

            }

        }
    }
}
