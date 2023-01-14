using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtractThings : MonoBehaviour
{
    [SerializeField] float atractSpeed;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            other.transform.position = Vector3.MoveTowards(other.transform.position, transform.position, atractSpeed * Time.deltaTime);  
        }
    }
   
}
