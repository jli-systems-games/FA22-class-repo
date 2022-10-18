using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mariana
{
  
    public class PlayerAttack : MonoBehaviour
    {
        private GameObject AttackArea = default;

        private bool attacking = false;

        private float timeToAttack = 0.25f;
        private float timer = 0f;


        // Start is called before the first frame update
        void Start()
        {
            AttackArea = transform.GetChild(0).gameObject;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
            }

            if (attacking)
            {
                //timer += Time.deltaTime;
                if(timer >= timeToAttack)
                {
                    timer = 0;
                    attacking = false;
                    AttackArea.SetActive(attacking);
                }
            }

        }

        private void Attack()
        {
            attacking = true;
            AttackArea.SetActive(attacking);
        }
    }
}