using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class Zombie3 : MonoBehaviour {

    private Animator animator;
    private GameObject player;
    private NavMeshAgent navMesh;
    private float distancia;
    private bool playerMorto;
    private int attack = 0;
    private bool recebeuAttack1 = false;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        navMesh = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        navMesh.destination = player.transform.position;
        distancia = Vector3.Distance(transform.position, player.transform.position);
        animator.SetFloat("distancia", distancia);
        if (Vector3.Distance(transform.position, player.transform.position) < 1.5f)
            atacar();
        else if (Vector3.Distance(transform.position, player.transform.position) > 1.5f)
            attack = 0;
    }

    void atacar(){
        bool jaAtacou = false;
        if (attack == 0) {
            attack = 2;
        }
        if (attack == 1 && jaAtacou == false){
            player.GetComponent<Player>().life -= 10;
            attack = 2;
            jaAtacou = true;
        }
        else if (attack == 2 && jaAtacou == false){
            player.GetComponent<Player>().life -= 5;
            attack = 1;
            jaAtacou = true;
        }
        animator.SetInteger("attack", attack);

        if (player.GetComponent<Player>().life < 1){
            playerMorto = true;
            animator.SetBool("playerMorto", playerMorto);
            //Destroy(player);
        }

    }
}
