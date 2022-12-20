//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;


namespace Full_GRASP_And_SOLID.Library
{

    public class Building : IStringConverter
    {
        private ArrayList tasks = new ArrayList();

        public Building(string name)
        {
            this.Description = name;
        }

        public string Description { get; set; }

        public void AddTask(Supply material, double quantity, Tool equipment, int time)
        {
            Task task = new Task(material, quantity, equipment, time);
            this.tasks.Add(task);
        }
        
        public void RemoveTask(Task task)
        {
            this.tasks.Remove(task);
        }

        public string GetTextToPrint()
        {
            List<string> Buildings = new List<string>();
            Buildings.Add($"Edificio {this.Description}:");
            foreach (Task i in this.tasks)
            {
                Buildings.Add($"{i.Quantity} de '{i.Material.Description}' " +
                    $"usando '{i.Equipment.Description}' durante {i.Time}");
            }
            Buildings.Add($"Cuesta un total de: ${this.GetProductionCost()}");
            return String.Join("\n", Buildings.ToArray());
        }

        public double GetProductionCost()
        {
            if (tasks.Count == 0)
            {
                throw new EmptyException ("No se puede debido a que la lista está vacía");
            }
            double cost = 0;
            foreach (Task task in this.tasks)
            {
                cost += task.Quantity * task.Material.UnitCost;
                cost += task.Time * task.Equipment.HourlyCost;
            }
            return cost;
        }
        
    }
}