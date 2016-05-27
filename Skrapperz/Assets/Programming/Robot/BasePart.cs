using UnityEngine;
using System.Collections;

public class BasePart : MonoBehaviour {

    [SerializeField]
    protected DamageType.e_armorType Armor;

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
