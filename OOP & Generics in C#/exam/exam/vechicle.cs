using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.exam
{
    public abstract class vechicle
    {
        public vechicle()
         {   
            }
       public vechicle(string model, int yearMake, int cc, int noofgear, vechicleType vechicleType)
        { 
            Model = model;
            YearMake = yearMake;    
            CC = cc;    
            Noofgear = noofgear;
            VechicleType = vechicleType; 
        }
        public string Model { get; set; }
        public int YearMake { get; set; }
        public int CC { get; set; }
        public int Noofgear { get; set; }
        public vechicleType VechicleType { get; set;}

        public abstract string Details();

    }
}
