using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform Enemies5;
    public float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        //Enemies5= GetComponentInChildren<Enemies5>
    }

    // Update is called once per frame
    void Update()
    {
        Enemies5.position += Vector3.right * enemySpeed;
    }
}
