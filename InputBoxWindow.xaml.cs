using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using MahApps.Metro;
using System.Windows.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.IO;
using System;
using System.Windows.Media.Imaging;

namespace AlphaBIM
{
    /// <summary>
    /// Interaction logic for SelectByIDs.xaml
    /// </summary>
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
            ColorZoneAssist.SetMode(new System.Windows.Controls.GroupBox(), ColorZoneMode.Dark); new MahAppsException(); new CustomDataGrid();
            
            new Hue("name", System.Windows.Media.Color.FromArgb(1, 2, 3, 4),
                System.Windows.Media.Color.FromArgb(1, 5, 6, 7));

            string contentsFolder =
                "C:\\ProgramData\\Autodesk\\ApplicationPlugins\\AlphaBIM.bundle\\Contents";
            string ImageFolder = Path.Combine(contentsFolder, "Resources", "Image");
            string iconWindowPath = Path.Combine(ImageFolder, "AlphaBIM.ico");
            Uri iconWindowUri = new Uri(iconWindowPath, UriKind.Absolute);
            Icon = new BitmapImage(iconWindowUri);

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
    }
}
