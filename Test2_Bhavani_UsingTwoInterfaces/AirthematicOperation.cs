using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Bhavani_UsingTwoInterfaces
{
    public class AirthematicOperation : Interface2, Interface1
    {
        public int Number1 { get; set ; }
        public int Number2 { get; set; }

        public void Add()
        {
            Number1 = 5;
            Number2 = 7;
             int number3 = Number1 + Number2;
            Console.WriteLine("The sum of two numbers is :" + number3);
            Console.ReadLine();
        }
    }
}
