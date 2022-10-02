using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public class WorkingTable : Furniture
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
            ProductionController.AddTimeProduction((CurrentUser as Worker).WorkingTime);
            PrintController.PrintFurniture(CurrentUser, this, GlobalVariables.FINISH_USED_FURNITURE_MESSAGE);
            PrintController.PrintAverageProduction();
            CurrentUser = null;
            InUsed = false;
        }
    }
}
