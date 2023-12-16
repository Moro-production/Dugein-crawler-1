using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurAxe : MonoBehaviour
{
    public GameObject player;
    public int Minataur1attackDamage = 10;
    
    
   
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
        if (collision.gameObject == player)
        {

            player.GetComponent<UnitHealth1>().Health -= Minataur1attackDamage;
        }

    }
}
