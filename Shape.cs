using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticvariable
{
    public interface IPrintable
    {
        string printdetail();
    }
    abstract public class Shape
    {


        public abstract void CalculateArea();
    }













    public class Rectangle : Shape, IPrintable
    {
        private int l;
        private int s;
        private double area;

        public Rectangle(int l, int s)

        {
            this.l = l;
            this.s = s;

        }
        public override void CalculateArea()
        {
            area = s * l;
        }

        public string printdetail()
        {

            return $"area of rectangle is {area}";
        }

        public override string ToString()
        {
            return $"area of rectangle is {area}";
        }



    }

    public class Circle : Shape, IPrintable
    {
        private int r;
        private double area;

        public Circle(int r)
        {
            this.r = r;   
        }
        public override void CalculateArea()
        {
            area = 3.14 * r;
        }

        public string printdetail() 
        {
            return $"area of circle is {area}";
        }
        

        public override string ToString()
        {
            return  $"area of circle is {area }";

        }
        public class Emp:IPrintable
        {
            private int ID;
            private string NAME;

            public string printdetail()
            {
                return $"id is equalto {ID },name is {NAME }";
            }
        }
      
        

    }





}
        




