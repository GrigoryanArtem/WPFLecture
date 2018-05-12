using WPFLecture.Model;
using WPFLecture.Models;
using WPFLecture.Models.Navigation;
using WPFLecture.Views;

namespace WPFLecture.ViewModels
{
    public class MainPageViewModel : CustomBindableBase
    {
        private DataForMVVM mData;
        private DataCalculator mCalculator;

        private double mLastDivideResult;

        public MainPageViewModel()
        {
            mCalculator = new DataCalculator();

            mData = new DataForMVVM(DataService.CurrentData);
            mData.PropertyChanged += (s, e) => OnPropertyChanged(e.PropertyName);

            DivideCommand = new CustomCommand(obj => LastDivideResult = mCalculator.Divide(mData.Target));
            GoToACommand = new CustomCommand(obj => Navigator.Navigate(new NumberAPage(), new NumberAPageViewModel()));
            GoToBCommand = new CustomCommand(obj => Navigator.Navigate(new NumberBPage(), new NumberBPageViewModel()));
        }

        #region Properties

        public int NumberA
        {
            get
            {
                return mData.NumberA;
            }
            set
            {
                mData.NumberA = value;
                OnPropertyChanged(nameof(Sum));
            }
        }

        public int NumberB
        {
            get
            {
                return mData.NumberB;
            }
            set
            {
                mData.NumberB = value;
                OnPropertyChanged(nameof(Sum));
            }
        }

        public int Sum
        {
            get
            {
                return mCalculator.Sum(mData.Target);
            }
        }

        public double LastDivideResult
        {
            get
            {
                return mLastDivideResult;
            }
            private set
            {
                mLastDivideResult = value;
                OnPropertyChanged(nameof(LastDivideResult));
            }
        }

        #endregion

        #region Commands

        public CustomCommand DivideCommand { get; }
        public CustomCommand GoToACommand { get; }
        public CustomCommand GoToBCommand { get; }

        #endregion
    }
}
