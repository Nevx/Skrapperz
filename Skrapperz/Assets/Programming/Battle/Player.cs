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
    //This function changes the target for the player's attack.
    public void Target(BasePart attackTarget)
    {
        target = attackTarget;
    }

    //Perform an attack with X damage, then your turn is over.
    public void PerformAttack(int attackNumber)
    {
        target.RecieveDamage(abilitie[attackNumber].damage);
        gameManager.AttackDone();

    }

    //Changes repair target.
    public void RepairPart(Player repairTarget)
    {
        targetSelf = repairTarget;

    }
    //Repairs 25 health to damaged part, then your turn is over.
    public void Repair()
    {
        targetSelf.RecieveHealth(25);
        gameManager.AttackDone();
    }


}
