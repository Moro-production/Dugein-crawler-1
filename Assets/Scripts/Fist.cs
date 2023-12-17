using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fist : MonoBehaviour
{
    public GameObject player;
    public int EnemyattackDamage;
   
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
        
            player.GetComponent<UnitHealth1>().Health -= EnemyattackDamage;
        }

    }

   


}
