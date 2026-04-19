using exam.exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
   public interface IvechicleDetail <T>
    {
        string GetDetail<T>(T obj) where T : vechicle;
    }
}
