using UnityEngine;
using System.Collections;

public class PartArm : BasePart {

    [SerializeField]
    private DamageType.e_damageType damageType;

    [SerializeField]
    private int damage;

    [SerializeField]
    private int accuracy;

    [SerializeField]
    private int cooldown;

    [SerializeField]
    private int crit;

    [SerializeField]
    private Sprite weaponIcon;
}
