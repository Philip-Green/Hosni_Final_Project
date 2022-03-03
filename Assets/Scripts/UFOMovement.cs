using UnityEngine;

public class UFOMovement : MonoBehaviour
{

    public Transform UFO;
    public float ufoSpeed, incrementSpeed;
    
    void Update()
    {
        UFO.position += Vector3.right * (ufoSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            //Debug.Log("Help");
            transform.position += Vector3.left * 25 * Time.deltaTime;
            ufoSpeed *= -1;
            if (ufoSpeed > 0)
                ufoSpeed += incrementSpeed;
            else
                //enemySpeed = Mathf.Abs(enemySpeed) * incrementSpeed * -1;
                ufoSpeed -= incrementSpeed;
        }
    }
}
