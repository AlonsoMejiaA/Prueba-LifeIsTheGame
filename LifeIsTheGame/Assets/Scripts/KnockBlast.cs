using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBlast : MonoBehaviour
{
    [SerializeField] float xForce, yForce, zForce;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rigidbody>() && other.CompareTag("Object"))
        {
            other.attachedRigidbody.AddForce(new Vector3(xForce, yForce, zForce));
        }
    }
}
