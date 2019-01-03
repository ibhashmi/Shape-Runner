
using UnityEngine;
using UnityEngine.SceneManagement;      //used for switching or reloading scenes

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;

    public void GameOver()  //needs to be accessed in PlayerCollision
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("GAME OVER!");
            RestartGame();
            
        }
        
    }
    
    private void RestartGame()
    {

    }
}
