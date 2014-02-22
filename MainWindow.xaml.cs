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
using MahApps.Metro.Controls;

namespace JisResumeGenerater {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : MetroWindow {
        private Dictionary<String, Flyout> dicFlyouts;
        public MainWindow() {
            InitializeComponent();

            this.DataContext = new MainWindowViewModel();

            dicFlyouts = new Dictionary<string,Flyout>();
            foreach (Flyout fly in Flyouts.Items) {
                dicFlyouts.Add(fly.Header, fly);
            }
        }

        public void onTileClicked(object sender, RoutedEventArgs e) {
            var tile = sender as Tile;
            if (tile != null)
                dicFlyouts[tile.Title].IsOpen = true;
        }
        public void onFuncButtonClicked(object sender, RoutedEventArgs e) {
            var button = sender as Button;
            if (button != null) 
                dicFlyouts[button.Content.ToString()].IsOpen = true;
        }
    }
}
