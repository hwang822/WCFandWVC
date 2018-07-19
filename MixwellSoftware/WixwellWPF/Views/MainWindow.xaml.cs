using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MixwellWPF.ViewModels;
using MixwellWPF.Models;

namespace MixwellWPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            _console = new ConsoleOut();
            _textwindow = new TextWindow();
            
            DataContext = new CustomerViewModel();            
        }

        IShow _console;
        IShow _textwindow;


        private void colbutton_Click(object sender, RoutedEventArgs e)
        {

            
            Display obj = new Display(_textwindow);
            obj.show("Dependency Injection form textbox");

            Display obj1 = new Display(_console);
            obj1.show("Dependency Injection from console");

            //Resources["buttonBackground"] = Brushes.Yellow;   //Dynameic Resources binding
            //Resources["buttonBackground1"] = Brushes.Yellow;  //Static Resources binding
        }
    }

    public class ConsoleOut : IShow
    {
        public ConsoleOut() { }
        public void show(string text)
        {
            Console.WriteLine(text);
        }
    }

    public class TextWindow : IShow
    {
        public TextWindow() { }
        public void show(string text)
        {
            MessageBox.Show(text);
        }
    }

}
