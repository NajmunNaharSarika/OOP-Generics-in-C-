using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.exam
{
    
    public class TwoWheeler : vechicle, IextoriorDedign
    {
        private List<string> exdesign = new List<string>();
        public TwoWheeler() { }

        public TwoWheeler(string Model, int YearMake, int cc, int Noofgear, vechicleType VechicleType,
            string StartingMethod, int MaximumPowerinBPH, int MaximumTorque, int Mileage, string Cooling,
            string FrontBrake, string RearBrake):base (Model,YearMake,cc,Noofgear,VechicleType)
        { 
            this.StartingMethod = StartingMethod;
            this. MaximumPowerinBPH = MaximumPowerinBPH;
            this.MaximumTorque = MaximumTorque;
            this.Mileage = Mileage;
            this.Cooling = Cooling;
            this.FrontBrake = FrontBrake;
            this.RearBrake = RearBrake;
        
        }
        string StartingMethod { get; set; }
        int MaximumPowerinBPH { get; set; }
        int MaximumTorque { get; set; }
        int Mileage {  get; set; }
        string Cooling { get; set; }
        string FrontBrake { get; set; }
        string RearBrake { get; set; }
       

        public void addextoriorDedign(params string[] design)
        {
            this.exdesign.AddRange(design);
        }

        public override string Details()
        {
            return $"{Model} {YearMake}, {CC}, {Noofgear},{VechicleType}" +
            $"{StartingMethod}, {MaximumPowerinBPH}, {MaximumTorque}, {Mileage},{Cooling}"+
            $"{FrontBrake},{RearBrake}";
        }

        public string getextoriorDedign()
        {
            return string.Join (", " ,exdesign);
        }
    }
}
