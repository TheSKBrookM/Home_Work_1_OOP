using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_2
{
    internal class Title
    {
        string name;
        
        public string Name 
        {
            get
            { 
                return name;
            }

            set
            {
                name = value;
            } 
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
