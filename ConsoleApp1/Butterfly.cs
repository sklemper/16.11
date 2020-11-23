using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     
   

        public class Butterfly : Animal, IFlying

        {

            public string Name

            { get; set; }

            public override string ToString() => Name;

            public Butterfly(string name, DateTime birthday)

            {

                Name = name;

                Birthday = birthday;

            }

        }

    
}

