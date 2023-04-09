using InfoManager.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoManager.Model
{
    public class LoginModel: NotifyBase
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            { 
                _userName = value;
                this.DoNotify();
            }
        }
    }
}
