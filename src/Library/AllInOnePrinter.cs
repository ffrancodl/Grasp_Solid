
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// esta clase imprime en consola y en archivos
/// </summary>

namespace Full_GRASP_And_SOLID.Library
{
    public enum Destination
    {
        Console,
        File
    }


    public class AllInOnePrinter
    {
    
        public void PrintBuilding(Building building, Destination destination)
        {
            if (destination == Destination.Console) 
            {
                Console.WriteLine(building.GetTextToPrint());
            }
            else
            {
                File.WriteAllText("Building.txt", building.GetTextToPrint());
            }
        }

    }
}