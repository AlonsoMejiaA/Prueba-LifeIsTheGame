using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMiniAnim : MonoBehaviour
{
    Manager gameManager;
    [SerializeField]Animator myAnim_;
    private void Awake()
    {
        gameManager = FindObjectOfType<Manager>();
        switch (gameManager.valueToDance)
        {
            case 0:
                break;
            case 1:
                myAnim_.SetBool("House", true);
                break;
            case 2:
                myAnim_.SetBool("Macarena", true);
                break;
            case 3:
                myAnim_.SetBool("Hip Hop", true);
                break;
        }
    }
    
}
