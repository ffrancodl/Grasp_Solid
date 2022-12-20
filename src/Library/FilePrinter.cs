using System;
using System.Collections;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{

    public class FilePrinter : IPrinter
    {
        
        public void PrintBuilding(IStringConverter stringConverter)
        {
            File.WriteAllText("Building.txt", stringConverter.GetTextToPrint());
        }
    }
}