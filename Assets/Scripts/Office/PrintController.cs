using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public static class PrintController
    {
        public static void PrintAverageProduction()
        {
            Debug.Log(GlobalVariables.PRODUCTION_MESSAGE + ProductionController.GetAverageProduction() + GlobalVariables.PRODUCTION_MESSAGE_SECONDS);
        }

        public static void PrintFurniture(People people, Furniture furniture, string message)
        {
            Debug.Log(people.Id + message + furniture.Id);
        }

        public static void PrintMachine(People people, Machine machine, string message)
        {
            Debug.Log(people.Id + message + machine.Id);
        }

        public static void PrintAngryState(People people, string message, string type)
        {
            Debug.Log(people.Id + message + type);
        }
    }
}