using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Pratice
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hyundai = new Car();
            Hyundai.Name = "Elantra";
            var mower = new LawnMower();
            mower.Name = "Torque";
            var air = new Airplane();
            air.Name = "LastOne";

            Start(Hyundai);
            Start(mower);
            Start(air);
            Console.Read();
        }
        static void Start(IMachine Machine)
        {
            Machine.Start();
        }
    }


}
