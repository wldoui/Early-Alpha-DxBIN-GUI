using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Windows;
using System.Drawing;
using System.ComponentModel;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Gui
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            overlayPanel.Visibility = Visibility.Collapsed;
            overlayPanelText.Visibility = Visibility.Collapsed;
        }

        private void myButton1_Click(object sender, RoutedEventArgs e)
        {
            string inputText = myTextBox.Text;

            if (string.IsNullOrWhiteSpace(inputText) || (inputText.Length >= 12))
            {
                if (inputText.StartsWith("+"))
                {
                    ShowErrorPanel(inputText);
                }
                else
                {
                    ShowErrorPanel2(inputText);
                }
            }
            else
            {
                ShowErrorPanel2(inputText);
            }
        }

        private void myButton2_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }

        private void myTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ShowError(string message)
        {
            // Покажите сообщение об ошибке (например, через MessageBox или TextBlock)
            Console.WriteLine(message);
        }
        private void HideError()
        {
            // Скрыть сообщение об ошибке
        }

        private void ShowPanel(string text)
        {
            overlayPanel.Visibility = Visibility.Visible;
            overlayPanelText.Text = text;
        }

        private void ShowErrorPanel(string text)
        {
            overlayPanelText.Text = ("Данный номер отсутствует в базах данных.");
            overlayPanelText.Visibility = Visibility.Visible;
            overlayPanel.Visibility = Visibility.Visible;
        }
        private void ShowErrorPanel2(string text)
        {
            overlayPanelText.Text = ("Введен некорректный набор символов.");
            overlayPanelText.Visibility = Visibility.Visible;
            overlayPanel.Visibility = Visibility.Visible;
        }

    }
}