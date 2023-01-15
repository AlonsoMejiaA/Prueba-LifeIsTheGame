using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour,IDamageable
{
    [SerializeField] float Health;
    private AudioSource mySource;
    public void Start()
    {
        mySource = GetComponent<AudioSource>();
    }
    public void Hit(float damage)
    {
        Health -= damage;
        mySource.PlayOneShot(mySource.clip);
        if (Health <= 0)
        {
            this.gameObject.SetActive(false);
            
        }
    }
    public void Damage(float damage)
    {
        Hit(damage);
    }
}
