using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform Enemy;
    public float enemySpeed, incrementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //Enemies5= GetComponentInChildren<Enemies5>
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.position += Vector3.right * enemySpeed * Time.deltaTime;

        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
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
