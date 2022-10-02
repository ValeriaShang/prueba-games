using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public class VendingMachine : Machine
    {
        public override bool CheckQueued(People people)
        {
            if (CurrentUser == null)
            {
                StartUsed(people);
                return false;
            }
            else if (UserQueued.Count < MaxUserOnQueued)
            {
                UserQueued.Add(people);
                PrintController.PrintMachine(people, this, GlobalVariables.QUEUED_MACHINE_MESSAGE);
                return false;
            }
            else
                return true;
        }

        public override void StartUsed(People people)
        {
            CurrentUser = people;
            StartCoroutine(Timer());
            PrintController.PrintMachine(people, this, GlobalVariables.START_USED_MACHINE_MESSAGE);
        }

        public override void FinishUsed()
        {
            PrintController.PrintMachine(CurrentUser, this, GlobalVariables.FINISH_USED_MACHINE_MESSAGE);
            CurrentUser.StateController.CurrentState.ChangeState();

            if (UserQueued.Count > 0)
            {
                StartUsed(UserQueued[0]);
                UserQueued.RemoveAt(0);
            }
            else
                CurrentUser = null;
        }

        public override IEnumerator Timer()
        {
            yield return new WaitForSeconds(UsedTime);
            FinishUsed();
        }
    }
}