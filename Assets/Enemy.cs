using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEngine;



 public class Enemy : MonoBehaviour
{ 
    
    
    
    /// The target object that the monster should chase and attack.
    public Transform Player;
   
  
    /// The speed at which the monster moves towards the target.
  
    public float movementSpeed = 3f;

    
    /// The distance at which the monster considers the target within range.
    
    public float attackRange = 2f;

   
    /// The damage inflicted by the monster's attack.
    
    public int Enemy1attackDamage = 10;
  


    /// The time interval between each attack.

    public float attackInterval = 2f;

    private float attackTimer;
    public float Enemy1Health = 100;

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