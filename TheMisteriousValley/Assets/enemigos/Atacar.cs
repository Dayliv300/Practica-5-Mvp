using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacar : MSFManager
{

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

        base.OnStateEnter(animator, stateInfo, layerIndex);
        NPC.GetComponent<TrollIA>().StartAtack();
    }

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

        var direction = player.transform.position - NPC.transform.position;
        direction.y = 0;
        NPC.transform.rotation = Quaternion.Slerp(NPC.transform.rotation, Quaternion.LookRotation(direction), rotSpeed * Time.deltaTime);
        NPC.transform.LookAt(new Vector3(player.transform.position.x, NPC.transform.position.y, player.transform.position.z));
        //NPC.transform.LookAt(new Vector3(player.transform.position.x,0, player.transform.position.z));

    }

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        
    }

	
}
