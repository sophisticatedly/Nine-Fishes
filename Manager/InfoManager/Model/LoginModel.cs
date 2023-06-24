using InfoManager.Common;


namespace InfoManager.Model
{
    public class LoginModel: NotifyBase
    {
        public LoginModel()
        {
            this.UserName = string.Empty;
            this.PassWord = string.Empty;
            this.InvitationCode = string.Empty;
            this.isRegister = isRegisterSuccess.None;
            this.str_register = "注册";
            this.str_login = "登录";
            this.str_loginError = "该号码没有注册过，请先注册您的信息";
            this.str_loginInfoNotComplete = "登录信息不完整";
            this.str_registerError = "注册资料不完整";
            this.str_mobileError = "请输入正确的手机号";
            this.str_passwordError = "密码需要6-12个数字、26个英文字母或者下划线组成";
            this.str_invitationCodeError = "安全邀请码输入错误";
            this.str_hasBeenRegister = "该号码已经被注册过";
            this.str_passwordNotCorrect = "密码输入错误";
            this.str_success = "注册成功！";
            this.str_loginSuccess = "登录成功!";
        }
        public enum isRegisterSuccess
        {
            None = 0,
            Success = 1,
            Fail = 2,
            Error = 3
        }

        private string _userName;
        private string _passWord;
        private string _invitationCode;
        public isRegisterSuccess isRegister;
        public string str_register;
        public string str_login;
        public string str_registerError;
        public string str_loginInfoNotComplete;
        public string str_loginError;
        public string str_mobileError;
        public string str_passwordError;
        public string str_invitationCodeError;
        public string str_hasBeenRegister;
        public string str_passwordNotCorrect;
        public string str_success;
        public string str_loginSuccess;

        public string UserName
        {
            get { return _userName; }
            set
            { 
                _userName = value;
                this.DoNotify();
            }
        }

        public string PassWord
        {
            get { return _passWord; }
            set
            {
                _passWord = value;
                this.DoNotify();
            }
        }

        public string InvitationCode
        {
            get { return _invitationCode; }
            set
            {
                _invitationCode = value;
                this.DoNotify();
            }
        }      
    }
}
