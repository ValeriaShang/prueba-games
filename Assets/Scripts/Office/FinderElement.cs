using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public class FinderElement : MonoBehaviour
    {
        public Furniture FindFurniture(GlobalVariables.FurniteType type, People people)
        {
            switch (type)
            {
                case GlobalVariables.FurniteType.WorkingTable:
                    foreach (Furniture element in OfficineController.Instance.GlobalFurniture)
                    {
                        if (element.GetType() == typeof(WorkingTable))
                        {
                            if (!element.CheckInUsed())
                            {
                                element.StartUsed(people);
                                return element;
                            }
                        }
                    }
                    return null;
                case GlobalVariables.FurniteType.FoodTable:
                    foreach (Furniture element in OfficineController.Instance.GlobalFurniture)
                    {
                        if (element.GetType() == typeof(FoodTable))
                        {
                            if (!element.CheckInUsed())
                            {
                                element.StartUsed(people);
                                return element;
                            }
                        }
                    }
                    return null;
            }
            return null;
        }


        public Machine FindMachine(GlobalVariables.MachineType type, People people)
        {
            switch (type)
            {
                case GlobalVariables.MachineType.VendingMachine:

                    foreach (Machine element in OfficineController.Instance.GlobalMachine)
                    {
                        if (element.GetType() == typeof(VendingMachine))
                        {
                            if (!(element as VendingMachine).CheckQueued(people))
                            {
                                return element;
                            }
                        }
                    }
                    return null;
            }
            return null;
        }
    }
}

