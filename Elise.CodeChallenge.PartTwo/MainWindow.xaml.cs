using Elise.CodeChallenge.PartTwo.ViewModel;
using System.Windows;

namespace Elise.CodeChallenge.PartTwo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            StudentViewModel studentViewModelObject = new StudentViewModel();

            studentViewModelObject.LoadStudents();
            StudentViewControl.DataContext = studentViewModelObject;
        }
    }
}
