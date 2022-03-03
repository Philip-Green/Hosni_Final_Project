using UnityEngine;

public class UFOBullet : MonoBehaviour
{
    public int damagetaken;
    bool shooting;
    public float bulletSpeed;
    private float yFire,xFire;
    public Transform UFO;
    public float t;

    void Update()
    {
        shoot();
        if (t > 0)
        {
            t -= Time.deltaTime;
        }
        else
        {
            //Debug.Log("Shooting should be true");
            shooting = true;
            t = 5;
        }
    }

    void shoot()
    {
        if (shooting)
        {
            transform.position += Vector3.down * (bulletSpeed * Time.deltaTime);
            if (transform.position.y < -4.5f)
            {
                shooting = false;
            }
        }

        else
        {
            transform.position = UFO.position;
            //Debug.Log(transform.position + " " + UFO.position);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().Hurtplayer(damagetaken);
            transform.position = UFO.position;
            shooting = false;
        }
    }


     


}
