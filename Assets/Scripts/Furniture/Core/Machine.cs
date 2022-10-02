using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Officine
{
    public abstract class Machine : MonoBehaviour
    {
        private string id;
        private People currentUser;
        private int maxUserOnQueued = 1;
        private List<People> userQueued = new();
        private float usedTime = 5;

        public string Id { get => id; set => id = value; }
        public int MaxUserOnQueued { get => maxUserOnQueued; set => maxUserOnQueued = value; }
        public float UsedTime { get => usedTime; set => usedTime = value; }
        public People CurrentUser { get => currentUser; set => currentUser = value; }
        public List<People> UserQueued { get => userQueued; set => userQueued = value; }

        public abstract bool CheckQueued(People people);

        public abstract void StartUsed(People people);

        public abstract void FinishUsed();

        public abstract IEnumerator Timer();
    }
}