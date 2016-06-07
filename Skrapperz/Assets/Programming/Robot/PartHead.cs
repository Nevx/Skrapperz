using UnityEngine;
using System.Collections;

public class PartHead : BasePart {

    [SerializeField]
    private int baseAccuracy;

    [SerializeField]
    public int baseCrit;

    [SerializeField]
    private Sprite headIcon;

    public RectTransform healthBar;

    void Start()
    {
        if (GetComponentInParent<Enemy>())
        {
            healthBar = GameObject.Find("Enemy_skeleton").transform.FindChild("head_button").FindChild("HeadHealth").GetComponent<RectTransform>();
        }
        else
        {
            healthBar = GameObject.Find("Player_skeleton").transform.FindChild("head_button").FindChild("HeadHealth").GetComponent<RectTransform>();
        }
    }


    void Update()
    {
        if (GetComponentInParent<Enemy>())
        {
            healthBar.sizeDelta = new Vector2(m_health * 1.4f, 40.0f);
        }
        else
        {
            healthBar.sizeDelta = new Vector2(m_health * 1.4f, 40.0f);
        }
    }
}
