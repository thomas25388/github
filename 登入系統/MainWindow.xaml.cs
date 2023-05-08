using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 登入系統
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            if (username == "abc" && password == "123")
            {
                txtmessage.Text = "登入成功";
            }
            else
            {
                txtmessage.Text = "登入失敗";
            }
        }
    }
}
