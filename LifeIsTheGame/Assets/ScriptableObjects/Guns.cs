using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun")]
public class Guns : ScriptableObject
{
    public int maxAmmo;
    public GameObject ammoType;
    public float xSpeed,ySpeed;
    public int actualAmmo;
    public void Reload()
    {
        actualAmmo = maxAmmo;
    }
}
