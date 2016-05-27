using UnityEngine;
using System.Collections;

public class PartHead : BasePart {

    [SerializeField]
    private int baseAccuracy;

    [SerializeField]
    public int baseCrit
    {
        get
        {
            return baseCrit;
        }
    }

    [SerializeField]
    private Sprite headIcon;
}
