using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Officine
{
    public class Angry : State
    {

        private void OnEnable()
        {
            StartCoroutine(WaitAngry());
        }

        private IEnumerator WaitAngry()
        {          
            yield return new WaitForSeconds((StateController.people as Worker).AngryTime);
            ChangeState();
        }

        public override void ChangeState()
        {
            StateController.ReturnLastState();
        }
    }
}
