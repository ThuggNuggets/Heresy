﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boss_Attacking : StateMachineBehaviour
{
    public GameObject Baal;
    public GameObject player;
    public NavMeshAgent agent;
    
    public float rotSpeed = 10f;
    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        
        player = GameObject.FindGameObjectWithTag("Player");
        Baal = GameObject.FindGameObjectWithTag("Baal");
        agent = animator.GetComponent<NavMeshAgent>();

        
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Attack_Jump"))
        {            
            Vector3 direction = player.transform.position - agent.transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            agent.transform.rotation = Quaternion.Lerp(agent.transform.rotation, rotation, rotSpeed * Time.deltaTime);
        }
        else
        {
            
            
        }
    }
    public void EndJumpATK()
    {
        agent.Warp(Baal.transform.position);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
