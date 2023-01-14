using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEquipped : MonoBehaviour, IEquipabble
{
    [SerializeField] Transform placeToEquip_;
    private WeaponSystem me;
    private void Start()
    {
        me = GetComponent<WeaponSystem>();
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
        me.imEquiped = false;
        this.transform.parent = null;
    }
}
