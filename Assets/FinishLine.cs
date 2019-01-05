
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        gameManager.LevelComplete();
    }
}
