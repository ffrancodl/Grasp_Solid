
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


namespace Full_GRASP_And_SOLID.Library
{
    public enum Destination
    {
        Console,
        File
    }


    public class AllInOnePrinter
    {
    
        public void PrintRecipe(Building building, Destination destination)
        {
            if (destination == Destination.Console) 
            {
                Console.WriteLine(building.PrintBuilding());
            }
            else
            {
                File.WriteAllText("Building.txt", building.PrintBuilding());
            }
        }

    }
}