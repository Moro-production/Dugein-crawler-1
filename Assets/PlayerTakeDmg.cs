using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDmg : MonoBehaviour
{
    public Animator enemyanimator;
    bool debounce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyanimator.GetCurrentAnimatorStateInfo(0).IsName("Monster_anim|Atack") && !debounce)
        {
            debounce = true;
            // damage code

            Debug.Log("Attack");
        }
        else debounce = false;
        
    }
}
