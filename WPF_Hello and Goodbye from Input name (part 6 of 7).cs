using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Oct_22_Academy02
{
    internal interface IGreeter // ป่กติ interface จะมีแต่ method ไม่สามารถเก็บ field อื่นๆ ได้
    {


        string Greet(string name);
    }
}
