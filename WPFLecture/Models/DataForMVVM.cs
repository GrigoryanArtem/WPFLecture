using WPFLecture.Model;

namespace WPFLecture.Models
{
    public class DataForMVVM : CustomBindableBase
    {
        private Data mData;

        public DataForMVVM(Data data)
        {
            mData = data;
        }

        #region Properties

        public Data Target => mData;

        public int NumberA
        {
            get
            {
                return mData.NumberA;
            }
            set
            {
                mData.NumberA = value;
                OnPropertyChanged(nameof(NumberA));
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
                OnPropertyChanged(nameof(NumberB));
            }
        }

        #endregion
    }
}
