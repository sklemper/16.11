using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    
        public class Dog : Animal, IWalking

        {

            public string Name

            { get; set; }
            public DateTime Birthday { get; }

            public override string ToString() => Name;

            public Dog(string name, DateTime birthday)

            {

                Name = name;

                Birthday = birthday;

            }

        }

    
}

