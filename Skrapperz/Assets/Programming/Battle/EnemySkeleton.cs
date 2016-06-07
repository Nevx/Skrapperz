using UnityEngine;
using System.Collections;

public class EnemySkeleton : MonoBehaviour {

    public RectTransform head;
    public RectTransform torso;
    public RectTransform arm1;
    public RectTransform arm2;
    public RectTransform legs;


    public RectTransform getHead()
    {
        return head;
    }


    // Use this for initialization
    void Awake () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
