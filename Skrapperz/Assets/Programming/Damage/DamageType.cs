using UnityEngine;
using System.Collections;

public static class DamageType {

	public enum e_damageType
    {
        bash,
        slash,
        pierce,
        fire,
        explosion,
        electric,
        ice
    }

    public enum e_armorType
    {
        carbon,
        steel,
        plasticium,
        elementalium
    }

    public static int resistant(e_damageType damage, e_armorType armor)
    {
        //return 0 for super effective, 1 for normal resistance, 2 for super risistant 
        int ret = 1;
        if(armor == e_armorType.carbon)
        {
            if(damage == e_damageType.bash || damage == e_damageType.explosion)
            {
                ret = 2;
            }
            else if(damage == e_damageType.pierce)
            {
                ret = 0;
            }
            else
            {
                ret = 1;
            }
            
        }

        if (armor == e_armorType.steel)
        {
            if (damage == e_damageType.pierce || damage == e_damageType.fire)
            {
                ret = 2;
            }
            else if (damage == e_damageType.slash)
            {
                ret = 0;
            }
            else
            {
                ret = 1;
            }

        }

        if (armor == e_armorType.plasticium)
        {
            if (damage == e_damageType.slash || damage == e_damageType.electric)
            {
                ret = 2;
            }
            else if (damage == e_damageType.bash)
            {
                ret = 0;
            }
            else
            {
                ret = 1;
            }

        }

        if (armor == e_armorType.elementalium)
        {
            if (damage == e_damageType.fire || damage == e_damageType.ice || damage == e_damageType.electric)
            {
                ret = 2;
            }
            else if (damage == e_damageType.explosion)
            {
                ret = 0;
            }
            else
            {
                ret = 1;
            }

        }


        return ret;
    }

}
