using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_2
{
    internal class Body
    {
        string text;

        public string Text
        {
            get 
            { 
                return text; 
            }

            set 
            {
                text = value; 
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ForegroundColor= ConsoleColor.Green;
        }
    }
}
