using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    
    private Player player;
    private BaseRobot playerRobot;
    private BasePart[] playerParts;
    private BasePart target;
    [SerializeField]
    protected GameManager gameManager;

    public PartArm enemyWeapon;
    public PartHead enemyHead;

    public BaseRobot robot;

    public PartHead headInstance;
    public PartTorso torsoInstance;
    public PartArm armRightInstance;
    public PartArm armLeftInstance;
    public PartLegs legsInstance;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerRobot = player.robot;
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

        enemyWeapon = robot.armRight;
        enemyHead = robot.head;
    }

    public void DoAttack()
    {
        if(torsoInstance.m_health <= 0)
        {
            //Application.LoadLevel("NevxMain");
        }
        playerParts = new BasePart[5];
        playerParts[0] = player.headInstance;
        playerParts[1] = player.torsoInstance;
        playerParts[2] = player.armLeftInstance;
        playerParts[3] = player.armRightInstance;
        playerParts[4] = player.legsInstance;


        //Enemy chooses a target randomly from the list of parts.
        target = playerParts[Random.Range(0, playerParts.Length)];
        target.m_health -= DamageCalculation.Calculate(enemyWeapon, enemyHead, target);

        gameManager.textLog.text += "\n You took damage to " + target + ". You now have: " + target.m_health + " HP.";

        Debug.Log("You took damage to " + target + ". You now have: " + target.m_health);
        if(player.torsoInstance.m_health <= 0)
        {
            Debug.Log("Your robot explodeded");
            Application.Quit();
        }
    }

}
