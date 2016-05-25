using UnityEngine;
using System.Collections;

public class Player : BaseUnit
{
    [SerializeField]
    UnityEngine.UI.Text[] actionButtons;

    void Awake()
    {
        for(int i = 0; i < actionButtons.Length; i++)
        {
            actionButtons[i].text = abilitie[i].attack_name;
        }

    }
    public void Target(BaseUnit attackTarget)
    {
        target = attackTarget;
    }

    public void PerformAttack(int attackNumber)
    {
        target.RecieveDamage(abilitie[attackNumber].damage);
        gameManager.AttackDone();

    }
  

}
