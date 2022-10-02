using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public abstract class People : MonoBehaviour
    {
        private string id;
        private StateController stateController;

        public string Id { get => id; protected set => id = value; }
        public StateController StateController { get => stateController; set => stateController = value; }

        private void Awake()
        {
            stateController = GetComponent<StateController>();
        }
    }
}
