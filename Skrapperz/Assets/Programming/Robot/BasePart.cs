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
    [Range(0, 100)]
    protected int m_health = 100;

    [SerializeField]
    private RectTransform healthbar;

    [SerializeField]
    public BasePart target;

    [SerializeField]
    public string partName;

    [SerializeField]
    public BasePart targetSelf;

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

        if (m_health > 100)
        {
            m_health = 100;
        }
    }

    public void RecieveDamage(int damage)
    {
        
        feedbackText.text = partName + " took " + damage + " dmg";


        
        m_health -= damage;
    }

    public void RecieveHealth(int hp)
    {
        feedbackText.text = partName + " repaired for " + hp + " hp";
        if (m_health < 100)
        {
            m_health += hp;
        }

    }

    [SerializeField]
    protected abilities[] abilitie;

}
