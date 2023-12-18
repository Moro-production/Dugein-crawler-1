using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Security.Cryptography;

public class UnitHealth1 : MonoBehaviour
    
{
    public GameObject player;
    // fields 
    int _currentHealth=100;
    public int _currentMaxHealth=100;
    public TextMeshProUGUI textmesh;

  

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
            textmesh.text = "Health: "+value.ToString();
            if (_currentHealth <= 0)
            {
                Health = 0;
                // game over code
                
            }
            
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
   
   
}


