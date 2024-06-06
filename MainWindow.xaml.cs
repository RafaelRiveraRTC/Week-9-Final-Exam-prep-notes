using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week_9_Final_Exam_prep_notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }// MainWindow

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Open up a new button from th ebutton click
            //yuo have to create a new instance of the window
            // then do .Show() on it
            new New_Window()
        }
    }
}





