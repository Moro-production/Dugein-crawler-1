using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class Sword : MonoBehaviour
{
    
    public Animator anim;
    
    public int SwordDmg=10;

    private void Start()
    {
        anim=GetComponent<Animator>();
       
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Active");
           

        }

    }
    

}
