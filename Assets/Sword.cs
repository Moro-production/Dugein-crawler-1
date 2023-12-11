using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject Enemy;
    public int SwordDamage=10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Enemy)
        {
            Debug.Log("Hitting");
            Enemy.GetComponent<Enemy>().EnemyHealth -= SwordDamage;
        }
    }
}
