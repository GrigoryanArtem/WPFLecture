using System.Collections.Generic;
using System.Linq;
using WPFLecture.Model;
using WPFLecture.Models;
using WPFLecture.Models.Navigation;
using WPFLecture.Views;

namespace WPFLecture.ViewModels
{
    public class NumberBPageViewModel : CustomBindableBase
    {
        private DataForMVVM mData;
        private List<int> mValues;

        public NumberBPageViewModel()
        {
            mValues = Enumerable.Range(-50, 100).ToList();
            mData = new DataForMVVM(DataService.CurrentData);
            mData.PropertyChanged += (s, e) => OnPropertyChanged(e.PropertyName);

            GoBackCommand = new CustomCommand(obj => Navigator.Navigate(new MainPage(), new MainPageViewModel()));
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
            }
        }

        public IEnumerable<int> Values
        {
            get
            {
                return mValues;
            }
        }

        public CustomCommand GoBackCommand { get; }
    }
}
