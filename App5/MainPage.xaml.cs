using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace App5
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
          private void bt2_Click(object sender, RoutedEventArgs e)
        {
            Textblock1.Text = "Hello " + TB1 .Text + "!";

            if (passwordBox.Password =="Password")
            {
                statusText.Text = "'Password' is not allowed as a password.";
            }
            else
            {
                statusText.Text = string.Empty; 
            }
            passwordBox.PlaceholderText = "请输入你的密码"; 
            
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            btnWhat.Flyout.Hide();

        }
        private void btnUndo1_Click(object sender, RoutedEventArgs e)
        {

            btnWhat.Flyout.Hide();

        }
        ImageBrush imageBrush = new ImageBrush();
 


    }
}
    

