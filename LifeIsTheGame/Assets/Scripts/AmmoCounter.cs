using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    [SerializeField] Text ammoCounter,explain;
    [SerializeField]WeaponSystem weapon;
    public int AAmmo, MAmmo;
    private void Start()
    {
        weapon = GetComponent<WeaponSystem>();
       
    }

    public void UpdateText()
    {
        MAmmo = weapon.myMaxAmmo;
        AAmmo = weapon.myActualAmmo;
        ammoCounter.text = AAmmo.ToString() + " / " + MAmmo.ToString();
        explain.text = "Press 'T' to unequip weapon";
    }
    public void ClearText()
    {
        ammoCounter.text = "- / -";
        explain.text = string.Empty;
    }
}
