﻿using System;
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

namespace 長度單位轉換程式_新_
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
        string strInput;
        double douOutput;

        private void caculateAnswer(int _kind, double _value)
        {
          if (_kind != 0)
             txtCM.Text = string.Format("{0:0.##########}", _value);
          if (_kind != 1)
             txtM.Text = string.Format("{0:0.##########}", _value / 100);
          if (_kind != 2)
             txtKM.Text = string.Format("{0:0.##########}", _value / 100000);
          if (_kind != 3)
             txtIn.Text = string.Format("{0:0.##########}", _value / 2.54);
          if (_kind != 4)
             txtFt.Text = string.Format("{0:0.##########}", _value / 30.48);
          if (_kind != 5)
             txtYard.Text = string.Format("{0:0.##########}", _value / 91.44);
}

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                //我們把以下的單位轉換，改成可以共用的函式
                //txtM.Text = string.Format("{0:0.##########}", douOutput / 100);
                //txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                //txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                //txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                //txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);

                //執行計算長度函式
                caculateAnswer(0, douOutput);
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 100); // 事先將公尺轉換成公分
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 100000); 
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIn.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 2.54); 
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtFt.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 30.48); 
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtYard.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 91.44); 
            }
            else
            {
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }
    }
}
