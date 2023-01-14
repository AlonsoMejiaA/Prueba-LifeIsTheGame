using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class Guns : ScriptableObject
{
    public int maxAmmo;

    public float extraSpeedX,extraSpeedY,extraSpeedZ;
    public int actualAmmo;
    public void Reload()
    {
        actualAmmo = maxAmmo;
    }
}
