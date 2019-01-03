
using UnityEngine;

public class ShapeCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo) //this code runs 
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an " + collisionInfo.collider.name + "!");
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();

        }
        
    }

}
