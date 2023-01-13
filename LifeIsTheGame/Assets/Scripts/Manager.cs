using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    GameObject me;
    public int valueToDance = 0;
    private void Awake()
    {
        me = this.gameObject;
        DontDestroyOnLoad(me);
    }
    public void SetValueForDance(int index) 
    {
        valueToDance = index;
    }

}
