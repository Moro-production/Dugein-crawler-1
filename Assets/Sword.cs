using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class Sword : MonoBehaviour
{
    public Animator anim;
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



