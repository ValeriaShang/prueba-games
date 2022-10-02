using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Officine
{
    public class Spawner : MonoBehaviour
    {
        public Worker worker;
        public WorkingTable workingTable;
        public FoodTable foodTable;
        public VendingMachine vendingMachine;

        public void InstanciateElements()
        {
            for (int x = 0; x < GlobalVariables.FOOD_TABLE_COUNTS; x++)
            {
                OfficineController.Instance.GlobalFurniture.Add(Instantiate(foodTable));
                OfficineController.Instance.GlobalFurniture[OfficineController.Instance.GlobalFurniture.Count - 1].Id = $"mesa de COMIDA {x}.";
            }

            for (int x = 0; x < GlobalVariables.WORKING_TABLE_COUNTS; x++)
            {
                OfficineController.Instance.GlobalFurniture.Add(Instantiate(workingTable));
                OfficineController.Instance.GlobalFurniture[OfficineController.Instance.GlobalFurniture.Count - 1].Id = $"mesa de TRABAJO {x}.";
            }

            for (int x = 0; x < GlobalVariables.VENDING_MACHINE_COUNTS; x++)
            {
                OfficineController.Instance.GlobalMachine.Add(Instantiate(vendingMachine));
                OfficineController.Instance.GlobalMachine[OfficineController.Instance.GlobalMachine.Count - 1].Id = $"maquina de BEBIDAS {x}.";
            }

            for (int x = 0; x < GlobalVariables.WORKER_COUNTS; x++)
            {
                OfficineController.Instance.GlobalPeople.Add(Instantiate(worker));
                (OfficineController.Instance.GlobalPeople[OfficineController.Instance.GlobalPeople.Count - 1] as Worker).SetWorkerValues($"Trabajador {x}", Random.Range(5, 13), Random.Range(5, 10), Random.Range(3, 10));
                (OfficineController.Instance.GlobalPeople[OfficineController.Instance.GlobalPeople.Count - 1] as Worker).gameObject.SetActive(true);
            }
        }
    }
}
