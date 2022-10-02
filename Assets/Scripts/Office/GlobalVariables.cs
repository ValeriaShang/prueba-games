using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public static class GlobalVariables
    {
        //Production 
        public const int MAX_PRODUCTION_COUNTER = 10;
        public static string PRODUCTION_MESSAGE = "La producción media actual es de un producto cada ";
        public static string PRODUCTION_MESSAGE_SECONDS = " segundos.";

        //Generic furniture message
        public static string START_USED_FURNITURE_MESSAGE = " está usando ";
        public static string FINISH_USED_FURNITURE_MESSAGE = " ha terminado de usar ";
        public static string FOOD_TABLE = "mesa de comida.";
        public static string WORKING_TABLE = "mesa de trabajo.";

        //Generic machine message
        public static string START_USED_MACHINE_MESSAGE = " esta esperando a ser servido por ";
        public static string FINISH_USED_MACHINE_MESSAGE = " ha sido servido por ";
        public static string QUEUED_MACHINE_MESSAGE = " esta esperando cola en ";
        public static string VENDING_MACHINE = "maquina de bebidas.";

        //Angry state
        public static string ANGRY_MESSAGE = " se enfada porque no encuentra libre una ";
        

        //Spawn count element
        public const int WORKER_COUNTS = 3;
        public const int FOOD_TABLE_COUNTS = 1;
        public const int WORKING_TABLE_COUNTS = 1;
        public const int VENDING_MACHINE_COUNTS = 2;



        public enum FurniteType
        {
            WorkingTable = 0,
            FoodTable = 1,
        }

        public enum MachineType
        {
            VendingMachine = 0,
        }
    }
}