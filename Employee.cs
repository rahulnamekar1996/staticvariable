using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace staticvariable
{
    public class Employee
    {
        private int id;
        private string name;
        private double  bs;
        private double hra;
        private double da;
        private double ta;
        private double pf;
        private double gs;
        private static int count;


        public Employee (string name,double bs)
        {
            count++;
            this.id = count;
            this.bs  = bs;
            
            this.name = name;
        }
        public static int   Getcount()
        {
            return  count;
        }
        
        
            
        
        public void CalculateSalary()
        {
            hra = bs * 0.40;
            ta = bs * 0.20;
            da = bs * 015;
            pf = bs * 0.12;
            bs = (hra + ta + da + pf);
            gs = (hra + ta + da) - pf;
        }

        public string PrintSallary()
        {
         
            return $"name is equal to{name}salaary is eual to{bs} and gross salary is equal to{gs}id is equal to{id}";

        }
         
        
           
       



    }
    
    
    
         

          
} 
          
    

