using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_2
{
    internal class Book
    {
        Title titleName;
        Body text;
        Author name; 

        public Book(Title titelName, Body text, Author authorName)
        {
            this.titleName = titelName;
            this.text = text;
            this.name = authorName;
        }

        public void Show()
        { 
            this.titleName.Show();
            this.text.Show();
            this.name.Show();
        }
    }
}
