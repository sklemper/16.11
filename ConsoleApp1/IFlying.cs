using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{


        public interface IFlying

        {

            public void Fly()

            {

                Console.WriteLine(this + " летит в новую точку");

            }

        }

    

}

