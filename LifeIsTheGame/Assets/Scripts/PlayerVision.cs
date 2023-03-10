using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVision : MonoBehaviour
{
    public Camera cam_;
    public float xRotation = 0f;
    [SerializeField] float xSensitivity, ySensitivity;
    [SerializeField] Transform wPlace1, wPlace2, wPlace3;
   public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80, 80);
        cam_.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
        Cursor.visible = false;
    }
}
