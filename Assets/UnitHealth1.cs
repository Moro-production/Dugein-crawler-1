using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth1 : MonoBehaviour
    
{
    public GameObject player;
    // fields 
    int _currentHealth=100;
    public int CurrentHealth = 100;
    public int _currentMaxHealth=100;

    int health = 100;
    int DmgUnit = 10;

    // properties
    public int Health
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;
        }
    }
    public int MaxHealth
    {
        get
        {
            return _currentMaxHealth;
        }
        set
        {
            _currentMaxHealth = value;
        }
    }
    // constructor
    public UnitHealth1(int Health, int MaxHealth)
    {
        _currentHealth = Health;
        _currentMaxHealth = MaxHealth;
    }
    public void DmgUnitFunc(int dmgAmount)
    {
        if (_currentHealth > 0)
        {
            _currentHealth -= dmgAmount;
        }
    }
    public void HealthUnit(int healAmount)
    {
        if (_currentHealth < _currentMaxHealth)
        {
            _currentHealth += healAmount;
        }
        if (_currentHealth < _currentMaxHealth)
        {
            _currentHealth += healAmount;
        }
        
        }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyBody")
        {
            if (DmgUnit > 0)
            {
               
                {
                   

                }
            }
            Debug.Log("contact");
        }
    }
}


