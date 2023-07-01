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
                    if (!string.IsNullOrEmpty(this.UserName.Text.ToString().Trim()) && !string.IsNullOrEmpty(this.PassWord.Text.ToString().Trim()))
                    {
                        if (!UserDataManager.isMobile(UserName.Text.ToString().Trim()))
                        {
                            MessageBox.Show(loginInfo.str_mobileError);
                        }
                        else if (!UserDataManager.isPassWord(this.PassWord.Text.ToString().Trim()))
                        {
                            MessageBox.Show(loginInfo.str_passwordError);
                        }
                        else
                        {
                            if (!UserDataManager.hasExistPerson(this.UserName.Text.ToString()))
                            {
                                MessageBox.Show(loginInfo.str_loginError);
                                this.PassWord.Clear();
                                this.CodePng.Visibility = Visibility.Visible;
                                this.InvitationCode.Visibility = Visibility.Visible;
                                this.InvitationCode.IsReadOnly = false;
                                this.CheckIn.Content = loginInfo.str_register;
                            }
                            else
                            {
                                if (!UserDataManager.isPassWordCorrect(this.UserName.Text.Trim().ToString(), this.PassWord.Text.Trim().ToString()))
                                {
                                    MessageBox.Show(loginInfo.str_passwordNotCorrect);
                                }
                                else
                                {
                                    //登录成功以后再写吧
                                    Application.Current.Dispatcher.Invoke(new Action(() =>
                                    {
                                        this.window.DialogResult = true;
                                    }));


                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(loginInfo.str_loginInfoNotComplete);
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
                            if (!UserDataManager.hasExistPerson(this.UserName.Text.Trim().ToString()))
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
                                this.InvitationCode.Visibility = Visibility.Hidden;
                                this.PassWord.Clear();
                            }
                            else
                            {
                                MessageBox.Show(loginInfo.str_hasBeenRegister);
                            }
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show(loginInfo.str_registerError);
                    }
                }
            }
            catch(Exception exception)
            {
                throw exception;
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
