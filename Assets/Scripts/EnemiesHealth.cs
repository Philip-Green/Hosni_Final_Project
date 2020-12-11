using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesHealth : MonoBehaviour
{
    public int enemiesMaxHealth;
    public int enemiesCurrentHealth;


    // Start is called before the first frame update
    void Start()
    {
        enemiesCurrentHealth = enemiesMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesCurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }


    public void Hurtenemies(int damagetaken)
    {
        enemiesCurrentHealth -= damagetaken;
    }

    public void SetMaxHealth()
    {
        enemiesCurrentHealth = enemiesMaxHealth;
    }






}   
