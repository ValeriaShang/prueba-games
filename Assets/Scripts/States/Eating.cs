using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Officine
{
    public class Eating : State
    {
        public State working, angry;

        private Furniture currentFurniture = null;

        private void OnEnable()
        {
            currentFurniture = OfficineController.Instance.Finder.FindFurniture(GlobalVariables.FurniteType.FoodTable, StateController.people);

            if (!currentFurniture)
                ChangeState();
            else
            {
                StartCoroutine(WaitEating());
            }
        }

        public override void ChangeState()
        {
            if (!currentFurniture)
            {
                PrintController.PrintAngryState(StateController.people, GlobalVariables.ANGRY_MESSAGE, GlobalVariables.FOOD_TABLE);
                StateController.ChangeState(angry);
            }             
            else
            {
                currentFurniture = null;
                StateController.ChangeState(working);
            }
        }

        public IEnumerator WaitEating()
        {
            yield return new WaitForSeconds((StateController.people as Worker).EatTime);
            currentFurniture.FinishUsed();
            ChangeState();
            currentFurniture = null;
        }
    }
}
