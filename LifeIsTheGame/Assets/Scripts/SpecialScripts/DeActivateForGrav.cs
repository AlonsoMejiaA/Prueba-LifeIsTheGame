using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeActivateForGrav : MonoBehaviour
{
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
}
