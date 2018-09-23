using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Use this for initialization
    public int life = 200;
    private Animator animator;

    void Awake () {
        animator = GetComponent<Animator>();
        transform.tag = "Player";
    }
	
	// Update is called once per frame
	void Update () {
        animator.SetInteger("life", life);
        Debug.Log(life);
            
    }

    /*private void OnCollisionEnter(Collision other) {
        if (other.collider.tag == "Inimigo")
        {
            Debug.Log ("Colidiu");
        }

    }*/
}
