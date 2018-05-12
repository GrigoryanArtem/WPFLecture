using System;

namespace WPFLecture.Model
{
    public class DataService
    {
        #region Singleton

        private static volatile DataService mInstance;
        private static object _sync = new Object();

        private DataService()
        {
            mData = new Data();
        }

        private static DataService Instance
        {
            get
            {
                if (mInstance == null)
                {
                    lock (_sync)
                    {
                        if (mInstance == null)
                            mInstance = new DataService();
                    }
                }

                return mInstance;
            }
        }

        #endregion


        private Data mData;

        public static Data CurrentData
        {
            get
            {
                return Instance.mData;
            }
            set
            {
                Instance.mData = value;
            }
        }
    }
}
