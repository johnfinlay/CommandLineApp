using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppDotNet47
{
    public class SportsCar : Car
    {
        public string GetPetName()
        {
            PetName = "Fred";
            return PetName;
        }
    }
}