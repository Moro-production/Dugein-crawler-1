using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minataur : MonoBehaviour
{
    public GameObject player;
    /// The target object that the monster should chase and attack.
    public Transform Player;


    /// The speed at which the monster moves towards the target.

    public float movementSpeed = 3f;


    /// The damage inflicted by the monster's attack.

    

    private float attackTimer;
    public float Minataur1Health = 100;
    public float attackInterval = 2f;
    public float attackRange = 2f;

    private void Update()
    {

        // Check if the target is within attack range.
        if (Vector3.Distance(transform.position, Player.position) <= attackRange)
        {
            // Attack the target if the attack timer has elapsed.
            if (attackTimer <= 0f)
            {
                Attack();
                attackTimer = attackInterval;
            }
            else
            {
                attackTimer -= Time.deltaTime;
            }
        }
        else
        {
            // Move towards the target.
            transform.position = Vector3.MoveTowards(transform.position, Player.position, movementSpeed * Time.deltaTime);
        }
    }



    /// Attacks the target by reducing its health.

    private void Attack()
    {

    }
   

}
