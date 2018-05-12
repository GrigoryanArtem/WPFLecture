using System.Windows.Controls;
using WPFLecture.ViewModels;

namespace WPFLecture.Views
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new MainPageViewModel();
        }
    }
}
