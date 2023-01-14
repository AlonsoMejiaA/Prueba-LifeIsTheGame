using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEquipped : MonoBehaviour, IEquipabble
{
    [SerializeField] Transform placeToEquip_;
   
   public void Equip()
    {
        
        this.transform.SetParent(placeToEquip_);
        this.transform.position = placeToEquip_.position;
        this.transform.rotation = placeToEquip_.rotation;
    }

    public void UnEquip()
    {
        this.transform.parent = null;
    }
}
