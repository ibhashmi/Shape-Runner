using UnityEngine;
     


public class PlayerMovement : MonoBehaviour
{
    // reference to Rigidbody component
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float rightForce = 500f; 
    
    void Start()    //this happens at the start of the game
    {
        Application.targetFrameRate = 60;
    }


    // FixedUpdate used when adjusting physics
    void FixedUpdate()  //this method is called once every frame (so constant)
                        //Use FixedUpdate() instead of Update whenever using physics
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Time.delta allows game to run smooth on slower or faster devices

        // PLAYER MOVEMENT
        if (Input.GetKey("d"))
        { 
            /* Time.deltaTime : number of seconds since the computer drew the last frame (required otherwise
             *                  how smoothly the game's forces run will be different per quality of computer)
             */

            //going left is the default, apply a negative to the left force in order to get a right force
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
