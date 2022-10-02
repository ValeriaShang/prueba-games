using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public class FoodTable : Furniture
    {
        public override bool CheckInUsed()
        {
            return InUsed;
        }

        public override void StartUsed(People people)
        {
            CurrentUser = people;
            PrintController.PrintFurniture(CurrentUser, this, GlobalVariables.START_USED_FURNITURE_MESSAGE);
            InUsed = true;
        }

        public override void FinishUsed()
        {
            PrintController.PrintFurniture(CurrentUser, this, GlobalVariables.FINISH_USED_FURNITURE_MESSAGE);
            CurrentUser = null;
            InUsed = false;
        }
    }
}
