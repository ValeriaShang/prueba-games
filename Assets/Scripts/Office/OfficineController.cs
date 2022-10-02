using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Officine
{
    public class OfficineController : MonoBehaviour
    {
        public static OfficineController Instance { get; private set; }

        private List<Furniture> globalFurniture = new();
        private List<Machine> globalMachine = new();
        private List<People> globalPeople = new();
        private FinderElement finder;
        private Spawner spawner;

        public List<Furniture> GlobalFurniture { get => globalFurniture; private set => globalFurniture = value; }
        public List<Machine> GlobalMachine { get => globalMachine; private set => globalMachine = value; }
        public List<People> GlobalPeople { get => globalPeople; set => globalPeople = value; }
        public FinderElement Finder { get => finder; private set => finder = value; }

        private void Awake()
        {
            Instance = this;
            spawner = GetComponent<Spawner>();
            finder = GetComponent<FinderElement>();
        }

        private void Start()
        {
            spawner.InstanciateElements();
        }
    }
}