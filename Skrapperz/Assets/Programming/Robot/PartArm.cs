using UnityEngine;
using System.Collections;

public class PartArm : BasePart {

    [SerializeField]
    public DamageType.e_damageType damageType;

    [SerializeField]
    public int  damage;

    [SerializeField]
    public int accuracy;

    [SerializeField]
    public int cooldown;

    [SerializeField]
    public int crit;
    
    [SerializeField]
    private Sprite weaponIcon;
}
