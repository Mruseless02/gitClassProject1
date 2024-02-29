using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void attackNow()
    {
        animator.SetTrigger("goAttack");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            attackNow();   
        }
    }
}
