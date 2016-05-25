using UnityEngine;
using System.Collections;

public class BasePart : MonoBehaviour {
	[SerializeField]
    protected int m_health;

    [SerializeField]
    protected DamageType.e_armorType Armor;

    [SerializeField]
    protected int power;

}
