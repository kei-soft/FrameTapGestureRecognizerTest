using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace FrameTapGestureRecognizerTest
{

    public class MainViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Properties

        private bool isBusy = true;

        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        private string test;

        public string Test
        {
            get
            {
                return test;
            }
            set
            {
                test = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands
        public ICommand MenuClickCommand => new Command(() => OnMenuClickCommand());

        #endregion

        // Constructor
        #region MainViewModel
        public MainViewModel()
        {
        }
        #endregion

        // Command Methods
        #region OnMenuClickCommand
        private void OnMenuClickCommand()
        {
            Application.Current.MainPage.DisplayAlert("메뉴선택", "TapGestureRecognizer Tapped", "OK");
        }
        #endregion

        // Methods
    }
}
