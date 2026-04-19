using exam.exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public sealed class Motorcycl : TwoWheeler
    {

        public Motorcycl() { }
        public Motorcycl(string Model, int YearMake, int CC, int Noofgear, vechicleType VechicleType,
            string StartingMethod, int MaximumPowerinBPH, int MaximumTorque, int Mileage, string Cooling,
            string FrontBrake, string RearBrake): base(Model, YearMake, CC, Noofgear, VechicleType,StartingMethod,MaximumPowerinBPH,
                MaximumTorque,Mileage,Cooling,FrontBrake,RearBrake)
        {
            
        }
    }
}
