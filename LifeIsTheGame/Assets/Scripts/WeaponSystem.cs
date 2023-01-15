using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    [SerializeField] Guns gun_;
    private AudioSource mySource;
    private InputManager manager;
    private PoolManager poolManager;
    [SerializeField] PlayerInteraction player_;
    [SerializeField] Transform placeToSpawnShot_;
    public int myMaxAmmo,myActualAmmo;
    public bool imEquiped;
    [SerializeField] string tagForPool;
    private AmmoCounter ammoCounter;
    GameObject[] bullets;
    void Start()
    {
        mySource = GetComponent<AudioSource>();
        bullets = new GameObject[gun_.maxAmmo];
        poolManager = FindObjectOfType<PoolManager>();
        manager = FindObjectOfType<InputManager>();
        myMaxAmmo = gun_.maxAmmo;
        myActualAmmo = gun_.actualAmmo;
        ammoCounter = GetComponent<AmmoCounter>();
    }

    void Update()
    {
        if (manager.onFoot.Shoot.triggered && player_.isEquiped && myActualAmmo > 0 && imEquiped)
        {
            Fire();
            myActualAmmo--;
            ammoCounter.UpdateText();
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
                mySource.PlayOneShot(mySource.clip);
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
