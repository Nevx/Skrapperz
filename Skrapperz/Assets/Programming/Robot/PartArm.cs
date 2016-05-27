using UnityEngine;
using System.Collections;

public class PartArm : BasePart {

    [SerializeField]
    public DamageType.e_damageType damageType
    {
        get
        {
            return damageType;
        }
    }

    [SerializeField]
    public int damage
    {
        get
        {
            return damage;
        }
    }

    [SerializeField]
    public int accuracy
    {
        get
        {
            return accuracy;
        }
    }

    [SerializeField]
    public int cooldown
    {
        get
        {
            return cooldown;
        }
    }

    [SerializeField]
    public int crit
    {
        get
        {
            return crit;
        }
    }

    [SerializeField]
    private Sprite weaponIcon;
}
