using System;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using MahApps.Metro;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;

namespace AlphaBIM
{
    /// <summary>
    /// Interaction logic for ProgressBars.xaml
    /// </summary>
    public partial class ProgressBarsWait
    {
        //AlphaBIMConstraint dlqConstraint = new AlphaBIMConstraint();
        public ProgressBarsWait()
        {
            ColorZoneAssist.SetMode(new System.Windows.Controls.GroupBox(), ColorZoneMode.Dark); new MahAppsException(); new CustomDataGrid();
            
            new Hue("name", System.Windows.Media.Color.FromArgb(1, 2, 3, 4),
                System.Windows.Media.Color.FromArgb(1, 5, 6, 7));

            //Icon = dlqConstraint.IconWindow;
            InitializeComponent();

            //ResourcesFolder = Path.Combine(ContentsFolder, "Resources");
            //HelpFolder = Path.Combine(ResourcesFolder, "Help");
            //ImageFolder = Path.Combine(ResourcesFolder, "Image");
            //RebarShapeFolder = Path.Combine(ResourcesFolder, "RebarShape");
            //iconWindowPath = Path.Combine(ImageFolder, IconWindowICO);
            //iconWindowUri = new Uri(iconWindowPath, UriKind.Absolute);
            //IconWindow = new BitmapImage(iconWindowUri);
        }
    }
}