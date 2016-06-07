using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    protected Enemy enemy;
    protected BasePart target;
    protected PartArm activeWeapon;
    protected PartHead activeHead;
    public BaseRobot robot;

    protected PartArm[] weapons;
    [SerializeField]
    protected GameManager gameManager;

    public PartHead headInstance;
    public PartTorso torsoInstance;
    public PartArm armRightInstance;
    public PartArm armLeftInstance;
    public PartLegs legsInstance;


    [SerializeField]
    UnityEngine.UI.Text[] actionButtons;

    void Awake()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
        weapons = new PartArm[2];
        weapons[0] = robot.armRight; 
        weapons[1] = robot.armLeft;
        robot = GetComponentInParent<BaseRobot>();

        headInstance = Instantiate(robot.head);
        headInstance.transform.SetParent(gameObject.transform);
        armRightInstance = Instantiate(robot.armRight);
        armRightInstance.transform.SetParent(gameObject.transform);
        armLeftInstance = Instantiate(robot.armLeft);
        armLeftInstance.transform.SetParent(gameObject.transform);
        torsoInstance = Instantiate(robot.torso);
        torsoInstance.transform.SetParent(gameObject.transform);
        legsInstance = Instantiate(robot.legs);
        legsInstance.transform.SetParent(gameObject.transform);


        for (int i = 0; i < actionButtons.Length; i++)
        {
            actionButtons[i].text = weapons[i].gameObject.name;
        }
        activeHead = robot.head;
    }
    //This function changes the target for the player's attack.
    public void TargetHead()
    {
        target = enemy.headInstance;
        PerformAttack();
    }
    public void TargetTorso()
    {
        target = enemy.torsoInstance;
        PerformAttack();
    }
    public void TargetArmRight()
    {
        target = enemy.armRightInstance;
        PerformAttack();
    }
    public void TargetArmLeft()
    {
        target = enemy.armLeftInstance;
        PerformAttack();
    }
    public void TargetLegs()
    {
        target = enemy.legsInstance;
        PerformAttack();
    }

    //Perform an attack with X damage, then your turn is over.
    public void PerformAttack()
    {
        target.m_health -= DamageCalculation.Calculate(activeWeapon, activeHead, target);
        gameManager.AttackDone();
        gameManager.textLog.text = "";
        gameManager.textLog.text += "Enemy took:" + DamageCalculation.Calculate(activeWeapon, activeHead, target) + " damage to " + target + ". Enemy now have: " + target.m_health + " HP.";
        Debug.Log("Enemy took:" + DamageCalculation.Calculate(activeWeapon, activeHead, target) + " damage to " + target + ". Enemy now have: " + target.m_health);
    }

    /*
    //Changes repair target.
    public void RepairPart(Player repairTarget)
    {
        target = repairTarget;

    }
    //Repairs 25 health to damaged part, then your turn is over.
    public void Repair()
    {
        target.RecieveHealth(25);
        gameManager.AttackDone();
    }
    */

    public void WeaponRightButton()
    {
        activeWeapon = robot.armRight;
    }
    public void WeaponLeftButton()
    {
        activeWeapon = robot.armLeft;
    }

}
