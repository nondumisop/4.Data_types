using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaration
            string name = "Nondumiso";
            int age =23;
            bool isTall =false;
            double weight =110;

            /*for the smalleat least precise decimal use float,
             * for more precise use decimal eg for money,
             * in most cases double will do just fine
             * */

            Console.WriteLine(name + "is" + age + " she weighs" + weight);
            Console.WriteLine("it is" + isTall + "that he is tall");

            //freeze console 
            Console.ReadLine();


        }
    }
}
