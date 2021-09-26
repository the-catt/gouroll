using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0; //speed of pumpkin

    private Rigidbody2D rigidb; //rigidbody
    private float movementX; 
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rigidb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue movementValue) //movement
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(movementX, movementY);
        rigidb.AddForce(movement * speed);
    }
}
