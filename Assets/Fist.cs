using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fist : MonoBehaviour
{
    public GameObject player;
    public int attackDamage = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "Player")
        {
            if (attackDamage > 0)
            {
                player.GetComponent<UnitHealth1>().CurrentHealth--;
                if (player.GetComponent<UnitHealth1>().CurrentHealth <= 0)
                {
                   Destroy(player);

                }
            }
            Debug.Log("contact");
        }
    }
}
