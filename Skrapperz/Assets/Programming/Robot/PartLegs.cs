using UnityEngine;
using System.Collections;

public class PartLegs : BasePart {

    [SerializeField]
    private int dodge;

    [SerializeField]
    private int tackleAccuracy;

    [SerializeField]
    private int tackleDamage;

    [SerializeField]
    private Sprite legsIcon;

    public RectTransform healthBar;

    void Start()
    {
        if (GetComponentInParent<Enemy>())
        {
            healthBar = GameObject.Find("Enemy_skeleton").transform.FindChild("legs_button").FindChild("LegsHealth").GetComponent<RectTransform>();
        }
        else
        {
            healthBar = GameObject.Find("Player_skeleton").transform.FindChild("legs_button").FindChild("LegsHealth").GetComponent<RectTransform>();
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