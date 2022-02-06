using InformationModels;
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
    }
}
