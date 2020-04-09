﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : StateMachineBehaviour
{
    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

     //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("yeet");
            animator.SetBool("Attack2",true);
        }        
        
/*        if (Input.GetKeyDown(KeyCode.Mouse0) && animator.GetBool("Attack2"))
        {
            Debug.Log("yeet");
            animator.SetBool("Attack3",true);
        }*/
    }

     //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {



    }


}