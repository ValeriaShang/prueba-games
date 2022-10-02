using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public class Working : State
    {
        public State waiting, angry;

        private Furniture currentFurniture = null;


        private void OnEnable()
        {
            currentFurniture = OfficineController.Instance.Finder.FindFurniture(GlobalVariables.FurniteType.WorkingTable, StateController.people);

            if (!currentFurniture)
                ChangeState();
            else
            {
                StartCoroutine(WaitWorking());
            }
        }

        public override void ChangeState()
        {
            if (!currentFurniture)
            {
                PrintController.PrintAngryState(StateController.people, GlobalVariables.ANGRY_MESSAGE, GlobalVariables.WORKING_TABLE);
                StateController.ChangeState(angry);
            }
            else
            {
                currentFurniture = null;
                StateController.ChangeState(waiting);
            }
        }

        public IEnumerator WaitWorking()
        {
            yield return new WaitForSeconds((StateController.people as Worker).WorkingTime);
            currentFurniture.FinishUsed();
            ChangeState();
            currentFurniture = null;
        }
    }
}
