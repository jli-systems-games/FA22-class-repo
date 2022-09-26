using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ekaterina
{

    public class PetManager : MonoBehaviour
    {
        public PetController pet;
        public NeedsController needsController;

        public static PetManager instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else Debug.LogWarning("More than one PetManager in the Scene");
        }

        public void Die()
        {
            Debug.Log("Dead");
        }
    }
}
