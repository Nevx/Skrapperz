using UnityEngine;
using System.Collections;

public class PartTorso : BasePart {
    [SerializeField]
    private Sprite torsoIcon;

    public RectTransform healthBar;

    void Start()
    {
        if (GetComponentInParent<Enemy>())
        {
            healthBar = GameObject.Find("Enemy_skeleton").transform.FindChild("body_button").FindChild("BodyHealth").GetComponent<RectTransform>();
        }
        else
        {
            healthBar = GameObject.Find("Player_skeleton").transform.FindChild("body_button").FindChild("BodyHealth").GetComponent<RectTransform>();
        }
    }


    void Update()
    {
        if (GetComponentInParent<Enemy>())
        {
            healthBar.sizeDelta = new Vector2(m_health * 0.7f, 40.0f);
        }
        else
        {
            healthBar.sizeDelta = new Vector2(m_health * 0.7f, 40.0f);
        }
    }
}