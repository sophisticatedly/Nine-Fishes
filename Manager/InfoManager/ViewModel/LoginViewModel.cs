using System;
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
        }

    }
}
