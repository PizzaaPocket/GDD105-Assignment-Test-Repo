using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerControl : MonoBehaviour
{

    private Rigidbody rb;
    private float movementX, movementY;
    public float speed;
    private float velocity;
    public float velocityspeed = 2.0f;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
        
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        Vector3 velocity = new Vector3(0.0f, 2.0f, 0.0f);
        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(velocity * velocityspeed, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}

