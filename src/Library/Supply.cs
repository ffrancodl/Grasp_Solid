using System;
using System.Collections;
using System.IO;


namespace Full_GRASP_And_SOLID.Library
{
        public class Supply
    {
        public Supply (string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }
        public string Description { get; set; }

        public double UnitCost { get; set; }
    }
}