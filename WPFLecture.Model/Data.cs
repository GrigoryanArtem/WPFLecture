namespace WPFLecture.Model
{
    public class Data
    {
        #region Properties

        public int NumberA { get; set; }
        public int NumberB { get; set; }
        public string UselessProperty { get; set; }

        #endregion

        public Data() : this (0,0) { }

        public Data(int numberA, int numberB)
        {
            NumberA = numberA;
            NumberB = numberB;
        }
    }
}
