using UnityEngine;
using System.Collections;

public static class DamageCalculation {
    
	public static int Calculate(PartArm weapon, PartHead head, BasePart target)
    {
        int damageDone = weapon.damage;
        int critMod = 0;
        int resistanceMod = 0;

        DamageType.e_damageType damage = weapon.damageType;
        DamageType.e_armorType armor = target.armor;

        int critVal = Random.Range(0, 100);
        if(critVal <= head.baseCrit + weapon.crit)
        {
            critMod = damageDone / 2;
        }

        if (DamageType.resistant(damage, armor) == 2)
        {
            resistanceMod = -damageDone / 2;
        }
        else if (DamageType.resistant(damage, armor) == 0)
        {
            resistanceMod = damageDone / 2;
        }


        return damageDone + critMod + resistanceMod;
    }
    
}
