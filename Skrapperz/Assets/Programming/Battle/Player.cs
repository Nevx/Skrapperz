using UnityEngine;
using System.Collections;

public class Player : BasePart
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
    public void Target(BasePart attackTarget)
    {
        target = attackTarget;
    }

    public void PerformAttack(int attackNumber)
    {
        target.RecieveDamage(abilitie[attackNumber].damage);
        gameManager.AttackDone();

    }

    public void RepairPart(Player repairTarget)
    {
        targetSelf = repairTarget;

    }
    public void Repair()
    {
        targetSelf.RecieveHealth(25);
        gameManager.AttackDone();
    }


}
