using System;
using System.Collections;
using System.Collections.Generic;


namespace Full_GRASP_And_SOLID.Library
{
    

    public class ConsolePrinter : IPrinter
    {
        public void PrintBuilding(Building building)
        {
            Console.WriteLine(building.PrintBuilding());
        }
        
    }
}