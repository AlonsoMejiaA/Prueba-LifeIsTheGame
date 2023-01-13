using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimOnClikc : MonoBehaviour
{
    [SerializeField] Animator charAnim_;

    public void ChangeState(string trigger)
    {
        charAnim_.SetTrigger(trigger);
        
    }
}
