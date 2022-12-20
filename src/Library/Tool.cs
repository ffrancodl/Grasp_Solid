using System;
using System.Collections;
using System.IO;


namespace Full_GRASP_And_SOLID.Library
{
    
    public class Tool
    {
    
        public Tool (string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }


        public string Description { get; set; }

    
        public double HourlyCost { get; set; }
    }
}