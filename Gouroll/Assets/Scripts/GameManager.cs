using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public GameObject completionUI;
    public GameObject failureUI;

    public void DeadState()
    {
        failureUI.SetActive(true);
    }

    public void CompleteLevel()
    {
        completionUI.SetActive(true);
    }
    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
        }
    }
}
