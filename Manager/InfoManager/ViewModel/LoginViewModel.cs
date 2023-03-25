using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using InfoManager.Common;

namespace InfoManager.ViewModel
{
    class LoginViewModel
    {
        public CommandBase CloseWindowComnand { get; set; }
        public string UserName { get; set; }
        public LoginViewModel()
        {
            this.CloseWindowComnand = new CommandBase();
            this.CloseWindowComnand.DoExecute = new Action<object>((o) =>
            {
                (o as Window).Close();
            });
            this.CloseWindowComnand.DoCanExecute = new Func<object, bool>((o) => { return true; });
            this.UserName = 1234546.ToString();
        }

    }
}
