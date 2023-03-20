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

namespace 重量單位轉換程式
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string strInput; // 字串型態的strInput變數
        double douOutput;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtMg.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtg.Text = string.Format("{0:0.##########}", _value / 1000);
            if (_kind != 2)
                txtKg.Text = string.Format("{0:0.##########}", _value / 1000000);
            if (_kind != 3)
                txtt.Text = string.Format("{0:0.##########}", _value / 1000000000);
            if (_kind != 4)
                txtOz.Text = string.Format("{0:0.##########}", _value / 28349.523125);
            if (_kind != 5)
                txtIb.Text = string.Format("{0:0.##########}", _value / 453592.37);
        }

        private void txtMg_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtMg.Text; 

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtMg.Text = "";
            }
        }

        private void txtg_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtg.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 1000); 
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtg.Text = "";
            }
        }

        private void txtKg_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKg.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 1000000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKg.Text = "";
            }
        }

        private void txtt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtt.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 1000000000);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtt.Text = "";
            }
        }

        private void txtOz_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtOz.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 28349.523125);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtOz.Text = "";
            }
        }

        private void txtIb_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIb.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 453592.37);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtIb.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtMg.Text = "";
            txtg.Text = "";
            txtKg.Text = "";
            txtt.Text = "";
            txtOz.Text = "";
            txtIb.Text = "";
        }
    }
    
}
