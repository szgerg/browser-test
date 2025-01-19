using System.IO;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            browser.ObjectForScripting = new ScriptHandler();

            browser.Navigate(Path.GetFullPath(@"htmls\proba.html"));
        }
    }
}
