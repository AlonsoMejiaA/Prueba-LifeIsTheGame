using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    public GameObject backgroundCube;
    
    private Renderer cubeRenderer;
    private void Start()
    {
        cubeRenderer = backgroundCube.GetComponent<Renderer>(); 
    }
    public void ChangeBG(Texture sprite)
    {
        cubeRenderer.material.mainTexture = sprite;
    }
}
