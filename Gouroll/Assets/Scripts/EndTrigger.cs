using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.CompleteLevel(); //triggers level win UI
        FindObjectOfType<AudioManager>().Play("PlayerWin"); //triggers win sound effect
    }


}
