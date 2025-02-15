
using System.Windows;
using Todo_UserControls.MVVM.ViewModel;


namespace Todo_UserControls
{
    
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel mainWindowViewModel)
        {
            DataContext = mainWindowViewModel;
            InitializeComponent();
        }
    }
}