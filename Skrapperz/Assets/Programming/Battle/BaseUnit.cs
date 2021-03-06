﻿using UnityEngine;
using System.Collections;

public class BaseUnit : MonoBehaviour
{
    [SerializeField]
    [Range(0,100)]
    protected int m_health = 100;

    [SerializeField]
    private RectTransform healthbar;

    [SerializeField]
    public BaseUnit target;

    [SerializeField]
    protected GameManager gameManager;

    [System.Serializable]
    public class abilities
    {
        public string attack_name;
        public int damage;
    }

    [SerializeField]
    UnityEngine.UI.Text feedbackText;


    void Update()
    {
        healthbar.sizeDelta = new Vector2(m_health * 0.4f, 40f);
    }

    public void RecieveDamage(int damage)
    {
        //feedbackText.text += "\n The target took " + damage + " dmg";

        m_health -= damage;

    }

    [SerializeField]
    protected abilities[] abilitie;
	
}
