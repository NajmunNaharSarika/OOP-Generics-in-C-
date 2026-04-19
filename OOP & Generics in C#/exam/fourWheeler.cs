using exam.exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public class fourWheeler : vechicle,IintoriorDesign
    {
        List<string>Indesign = new List<string>();
        public fourWheeler()
        {
            
        }
        public fourWheeler(string model, int yearMake, int cc, int noofgear, vechicleType 
            vechicleType, int NoofDoor, int Noofseat) :base(model, yearMake, cc, noofgear, vechicleType)
        {
            this.NoofDoor = NoofDoor;
            this.Noofseat = Noofseat;
            
        }

        public int NoofDoor { get; set; }
        public int Noofseat { get; set; }

        public void addIintoriorDesign(params string[] design)
        {
            this.Indesign.AddRange(design);
        }

        public override string Details()
        {
            return $"{Model}, {CC}, {YearMake}, {Noofgear}, {NoofDoor}, {Noofseat}";
        }

        public string getIintoriorDesign()
        {
            return string.Join (", " , Indesign );
        }
    }
}
