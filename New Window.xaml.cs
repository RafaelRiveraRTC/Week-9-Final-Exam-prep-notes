using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace Week_9_Final_Exam_prep_notes
{
    /// <summary>
    /// Interaction logic for New_Window.xaml
    /// </summary>
    public partial class New_Window : Window
    {
        public New_Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //File Picker
            //Open file Dialouge is the object
            //We Need to create a new instance of first
            OpenFileDialog filePicker = new OpenFileDialog();
            //Display is dro[ down |Filter by format
            filePicker.Filter = "Image (*png, *.jpeg, *.jpg)|*.png;*.jpeg*.jpg;";


            if (filePicker.ShowDialog() == true)
            {
                string filePath = filePicker.FileName;
                txtFilePath.Text = filePath;    
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }
    }
}




//controls
//Rich text box (Basic)
//Enum 
//Radio Buttons 
//Rich texxt box advance
//list view plus click event
//-noit doing date time picker
//Combo box
//Image File Picker
//Text
//Data Class
