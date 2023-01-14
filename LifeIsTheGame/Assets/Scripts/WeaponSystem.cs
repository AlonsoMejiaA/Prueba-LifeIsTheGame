using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    [SerializeField] Guns gun_;
    private InputManager manager;
    private PoolManager poolManager;
    [SerializeField] PlayerInteraction player_;
    [SerializeField] Transform placeToSpawnShot_;
    private int myMaxAmmo,myActualAmmo;
    public bool imEquiped;
    [SerializeField] string tagForPool;
    GameObject[] bullets;
    void Start()
    {
        bullets = new GameObject[gun_.maxAmmo];
        poolManager = FindObjectOfType<PoolManager>();
        manager = FindObjectOfType<InputManager>();
        myMaxAmmo = gun_.maxAmmo;
        myActualAmmo = gun_.actualAmmo;
        
    }

    void Update()
    {
        if (manager.onFoot.Shoot.triggered && player_.isEquiped && myActualAmmo > 0 && imEquiped)
        {
            Fire();
            myActualAmmo--;
        }
        if (manager.onFoot.Reload.triggered && imEquiped)
        {
            gun_.Reload();
            myActualAmmo = gun_.maxAmmo;
        }
    }
    private void Fire()
    {
        for (int i = 0; i < bullets.Length; i++)
        {
            if (bullets[i]== null)
            {
                GameObject bullet = poolManager.SpawnFromPool(tagForPool, placeToSpawnShot_.position);
                
                bullets[i] = bullet;
                return;
            }
            
        }
        for (int i = 0; i < bullets.Length; i++)
        {
            poolManager.ReleaseObject(tagForPool, bullets[i]);
            bullets[i] = null;
        }
    }
    
}
