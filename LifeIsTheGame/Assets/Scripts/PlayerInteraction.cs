using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private Camera playerCam;
    [SerializeField]LayerMask mask;
    [SerializeField] float distance = 2f;
    private InputManager manager;
    private WeaponEquipped weapon;
    public bool isEquiped;
    // Start is called before the first frame update
    void Start()
    {
        playerCam = GetComponent<PlayerVision>().cam_;
        manager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(playerCam.transform.position, playerCam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            IEquipabble equipable = hitInfo.collider.GetComponent<IEquipabble>();
            if (equipable != null)
            {
                if (manager.onFoot.Equip.triggered && !isEquiped)
                {
                    Debug.Log("buenas");
                    equipable.Equip();
                    isEquiped = true;
                    weapon = hitInfo.collider.GetComponent<WeaponEquipped>();
                }
            }
        }
        if (isEquiped && manager.onFoot.UnEquip.triggered)
        {
            weapon.UnEquip();
            isEquiped = false;
        }
        
    }
}
