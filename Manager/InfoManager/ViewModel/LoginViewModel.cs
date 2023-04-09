using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using InfoManager.Common;
using InfoManager.Model;

namespace InfoManager.ViewModel
{
    class LoginViewModel
    {
        public CommandBase CloseWindowComnand { get; set; }
        public LoginModel LoginModel { get; set; }
        public string user { get; set; }
        public LoginViewModel()
        {
            this.LoginModel = new LoginModel();
            this.CloseWindowComnand = new CommandBase();
            this.CloseWindowComnand.DoExecute = new Action<object>((o) =>
            {
                (o as Window).Close();
            });
            this.CloseWindowComnand.DoCanExecute = new Func<object, bool>((o) => { return true; });
            this.LoginModel.UserName = 19955432136.ToString();
            this.user = 123456.ToString();
        }

    }
}
