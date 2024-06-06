using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace Week_9_Final_Exam_prep_notes
{
    public class Product
    {
        //obersvable collection of products
        public enum Categories { PetSupplies,Fragrance,Tech}
        string _name;
            string _manufacturer;
            string _description;
        double _price;
        string _filePath;
        int _dataListed;
        Categories _categories;
        BitmapImage _image;

        public string Name { get => _name; set => _name = value; }
        public string Manufacturer { get => _manufacturer; set => _manufacturer = value; }
        public string Description { get => _description; set => _description = value; }
        public double Price { get => _price; set => _price = value; }
        public string FilePath { get => _filePath; set => _filePath = value; }
        public int DataListed { get => _dataListed; set => _dataListed = value; }
        public Categories Categories1 { get => _categories; set => _categories = value; }
        public BitmapImage Image { get => _image; set => _image = value; }





        private BitmapImage GenerateBitmap(string filePath)
        {
            //Uniform Resource Identifier
            Uri convertFilePath = new Uri(filePath);


            BitmapImage bitmap = new BitmapImage(convertFilePath);





            return bitmap;
        }


        public FlowDocument FormattedProdcutPost()
        {
            FlowDocument fullDoc = new FlowDocument();

            fullDoc.Blocks.Add(Name_Formatted());

            return fullDoc;
        }


        private Paragraph Name_Formated()
        {
            Paragraph para = new Paragraph();
            Run run = new Run(_name);
            run.FontSize = 24;
            run.FontWeight = FontWeights.Bold;
            para.Inlines.Add(run);

            return run;
        }
            

        public Product(string name, string manufacturer, string description, string price, string filePath, int dataListed, Categories categories, BitmapImage image)
        {
            _name = name;
            _manufacturer = manufacturer;
            _description = description;
            _price = price;
            _filePath = filePath;
            _dataListed = dataListed;
            _categories = categories;
            _image = image;
        }
    }
}
