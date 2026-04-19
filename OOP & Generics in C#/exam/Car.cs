using exam.exam;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public sealed class Car : fourWheeler
    {
        public Car() 
        {
        }
        public Car(string model, int yearMake, int cc, int noofgear, vechicleType
            vechicleType, int NoofDoor, int Noofseat):base(model, yearMake, cc, noofgear,
                vechicleType,NoofDoor,Noofseat)
        {
            
        }
    }
}
