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
using System.IO; // 要引用這個IO函式庫，才能作檔案處理

namespace NotePad
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // 開啟一個存檔對話框
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            // 設定檔案過濾，可以選擇只顯示純文字檔（*.txt）
            dlg.Filter = "純文字資料 (*.txt)|*.txt|All files (*.*)|*.*";

            // ShowDialog() 來顯示對話框，如果點選存檔按鍵，會等於 true
            if (dlg.ShowDialog() == true)
            {
                // 放入你要處理的事情
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            // 開啟一個開啟檔案對話框
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "純文字資料 (*.txt)|*.txt|All files (*.*)|*.*";

            // ShowDialog() 來顯示對話框，如果點選開啟按鍵，會等於 true
            if (dlg.ShowDialog() == true)
            {
                // 放入你要處理的事情
            }
        }
    }