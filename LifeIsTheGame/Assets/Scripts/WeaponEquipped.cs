using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEquipped : MonoBehaviour, IEquipabble
{
    [SerializeField] Transform placeToEquip_,placeToDrop;
    private WeaponSystem me;
    private AmmoCounter ammo;
    private void Start()
    {
        me = GetComponent<WeaponSystem>();
        ammo = GetComponent<AmmoCounter>();
    }

    public void Equip()
    {
        me.imEquiped = true;
        this.transform.SetParent(placeToEquip_);
        this.transform.position = placeToEquip_.position;
        this.transform.rotation = placeToEquip_.rotation;
    }

    public void UnEquip()
    {
        ammo.ClearText();
        me.imEquiped = false;
        this.transform.position = placeToDrop.position;
        this.transform.parent = null;
    }
}
