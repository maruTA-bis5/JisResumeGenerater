using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using MahApps.Metro.Controls.Dialogs;

namespace JisResumeGenerater {
    class MainWindowViewModel : INotifyPropertyChanged {
        public MainWindowViewModel() {
            ListEdu = new ObservableCollection<JRG_ListViewObject>();
            ListLicense = new ObservableCollection<JRG_ListViewObject>();
        }

        #region 個人情報・日付
        private DateTime? _CreatedAt;
        public DateTime? CreatedAt {
            get { return _CreatedAt; }
            set {
                _CreatedAt = value;
                OnPropertyChanged("CreatedAt");
            }
        }
        private string _FamilyName;
        public string FamilyName {
            get { return _FamilyName; }
            set {
                _FamilyName = value;
                OnPropertyChanged("FamilyName");
            }
        }
        private string _GivenName;
        public string GivenName {
            get { return _GivenName; }
            set {
                _GivenName = value;
                OnPropertyChanged("GivenName");
            }
        }
        private string _FamilyNameKana;
        public string FamilyNameKana {
            get { return _FamilyNameKana; }
            set {
                _FamilyNameKana = value;
                OnPropertyChanged("FamilyNameKana");
            }
        }
        private string _GivenNameKana;
        public string GivenNameKana {
            get { return _GivenNameKana; }
            set {
                _GivenNameKana = value;
                OnPropertyChanged("GivenNameKana");
            }
        }
        private ComboBoxItem _Gender;
        public ComboBoxItem Gender {
            get { return _Gender; }
            set {
                _Gender = value;
                OnPropertyChanged("Gender");
            }
        }
        private DateTime? _BirthDay;
        public DateTime? BirthDay {
            get { return _BirthDay; }
            set {
                _BirthDay = value;
                OnPropertyChanged("BirthDay");
            }
        }
        #endregion

        #region 主連絡先
        private string _MainZip;
        public string MainZip {
            get { return _MainZip; }
            set {
                _MainZip = value;
                OnPropertyChanged("MainZip");
            }
        }
        private string _MainPref;
        public string MainPref {
            get { return _MainPref; }
            set {
                _MainPref = value;
                OnPropertyChanged("MainPref");
            }
        }
        private string _MainPrefKana;
        public string MainPrefKana {
            get { return _MainPrefKana; }
            set {
                _MainPrefKana = value;
                OnPropertyChanged("MainPrefKana");
            }
        }
        private string _MainCity;
        public string MainCity {
            get { return _MainCity; }
            set {
                _MainCity = value;
                OnPropertyChanged("MainCity");
            }
        }
        private string _MainCityKana;
        public string MainCityKana {
            get { return _MainCityKana; }
            set {
                _MainCityKana = value;
                OnPropertyChanged("MainCityKana");
            }
        }
        private string _MainStreet;
        public string MainStreet {
            get { return _MainStreet; }
            set {
                _MainStreet = value;
                OnPropertyChanged("MainStreet");
            }
        }
        private string _MainStreetKana;
        public string MainStreetKana {
            get { return _MainStreetKana; }
            set {
                _MainStreetKana = value;
                OnPropertyChanged("MainStreetKana");
            }
        }
        private string _MainRoomNo;
        public string MainRoomNo {
            get { return _MainRoomNo; }
            set {
                _MainRoomNo = value;
                OnPropertyChanged("MainRoomNo");
            }
        }
        private string _MainRoomNoKana;
        public string MainRoomNoKana {
            get { return _MainRoomNoKana; }
            set {
                _MainRoomNoKana = value;
                OnPropertyChanged("MainRoomNoKana");
            }
        }
        private string _MainTel;
        public string MainTel {
            get { return _MainTel; }
            set {
                _MainTel = value;
                OnPropertyChanged("MainTel");
            }
        }
        #endregion

