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

    public RectTransform healthBar;

    void Start()
    {
        if (GetComponentInParent<Enemy>())
        {
            healthBar = GameObject.Find("Enemy_skeleton").transform.FindChild("arm2_button").FindChild("Arm2Health").GetComponent<RectTransform>();
        }
        else
        {
            healthBar = GameObject.Find("Player_skeleton").transform.FindChild("arm2_button").FindChild("Arm2Health").GetComponent<RectTransform>();
        }
    }


    void Update()
    {
        if (GetComponentInParent<Enemy>())
        {
            healthBar.sizeDelta = new Vector2(m_health * 1.1f, 40.0f);
        }
        else
        {
            healthBar.sizeDelta = new Vector2(m_health * 1.1f, 40.0f);
        }
    }
}
