using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{

    public class ConsolePrinter : IPrinter
    {
        
        public void PrintBuilding(IStringConverter stringConverter)
        {
            Console.WriteLine(stringConverter.GetTextToPrint());
        }
        
    }

}