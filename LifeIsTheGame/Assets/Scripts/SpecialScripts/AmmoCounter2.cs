using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter2 : MonoBehaviour
{
    [SerializeField] Text ammoCounter;
    [SerializeField] WeaponSystem weapon;
    private PlayerInteraction aux;
    public int AAmmo, MAmmo;
    private void Start()
    {
        weapon = GetComponent<WeaponSystem>();
        aux = FindObjectOfType<PlayerInteraction>();
    }

    public void Update()
    {
        if (aux.isEquiped)
        {
            UpdateText();
        }
        if (!aux.isEquiped)
        {
            ClearText();
        }
    }

    public void UpdateText()
    {
        MAmmo = weapon.myMaxAmmo;
        AAmmo = weapon.myActualAmmo;
        ammoCounter.text = AAmmo.ToString() + " / " + MAmmo.ToString();
    }
    public void ClearText()
    {
        ammoCounter.text = "- / -";
    }
}
