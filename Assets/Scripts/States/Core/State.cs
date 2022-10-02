using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public abstract class State : MonoBehaviour
    {
        private StateController stateController;

        public StateController StateController { get => stateController; set => stateController = value; }

        private void Awake()
        {
            stateController = GetComponent<StateController>();
        }

        public abstract void ChangeState();
    }
}
