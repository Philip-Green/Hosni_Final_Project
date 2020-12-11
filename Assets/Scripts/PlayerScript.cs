using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{
    public float movementSpeed;
    Rigidbody2D rightWall, leftWall;
    // Start is called before the first frame update
    void Start()
    {
       //Rigidbody2D= GetComponent<>
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
     
    }
    
    void PlayerMovement()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;

        }
    }

}


