using System.Windows;
using System.Windows.Input;
using InfoManager.ViewModel;
using InfoManager.DataAccess;
using InfoManager.Model;
using System.IO;
using System;

namespace InfoManager.View
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public LoginModel loginInfo;
        public Login()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                loginInfo = new LoginModel();
                string invitationCodes = File.ReadAllText(@"..\..\Assets\InvitationCode.txt");
                string[] Codes = invitationCodes.Split(',');
                UserDataManager userDataManager = new UserDataManager();
                if (this.CheckIn.Content.ToString().Equals(loginInfo.str_login))
                {
                    if (!userDataManager.hasExistPerson(this.UserName.ToString()))
                    {
                        MessageBox.Show(loginInfo.str_loginError);
                        this.CheckIn.Content = loginInfo.str_register;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(this.UserName.Text.ToString().Trim()) && !string.IsNullOrEmpty(this.PassWord.Text.ToString().Trim()) && !string.IsNullOrEmpty(this.InvitationCode.Text.ToString().Trim()))
                    {
                        if (!UserDataManager.isMobile(UserName.Text.ToString().Trim()))
                        {
                            MessageBox.Show(loginInfo.str_mobileError);
                        }
                        else if (!UserDataManager.isPassWord(this.PassWord.Text.ToString().Trim()))
                        {
                            MessageBox.Show(loginInfo.str_passwordError);
                        }
                        else if (!UserDataManager.isInvitationCode(this.InvitationCode.Text.ToString().Trim(), Codes))
                        {
                            MessageBox.Show(loginInfo.str_invitationCodeError);
                        }
                        else
                        {
                            loginInfo.UserName = this.UserName.Text.Trim().ToString();
                            loginInfo.PassWord = this.PassWord.Text.Trim().ToString();
                            loginInfo.InvitationCode = this.InvitationCode.Text.Trim().ToString();
                            //注册信息保存到xml中
                            UserDataManager.xmlAccess(loginInfo.UserName, loginInfo.PassWord, loginInfo.InvitationCode);
                            MessageBox.Show(loginInfo.str_success);
                            //设置成功的标志位
                            loginInfo.isRegister = LoginModel.isRegisterSuccess.Success;
                            this.CheckIn.Content = loginInfo.str_login;
                        }
                    }
                    else
                    {
                        MessageBox.Show(loginInfo.str_registerError);
                    }
                }
            }
            catch(Exception excption)
            {
                throw excption;
            }            
        }

        //拖动
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
