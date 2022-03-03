using UnityEngine;

public class EnemiesHealth : MonoBehaviour
{
    public int enemiesMaxHealth;
    public int enemiesCurrentHealth;

    void Start()
    {
        enemiesCurrentHealth = enemiesMaxHealth;
    }

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
}   
