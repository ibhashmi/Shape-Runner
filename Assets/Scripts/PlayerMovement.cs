using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // reference to Rigidbody component
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float rightForce = 500f; 
    
    void Start()
    {
        Application.targetFrameRate = 60;
    }


    // FixedUpdate used when adjusting physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Time.delta allows game to run smooth on slower or faster devices

        // PLAYER MOVEMENT
        if (Input.GetKey("d"))
        {
            rb.AddForce(rightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-rightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        
    }
}
