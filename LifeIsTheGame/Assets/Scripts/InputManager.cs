using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInputs;
    public PlayerInput.OnFootActions onFoot;
    private PlayerMovement theMotor;
    private PlayerVision vision;
    // Start is called before the first frame update
    private void Awake()
    {
        playerInputs = new PlayerInput();
        onFoot = playerInputs.OnFoot;
        theMotor = GetComponent<PlayerMovement>();
        vision = GetComponent<PlayerVision>();
        onFoot.Jump.performed += ctx => theMotor.Jump();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        theMotor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }
    private void LateUpdate()
    {
        vision.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }
    private void OnEnable()
    {
        onFoot.Enable();
    }
    private void OnDisable()
    {
        onFoot.Disable();
    }
}
