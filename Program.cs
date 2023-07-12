using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace staticvariable
{
    internal class Program
    {
      static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 3);
            rectangle.CalculateArea();
            Console.WriteLine(rectangle.printdetail () );
            
            Circle circle = new Circle(5);
            circle.CalculateArea();
            Console.WriteLine(circle.printdetail());

            

        }












        }
        
    }

