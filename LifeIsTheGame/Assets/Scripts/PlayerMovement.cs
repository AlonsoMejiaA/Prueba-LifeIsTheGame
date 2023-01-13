using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController myController;
    private Vector3 velocity;
    [SerializeField] float speed;
    [SerializeField] float jumpHeight = 3;
    private float gravity = -9.8f;
    private bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        myController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        grounded = myController.isGrounded;
    }
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        myController.Move(transform.TransformDirection(moveDirection)*speed *Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        myController.Move(velocity * Time.deltaTime);
        if (grounded && velocity.y <0f)
        {
            velocity.y = -2f;
        }

    }
    public void Jump()
    {
        if (grounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -3 * gravity);
        }
    }
}
