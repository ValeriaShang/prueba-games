using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public abstract class Furniture : MonoBehaviour
    {
        private string id;
        private bool inUsed = false;
        private People currentUser;

        protected bool InUsed { get => inUsed; set => inUsed = value; }
        public string Id { get => id;  set => id = value; }
        public People CurrentUser { get => currentUser; set => currentUser = value; }

        public abstract bool CheckInUsed();

        public abstract void StartUsed(People worker);

        public abstract void FinishUsed();
    }
}