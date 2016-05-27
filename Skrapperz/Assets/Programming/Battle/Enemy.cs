using UnityEngine;
using System.Collections;

public class Enemy : BasePart
{

    [SerializeField]
    private Player[] playerParts;

    public void DoAttack()
    {
        //Enemy chooses a target randomly from the list of parts.
        target = playerParts[Random.Range(0, playerParts.Length)];
        target.RecieveDamage(abilitie[Random.Range(0, abilitie.Length)].damage);

    }

}
