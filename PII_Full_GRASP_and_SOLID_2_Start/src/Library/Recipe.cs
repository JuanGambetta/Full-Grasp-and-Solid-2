//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        static double SumInsumos = 0;        
        static double SumEquipment = 0;
        static double Total = 0;
        public void GetProductionCost()
        {
            foreach (Step step in steps)
            {
                SumInsumos = SumInsumos + Convert.ToDouble(step.Input.Unicost);
                SumEquipment = SumEquipment + (Convert.ToDouble(step.Equipment.HourlyCost)* Convert.ToDouble(step.Time));
            }
            Total = SumInsumos + SumEquipment;
            Console.WriteLine($"el total es {Total}");
        }
    }
}