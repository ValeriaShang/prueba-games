using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Officine
{
    public static class ProductionController
    {
        private static readonly List<float> Production = new();

        public static void AddTimeProduction(float time)
        {
            Production.Add(time);
        }

        public static float GetAverageProduction()
        {
            return Production.Skip(Math.Max(0, Production.Count() - GlobalVariables.MAX_PRODUCTION_COUNTER)).Average();
        }
    }
}
