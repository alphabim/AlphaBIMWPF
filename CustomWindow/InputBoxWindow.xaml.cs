using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace AlphaBIM
{
    public partial class InputBoxWindow : INotifyPropertyChanged
    {
        private string _textPrompt;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string TextPrompt
        {
            get => _textPrompt;
            set
            {
                _textPrompt = value;
                OnPropertyChanged();
            }
        }

        public string InputValue { get; set; }

        public InputBoxWindow(string textPrompt)
        {
            InitializeComponent();
            TextPrompt = textPrompt;
            DataContext = this;
            this.InputBox?.Focus();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space || e.Key == Key.Enter)
            {
                DialogResult = true;
                Close();
            }
            if (e.Key == Key.Escape)
            {
                DialogResult = false;
                Close();
            }
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Height = DockPanel.ActualHeight + 55;
            Width = DockPanel.ActualWidth + 15;
        }

        #region Copy Title bar

        private void OpenWebSite(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("https://alphabimvn.com/vi");
            }
            catch (Exception)
            {
            }
        }

        private void CustomDevelopment(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("http://bit.ly/3bNeJek");
            }
            catch (Exception)
            {
            }
        }

        private void Feedback(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("mailto:contact@alphabimvn.com");
            }
            catch (Exception)
            {
            }
        }

        private void Donate(object sender, RoutedEventArgs e)
        {
        }

        #endregion Copy Title bar
    }
}
