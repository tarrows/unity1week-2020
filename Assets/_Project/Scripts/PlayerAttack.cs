using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : StateMachineBehaviour
{

    private const string state_isWalk = "isWalk";
    private const string state_isJump = "isJump";
    private const string state_isAttack = "isAttack";

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        animator.SetBool(state_isAttack, false);
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateUpdate(animator, stateInfo, layerIndex);
        
        if (!animator.GetBool(state_isJump) && Input.GetButton("Fire1"))
        {
            animator.SetBool(state_isAttack, true);
        }
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);

        animator.SetBool(state_isAttack, false);
    }
}
