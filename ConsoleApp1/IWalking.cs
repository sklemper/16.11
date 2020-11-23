using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
  
public interface IWalking

        {

            public void Walk()

            {

                Console.WriteLine(this + " идет в новую точку");

            }

        }
    
}
