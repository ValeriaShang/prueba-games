using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public class Worker : People
    {
        private float eatTime;
        private float workingTime;
        private float angryTime;

        public float EatTime { get => eatTime; protected set => eatTime = value; }
        public float WorkingTime { get => workingTime; protected set => workingTime = value; }
        public float AngryTime { get => angryTime; protected set => angryTime = value; }

        public void SetWorkerValues(string id,float eatTime, float workingTime, float angryTime)
        {
            Id = id;
            this.eatTime = eatTime;
            this.workingTime = workingTime;
            this.angryTime = angryTime;
        }     
    }
}
