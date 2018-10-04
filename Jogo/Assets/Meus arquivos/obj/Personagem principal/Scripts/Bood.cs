using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bood : MonoBehaviour {

    private GameObject player;
    private Animator animator;
    // Use this for initialization

    void Start () {
        player = GameObject.FindWithTag("Player");
        animator = GetComponent<Animator>();
        animator.StopPlayback();
    }
	
	// Update is called once per frame
	void Update () {
        if (player.GetComponent<Player>().life < 1){
            animator.Play("bood");
            //Destroy(player);

        }
    }
}
