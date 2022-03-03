using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerMaxHealth;
    public int playerCurrentHealth;

    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
    }

    void Update()
    {
        if (playerCurrentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void Hurtplayer(int damagetaken)
    {
        playerCurrentHealth -= damagetaken;
    }
}
