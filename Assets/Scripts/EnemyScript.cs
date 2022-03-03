using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform Enemy;
    public float enemySpeed, incrementSpeed;

    void Update()
    {
        Enemy.position += Vector3.right * (enemySpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Help");
            transform.position += Vector3.down *  25  * Time.deltaTime;
            enemySpeed *= -1;
            if (enemySpeed > 0)
                enemySpeed += incrementSpeed;
            else
                //enemySpeed = Mathf.Abs(enemySpeed) * incrementSpeed * -1;
                enemySpeed -= incrementSpeed;
        }
    }
}
