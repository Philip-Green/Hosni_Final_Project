using UnityEngine;
public class PlayerScript : MonoBehaviour
{
    public float movementSpeed;
    Rigidbody2D rightWall, leftWall;

    void Update()
    {
        PlayerMovement();     
    }
    
    void PlayerMovement()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.position += Vector3.right * (movementSpeed * Time.deltaTime);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.position += Vector3.left * (movementSpeed * Time.deltaTime);
        }
    }
}


