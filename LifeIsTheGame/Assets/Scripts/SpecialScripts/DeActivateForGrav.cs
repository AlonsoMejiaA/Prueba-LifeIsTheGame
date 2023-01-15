using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeActivateForGrav : MonoBehaviour
{
    [SerializeField] Guns gun_;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Level") || other.CompareTag("Enemy") || other.CompareTag("Object"))
        {
            IDamageable damageable = other.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.Damage(gun_.Damage);
            }
            this.gameObject.SetActive(false);
            if (this.transform.parent != null)
            {
                this.transform.parent.gameObject.SetActive(false);
            }
        }

    }
}
