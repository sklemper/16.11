using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
 

        public interface ISwimming

        {

            public void Swim()

            {

                Console.WriteLine(this + " плывет в новую точку");

            }
        }
    
}

