using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Lab_01_Levchuk.Models;
namespace Lab_01_Levchuk.ViewModels
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual  void OnPropertyChanged(string propertyName)
        {
         
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        
        }
        public ICommand ButtonCommand { get; set; }

        public MainVM()
        {
            ButtonCommand = new RelayCommand(o => MainButtonClick("MainButton"));
        }

        private async void MainButtonClick(object sender)
        {
            bool Birthday = false;
            ShowLoader();
            await Task.Run(() =>
            {
                UpdateTextBoxes();
                Birthday = BirthdayInfo.IsBirthday(ChosenDate);
            });
            HideLoader();
            if (AgeInfo.Length == 0)
            {
                MessageBox.Show("Your entered date of birth is incorrect! The computed age can not be lower or qual to 0 and higher than 135 years old. Try again!");
            }
            else if (Birthday) MessageBox.Show("Hey, it`s your birthday today! Congratulations!");
        }
        private Visibility _loaderVisibility = Visibility.Collapsed;
        public Visibility LoaderVisibility
        {
            set => _loaderVisibility = value;
            get => _loaderVisibility;
        }
        private void ShowLoader()
        {
            LoaderVisibility = Visibility.Visible;
            OnPropertyChanged("LoaderVisibility");
        }
        private void HideLoader()
        {
            LoaderVisibility = Visibility.Collapsed;
            OnPropertyChanged("LoaderVisibility");
        }
        public string AgeInfo {
            get {
                
               int result= BirthdayInfo.GetAge(ChosenDate);
                if (result > 0 && result < 135) return "You are "+result.ToString()+" year(s) old.";
                return "";
            }
        }
        public string WesternZodiacInfo
        {
            get
            {
             
                if (AgeInfo.Length!=0) return "Your Western zodiac sign is " + BirthdayInfo.WesternZodiac(ChosenDate);
                return "";
            }
        }

        public string ChineseZodiacInfo
        {
            get
            {
                if (AgeInfo.Length != 0) return "Your Eastern zodiac sign is " + BirthdayInfo.EasternZodiac(ChosenDate);
                return "";
            }
        }
        private DateTime _chosenDate=DateTime.Now;
        public DateTime ChosenDate
        {
            get { return _chosenDate; }
            set
            {
       
                _chosenDate = value;
                
            }
        }
   private void UpdateTextBoxes()
        {
            OnPropertyChanged("AgeInfo");
            OnPropertyChanged("WesternZodiacInfo");
            OnPropertyChanged("ChineseZodiacInfo");
        }
    }
}
