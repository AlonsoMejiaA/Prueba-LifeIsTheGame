using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBlast : MonoBehaviour
{
    [SerializeField] float exForce,exRad;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rigidbody>() && other.CompareTag("Object"))
        {
            other.attachedRigidbody.AddExplosionForce(exForce, transform.position, exRad);
        }
    }
}
