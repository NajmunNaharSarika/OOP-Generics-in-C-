using exam.exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace exam
{
    public class Program
    {
        static void Main(string[] args)
        {
            Motorcycl m = new Motorcycl("R1v", 2022, 3, 4, vechicleType.personal,
                "seff", 433, 33, 6, "air cool", "aa", "avs");
            m.addextoriorDedign("horn","led light");
            GenericDetailImpl<Motorcycl>gd=new GenericDetailImpl<Motorcycl>();
            Console.WriteLine(gd.getDetail<Motorcycl>(m));
            Console.WriteLine(m.getextoriorDedign());
            Console.WriteLine();

            Car c = new Car("bmw", 2022, 3, 4, vechicleType.personal,5,4
                );
            c.addIintoriorDesign("music", "led ");
            VechicleDetailImpl<Car> cd = new VechicleDetailImpl<Car>();
            Console.WriteLine(cd.GetDetail<Car>(c));
            Console.WriteLine(c.getIintoriorDesign());
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
