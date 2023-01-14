using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMoveForGrav : MonoBehaviour,IO
{
    [SerializeField] Guns gun_;
    [SerializeField] GameObject place_;
    [SerializeField] string weaponTag;
    [SerializeField] float horizontalSpeed;
    private float myExtraSpeedX, myExtraSpeedY, myExtraSpeedZ;
    public void OnObjectSpawned()
    {
        place_ = GameObject.FindGameObjectWithTag(weaponTag);
        myExtraSpeedX = gun_.extraSpeedX;
        myExtraSpeedY = gun_.extraSpeedY;
        myExtraSpeedZ = gun_.extraSpeedZ;
        Vector3 Force = new Vector3(myExtraSpeedX, myExtraSpeedY, myExtraSpeedZ);
        GetComponent<Rigidbody>().velocity = (place_.transform.forward * horizontalSpeed) + Force;
    }
}