        #region 副連絡先
        private string _SubZip;
        public string SubZip {
            get { return _SubZip; }
            set {
                _SubZip = value;
                OnPropertyChanged("SubZip");
            }
        }
        private string _SubPref;
        public string SubPref {
            get { return _SubPref; }
            set {
                _SubPref = value;
                OnPropertyChanged("SubPref");
            }
        }
        private string _SubPrefKana;
        public string SubPrefKana {
            get { return _SubPrefKana; }
            set {
                _SubPrefKana = value;
                OnPropertyChanged("SubPrefKana");
            }
        }
        private string _SubCity;
        public string SubCity {
            get { return _SubCity; }
            set {
                _SubCity = value;
                OnPropertyChanged("SubCity");
            }
        }
        private string _SubCityKana;
        public string SubCityKana {
            get { return _SubCityKana; }
            set {
                _SubCityKana = value;
                OnPropertyChanged("SubCityKana");
            }
        }
        private string _SubStreet;
        public string SubStreet {
            get { return _SubStreet; }
            set {
                _SubStreet = value;
                OnPropertyChanged("SubStreet");
            }
        }
        private string _SubStreetKana;
        public string SubStreetKana {
            get { return _SubStreetKana; }
            set {
                _SubStreetKana = value;
                OnPropertyChanged("SubStreetKana");
            }
        }
        private string _SubRoomNo;
        public string SubRoomNo {
            get { return _SubRoomNo; }
            set {
                _SubRoomNo = value;
                OnPropertyChanged("SubRoomNo");
            }
        }
        private string _SubRoomNoKana;
        public string SubRoomNoKana {
            get { return _SubRoomNoKana; }
            set {
                _SubRoomNoKana = value;
                OnPropertyChanged("SubRoomNoKana");
            }
        }
        private string _SubTel;
        public string SubTel {
            get { return _SubTel; }
            set {
                _SubTel = value;
                OnPropertyChanged("SubTel");
            }
        }
        #endregion

        #region 学歴・職歴・賞罰
        public ComboBoxItem EduType { get; set; }
        private string _EduJapEra;
        public string EduJapEra {
            get { return _EduJapEra; }
            set {
                _EduJapEra = value;
                OnPropertyChanged("EduJapEra");
            }
        }
        private string _EduYear;
        public string EduYear {
            get { return _EduYear; }
            set {
                _EduYear = value;
                OnPropertyChanged("EduYear");
            }
        }
        private string _EduMonth;
        public string EduMonth {
            get { return _EduMonth; }
            set {
                _EduMonth = value;
                OnPropertyChanged("EduMonth");
            }
        }
        private string _EduBackground;
        public string EduBackground {
            get { return _EduBackground; }
            set {
                _EduBackground = value;
                OnPropertyChanged("EduBackground");
            }
        }
        public bool EduErrIgnore { get; set; }
        private int _ListEdu_SelectedIndex;
        public int ListEdu_SelectedIndex {
            get { return _ListEdu_SelectedIndex; }
            set {
                _ListEdu_SelectedIndex = value;
            }
        }
        public IList<JRG_ListViewObject> ListEdu { get; set; }
        #endregion

        #region 資格・免許
        private string _LicJapEra;
        public string LicJapEra {
            get { return _LicJapEra; }
            set {
                _LicJapEra = value;
                OnPropertyChanged("LicJapEra");
            }
        }
        private string _LicYear;
        public string LicYear {
            get { return _LicYear; }
            set {
                _LicYear = value;
                OnPropertyChanged("LicYear");
            }
        }
        private string _LicMonth;
        public string LicMonth {
            get { return _LicMonth; }
            set {
                _LicMonth = value;
                OnPropertyChanged("LicMonth");
            }
        }
        private string _LicBackground;
        public string LicBackground {
            get { return _LicBackground; }
            set {
                _LicBackground = value;
                OnPropertyChanged("LicBackground");
            }
        }
        public bool LicErrIgnore { get; set; }
        private int _ListLicense_SelectedIndex;
        private int ListLicense_SelectedIndex {
            get { return _ListLicense_SelectedIndex; }
            set {
                _ListLicense_SelectedIndex = value;
            }
        }
        public IList<JRG_ListViewObject> ListLicense { get; set; }
        #endregion

