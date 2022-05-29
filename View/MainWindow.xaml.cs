using Lab6.ViewModel;
using System.Windows;
namespace Lab6;
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyViewModel vm = new MyViewModel();
            DataContext = vm;
        }
    }