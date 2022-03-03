using UnityEngine;

public class EnemiesHurt : MonoBehaviour
   
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemies"))
        {
            //other.gameObject.GetComponent<EnemiesHealth>().Hurtenemies(damagetaken);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
