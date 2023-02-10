using Avalonia.Controls;
using Avalonia.Interactivity;
using ColoredRectangle.ViewModels;

namespace ColoredRectangle.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
