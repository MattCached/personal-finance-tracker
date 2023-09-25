using System.Windows;
using Personal_Finance_Tracker.ViewModels;

namespace Personal_Finance_Tracker.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}