using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField] Animator anim1;
    public int SwordDmg = 10;
    public GameObject Sword1;
    // Start is called before the first frame update
    void Start()
    {
        anim1.SetTrigger("Attack");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim1.SetTrigger("Attack");
            
        }


    }
    
}
