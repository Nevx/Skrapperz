﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    enum turn {player, enemy}

    [SerializeField]
    turn currentTurn;

    bool attackDone = false;

    [SerializeField]
    Enemy enemy;

    [SerializeField]
    public UnityEngine.UI.Text textLog;

    void Update()
    {
        if (currentTurn == turn.player)
        {
            if (attackDone)
            {
                currentTurn = turn.enemy;
                attackDone = false;
            }
              
        }
        else
        {
            attackDone = false;
            currentTurn = turn.player;
            enemy.DoAttack();
            
        }

    }

    public void AttackDone()
    {
        attackDone = true;

    }
	
}
