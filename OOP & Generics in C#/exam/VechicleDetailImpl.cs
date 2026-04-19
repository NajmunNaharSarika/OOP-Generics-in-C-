using exam.exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    public class VechicleDetailImpl<T> : IvechicleDetail<T>
    {
        public string GetDetail<T1>(T1 obj) where T1 : vechicle
        {
            return obj.Details();
        }
    }
}
