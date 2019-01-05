
using UnityEngine;
using UnityEngine.SceneManagement;      //used for switching or reloading scenes

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;
    public float delayTime = 2f;    //set delay time to 2 seconds
    public GameObject levelCompleteUI;  //reference to end level panel

    public void GameOver()  //needs to be accessed in PlayerCollision
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GAME OVER!");
            Invoke("RestartGame", delayTime);
            
        }
        
    }
    
    
    public void LevelComplete()
    {
        levelCompleteUI.SetActive(true);    //enable UI
    }

    private void RestartGame()
    {
        /* inside brackets: gets current scene name
        * outside brackets: loads scene by name (parameter)
        */
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
    }
}
