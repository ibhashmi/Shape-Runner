
using UnityEngine;
using UnityEngine.SceneManagement;      //used for switching or reloading scenes

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;
    public float delayTime = 2f;    //set delay time to 2 seconds

    public void GameOver()  //needs to be accessed in PlayerCollision
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GAME OVER!");
            Invoke("RestartGame", delayTime);
            
        }
        
    }
    
    private void RestartGame()
    {
        /* inside brackets: gets current scene name
        * outside brackets: loads scene by name (parameter)
        */
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
    }
}
