using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour
{
    public void nextLevel()
    {
        AnimationEvent loadLevel;
        loadLevel = new AnimationEvent();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
