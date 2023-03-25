using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;
using InfoManager.ViewModel;
using InfoManager.DataAccess;
namespace InfoManager.View
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserDataManager userDataManager = new UserDataManager();
            userDataManager.xmlAccess(UserName.Text, PassWord.Text, Num.Text);
        }
    }
}
