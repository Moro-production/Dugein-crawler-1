using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class Sword : MonoBehaviour
{
    
    public Animator anim;
    //public GameObject Enemy1;
    public int SwordDmg=10;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Active");
        }
        
    }
   


}
