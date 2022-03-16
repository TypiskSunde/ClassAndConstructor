using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndConstructor
{    
    class TextPrinter
    {
        public string Name;
        
        //Constructor
        public TextPrinter(string name)
        {
            Name = name;
          
           
        }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }

        public void PrintText()
        {
           
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Runde nr  {i+1}");
                }
                
          
           
        }

    }
    
}
