using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9_Final_Exam_prep_notes
{
    internal class Data
    {
        //Observable colelctio of Products
        static ObservableCollection<Product> _amazonProdcuts;

        //Static constuctor
        static Data()
        {
            _amazonProdcuts = new ObservableCollection<Product>();
        }

        public static ObservableCollection<Product> AmazonProdcuts { get => 
                _amazonProdcuts; }

        //Method

        static void AddProduct(Product product)
        {
            _amazonProdcuts.Add(product);


            Product newProduct = new Product("Sheeba",25);
        }
    }
}
