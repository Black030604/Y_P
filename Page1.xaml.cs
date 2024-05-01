using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
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
using HtmlAgilityPack;

namespace У_П
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            LoadTextFile(" D:\\У_П\\У_П\\MyDoc\\Основы ООП.txt");
        }
       
        private void MaxBut1_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.WindowState = WindowState.Maximized;
            }
           
        }

        private void MinBut1_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if(parentWindow!=null)
            {
                parentWindow.WindowState = WindowState.Minimized;
            }
            
        }

        private void BClose1_Click_1(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            parentWindow?.Close();
        }


        private void LoadTextFile(string filePath)
        {
            string text = File.ReadAllText(filePath);

            TextRange range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            range.Text = text;
            richTextBox.FontSize = 20;
            richTextBox.FontFamily = new FontFamily("Arial");
        }
       




        private void Btn_glav_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Glavnaya());
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Page_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
        }
    }
}
