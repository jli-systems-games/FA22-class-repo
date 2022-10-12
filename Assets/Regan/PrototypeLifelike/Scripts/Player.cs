using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ReganLifeLike
{
    public class Player : MonoBehaviour
    {
        public int health = 100;

        public int fleshAmount = 0;

        public void Damage(int amount)
        {

        }

        public void CollectFlesh(int amount)
        {
            fleshAmount += amount;
        }
    }
}