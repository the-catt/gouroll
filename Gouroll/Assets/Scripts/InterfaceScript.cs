using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InterfaceScript : MonoBehaviour
{
   
    public void ResetScene()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
