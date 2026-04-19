using exam.exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public class GenericDetailImpl <T> : IgenericDetail<T>
    {
        public string getDetail<T1>(T1 obj)
        {
            if (obj is vechicle)
            {
                vechicle v = obj as vechicle;
                return v.Details();
            }
            else
            {
               return "Not a vechicle";
            }
        }

        
    }
}
