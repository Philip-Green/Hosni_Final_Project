using UnityEngine;

public class PlayerHurt : MonoBehaviour
{
    public int damagetaken;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().Hurtplayer(damagetaken);
        }
    }






}
