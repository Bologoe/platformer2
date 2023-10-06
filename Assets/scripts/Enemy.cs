using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    public int health;
    public int maxHealth;

    public override void GetDamage(int dmg)
    {
        health -= dmg;
        Debug.Log("enemy got damaged");
    }



}
