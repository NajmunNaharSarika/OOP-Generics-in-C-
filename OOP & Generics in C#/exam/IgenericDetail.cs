using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
public interface IgenericDetail <T>
    {
        string getDetail<T>(T obj);
    }
}
