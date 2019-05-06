using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MSFManager : StateMachineBehaviour {

    public GameObject NPC;
    public GameObject player;
    public GameObject House;
    public NavMeshAgent agent;

    public float speed = 3.0f;
    public float rotSpeed = 2.0f;
    public float accuracy = 3.0f;
    public NavMeshAgent agente;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NPC = animator.gameObject;
        player = NPC.GetComponent<TrollIA>().GetPlayer();
        agente = NPC.GetComponent<NavMeshAgent>();
        House = GameObject.FindGameObjectWithTag("HOUSE");
    }

}
