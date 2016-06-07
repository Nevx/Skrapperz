using UnityEngine;
using System.Collections;

public class HeadHealth : MonoBehaviour {

    public RectTransform healthBar;

	// Use this for initialization
	void Awake () {
        healthBar = GetComponentInParent<RectTransform>();
	}

    public RectTransform getHealthBar()
    {
        return (healthBar);
    }

	
	// Update is called once per frame
	void Update () {
	
	}
}
