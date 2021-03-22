using UnityEngine;
using UnityEngine.UI;   //allows to write code for UI

public class PlayerScore : MonoBehaviour
{
    public Transform player;    //"Transform" deals with positions and rotations
    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = player.position.z.ToString("0");       //add zero to display score without decimals
    }
}
