using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingDaggerWeapon : WeaponBase
{
    PlayerMove playerMove;

    [SerializeField] GameObject knifePrefab;

    private void Awake()
    {
        playerMove = GetComponentInParent<PlayerMove>();
    }

    public override void Attack()
    {
        GameObject thrownKnife = Instantiate(knifePrefab);
        thrownKnife.transform.position = transform.position;
        thrownKnife.GetComponent<ThrowingDaggerProjectile>().SetDirection(
            playerMove.lastHorizontalVector,
            0f
            );
    }
}
