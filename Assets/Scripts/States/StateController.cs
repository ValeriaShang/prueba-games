using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Officine
{
    public class StateController : MonoBehaviour
    {
        public State initialState;
        public float checkExitTimer = 1;
        public People people;

        private State currentState;
        private State lastState;

        public State CurrentState { get => currentState; private set => currentState = value; }
    
        void Awake()
        {
            currentState = initialState;
            lastState = currentState;
            currentState.enabled = true;
        }

        public void ChangeState(State newState)
        {
            lastState = currentState;
            currentState.enabled = false;
            currentState = newState;
            currentState.enabled = true;
        }

        public void ReturnLastState()
        {
            currentState.enabled = false;
            currentState = lastState;
            currentState.enabled = true;
        }
    }
}
