using WPFLecture.Model;
using WPFLecture.Models;
using WPFLecture.Models.Navigation;
using WPFLecture.Views;

namespace WPFLecture.ViewModels
{
    public class NumberAPageViewModel : CustomBindableBase
    {
        private DataForMVVM mData;

        public NumberAPageViewModel()
        {
            mData = new DataForMVVM(DataService.CurrentData);
            mData.PropertyChanged += (s, e) => OnPropertyChanged(e.PropertyName);

            GoBackCommand = new CustomCommand(obj => Navigator.Navigate(new MainPage(), new MainPageViewModel()));
        }

        public int NumberA
        {
            get
            {
                return mData.NumberA;
            }
            set
            {
                mData.NumberA = value;
            }
        }

        public CustomCommand GoBackCommand { get; }
    }
}
