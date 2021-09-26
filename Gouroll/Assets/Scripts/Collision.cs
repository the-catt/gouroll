using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        movement.enabled = false; //disables movement script on win
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; //disables movement script on death
            FindObjectOfType<GameManager>().GameOver(); //sets game has ended to true
            FindObjectOfType<GameManager>().DeadState(); //enables game over UI
            FindObjectOfType<AudioManager>().Play("PlayerDeath"); //plays death.wav on death
            Destroy(gameObject); //destroys player
        }
        
    }

}
