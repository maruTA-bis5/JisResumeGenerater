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
using MahApps.Metro.Controls.Dialogs;

namespace JisResumeGenerater {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : MetroWindow {
        private Dictionary<String, Flyout> dicFlyouts;
        public MainWindow() {
            InitializeComponent();
            _instance = this;
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
        public void btEduInsert(object sender, RoutedEventArgs e) {
            ((MainWindowViewModel)this.DataContext).EduInsert();
        }
        public void btLicInsert(object sender, RoutedEventArgs e) {
            ((MainWindowViewModel)this.DataContext).LicInsert();
        }

        public void findByMainZip(object sender, RoutedEventArgs e) {
            var viewmodel = DataContext as MainWindowViewModel;
            var zip = viewmodel.MainZip;
            var api = new YubinSenmonApi();
            var address = api.fetchAddressByPostcode(zip)[0];
            viewmodel.MainPref = address.pref;
            viewmodel.MainPrefKana = address.pref_kana;
            viewmodel.MainCity = address.city;
            viewmodel.MainCityKana = address.city_kana;
            viewmodel.MainStreet = address.town;
            viewmodel.MainStreetKana = address.town_kana;
        }
        public void findBySubZip(object sender, RoutedEventArgs e) {
            var viewmodel = DataContext as MainWindowViewModel;
            var zip = viewmodel.SubZip;
            var api = new YubinSenmonApi();
            var address = api.fetchAddressByPostcode(zip)[0];
            viewmodel.SubPref = address.pref;
            viewmodel.SubPrefKana = address.pref_kana;
            viewmodel.SubCity = address.city;
            viewmodel.SubCityKana = address.city_kana;
            viewmodel.SubStreet = address.town;
            viewmodel.SubStreetKana = address.town_kana;
        }

        private static MetroWindow _instance = null;
        public static Task<MessageDialogResult> ShowMessageDialog(string title, string message) {
            return DialogManager.ShowMessageAsync(_instance, title, message);
        }
    }
}
