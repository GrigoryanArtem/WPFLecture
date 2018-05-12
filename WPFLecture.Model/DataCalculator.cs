namespace WPFLecture.Model
{
    public class DataCalculator : IDataCalculator
    {
        public int Sum(Data data)
        {
            return data.NumberA + data.NumberB;
        }

        public double Divide(Data data)
        {
            return (double)data.NumberA / data.NumberB;
        }
    }
}