        private string _Promotion;
        public string Promotion {
            get { return _Promotion; }
            set {
                _Promotion = value;
                OnPropertyChanged("Promotion");
            }
        }

        #region 通勤・扶養・職務上の要望
        private string _CommutingTime;
        public string CommutingTime {
            get { return _CommutingTime; }
            set {
                _CommutingTime = value;
                OnPropertyChanged("CommutingTime");
            }
        }
        private int _FamilyCount;
        public int FamilyCount {
            get { return _FamilyCount; }
            set {
                _FamilyCount = value;
                OnPropertyChanged("FamilyCount");
            }
        }
        private bool _IsMarried;
        public bool IsMarried {
            get { return _IsMarried; }
            set {
                _IsMarried = value;
                OnPropertyChanged("IsMarried");
            }
        }
        private bool _IsSpouseSupport;
        public bool IsSpouseSupport {
            get { return _IsSpouseSupport; }
            set {
                _IsSpouseSupport = value;
                OnPropertyChanged("IsSpouseSupport");
            }
        }
        private string _Request;
        public string Request {
            get { return _Request; }
            set {
                _Request = value;
                OnPropertyChanged("Request");
            }
        }
        #endregion

        public async void EduInsert() {
            if (EduErrIgnore || await _EduInsertCheck()) {
                var obj = new JRG_ListViewObject() {
                    Meta = EduType.Content.ToString(),
                    Era = EduJapEra,
                    Year = EduYear,
                    Month = EduMonth,
                    Detail = EduBackground
                };
                ListEdu.Add(obj);
                EduJapEra = EduYear = EduMonth = EduBackground = "";
            }
        }
        private async Task<bool> _EduInsertCheck() {
            if (String.IsNullOrWhiteSpace(EduJapEra)) {
                await MainWindow.ShowMessageDialog(
                    "注意", "年号が未入力です");
            } else if (String.IsNullOrWhiteSpace(EduYear)) {
                await MainWindow.ShowMessageDialog(
                    "注意", "年が未入力です");
            } else if (String.IsNullOrWhiteSpace(EduMonth)) {
                await MainWindow.ShowMessageDialog(
                    "注意", "月が未入力です");
            } else if (String.IsNullOrWhiteSpace(EduBackground)) {
                await MainWindow.ShowMessageDialog(
                    "注意", "詳細が未入力です");
            } else {
                return true;
            }
            return false;
        }

        public async void LicInsert() {
            if (LicErrIgnore || await _LicInsertCheck()) {
                var obj = new JRG_ListViewObject() {
                    Era = LicJapEra,
                    Year = LicYear,
                    Month = LicMonth,
                    Detail = LicBackground
                };
                ListLicense.Add(obj);
                LicJapEra = LicYear = LicMonth = LicBackground = "";
            }
        }
        private async Task<bool> _LicInsertCheck() {
            if (String.IsNullOrWhiteSpace(EduJapEra)) {
                await MainWindow.ShowMessageDialog(
                    "注意", "年号が未入力です");
            } else if (String.IsNullOrWhiteSpace(EduYear)) {
                await MainWindow.ShowMessageDialog(
                    "注意", "年が未入力です");
            } else if (String.IsNullOrWhiteSpace(EduMonth)) {
                await MainWindow.ShowMessageDialog(
                    "注意", "月が未入力です");
            } else if (String.IsNullOrWhiteSpace(EduBackground)) {
                await MainWindow.ShowMessageDialog(
                    "注意", "詳細が未入力です");
            } else {
                return true;
            }
            return false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String name) {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

    class JRG_ListViewObject {
        public string Meta { get; set; }
        public string Era { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Detail { get; set; }
    }
}
