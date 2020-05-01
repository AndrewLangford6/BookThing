using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookThing
{
    public partial class Form1 : Form
    {


        List<Book> bookList = new List<Book>();


        public Form1()
        {
            InitializeComponent();

            List<string> bookList2 = File.ReadAllLines("BooksFile.txt").ToList();

            for (int i = 0; i < bookList.Count; i += 2)
            {
                string title2 = bookList2[i];
                int number = Convert.ToInt32(bookList[i+1]);


                Book hs = new Book(number,title2);
                bookList.Add(hs);
                // refBook.Add(score);
            }

            Boolean LinearSearch(List<string> searchList, String searchValue)
            {
                foreach (string s in searchList)
                {
                    if (s == searchValue)
                    {
                        return true;
                    }
                }
                return false;
            }


            Boolean BinarySearch(List<string> searchList, string searchValue)
            {
                int low = 0;
                int high = searchList.Count - 1;

                while (high >= low)
                {
                    int middle = (low + high) / 2;
                    int compare = searchList[middle].CompareTo(searchValue);

                    if (compare == 0)
                    {
                        return true;
                    }
                    else if (compare < 0)
                    {
                        low = middle + 1;
                    }
                    else
                    {
                        high = middle - 1;
                    }
                }
                return false;
            }

        }

    }
}
