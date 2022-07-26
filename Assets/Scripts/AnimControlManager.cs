using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlManager : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            //Switching to rotate animation
            animator.SetInteger("switchingState", 1);
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            //Switching to expand and shrink animation
            animator.SetInteger("switchingState", 0);
        }
    }
}
