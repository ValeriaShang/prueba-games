using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public class Waiting : State
    {
        public State eating, angry;

        private Machine currentMachine = null;

        private void OnEnable()
        {
            currentMachine = OfficineController.Instance.Finder.FindMachine(GlobalVariables.MachineType.VendingMachine, StateController.people);
            if (!currentMachine)
                ChangeState();
        }

        public override void ChangeState()
        {
            if (!currentMachine)
            {
                PrintController.PrintAngryState(StateController.people, GlobalVariables.ANGRY_MESSAGE, GlobalVariables.VENDING_MACHINE);
                StateController.ChangeState(angry);
            }             
            else
            {
                StateController.ChangeState(eating);
                currentMachine = null;
            }
        }
    }
}
