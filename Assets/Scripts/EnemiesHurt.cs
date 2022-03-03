using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesHurt : MonoBehaviour
   
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemies")
        {
            //other.gameObject.GetComponent<EnemiesHealth>().Hurtenemies(damagetaken);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
