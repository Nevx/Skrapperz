using UnityEngine;
using System.Collections;

public class BasePart : MonoBehaviour {

    [SerializeField]
    public DamageType.e_armorType armor;

    [SerializeField]
    protected int power;

    [SerializeField]
    protected string flavourText;

    [SerializeField]
    public int m_maxHealth;

    [SerializeField]
    public int m_health;

    //[SerializeField]
    //private RectTransform healthbar;
    
}
