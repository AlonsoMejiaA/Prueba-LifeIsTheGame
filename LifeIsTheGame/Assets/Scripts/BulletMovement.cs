using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour,IO
{
    [SerializeField] Guns gun_;
    [SerializeField] GameObject place_;
    [SerializeField] string weaponTag;
    [SerializeField] float horizontalSpeed;
    private float myExtraSpeedX,myExtraSpeedY,myExtraSpeedZ;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Level") || other.CompareTag("Enemy") || other.CompareTag("Object"))
        {
            this.gameObject.SetActive(false);
            if (this.transform.parent != null)
            {
                this.transform.parent.gameObject.SetActive(false);
            }
        }
        
    }

    public void OnObjectSpawned()
    {
        place_ = GameObject.FindGameObjectWithTag(weaponTag);
        myExtraSpeedX = gun_.extraSpeedX;
        myExtraSpeedY = gun_.extraSpeedY;
        myExtraSpeedZ = gun_.extraSpeedZ;
        Vector3 Force = new Vector3(myExtraSpeedX, myExtraSpeedY, myExtraSpeedZ);
        GetComponent<Rigidbody>().velocity = (place_.transform.forward*horizontalSpeed) + Force;
    }
}
