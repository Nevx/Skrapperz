using UnityEngine;
using System.Collections;

public class Enemy : BaseUnit
{

    public void DoAttack()
    {
        target.RecieveDamage(abilitie[Random.Range(0, abilitie.Length)].damage);

    }

}
