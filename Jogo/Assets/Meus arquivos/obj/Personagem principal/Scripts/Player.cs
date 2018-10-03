using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //MOVIMENTAÇÃO
    private float andar = 0;
    private float rotacionar = 100;

    public int life = 200;
    private Animator animator;

    void Awake () {
        animator = GetComponent<Animator>();
        transform.tag = "Player";
    }
	
	
	void Update () {

        andar = Input.GetAxis("Vertical");  //ANDAR

        if (Input.GetKey(KeyCode.LeftShift)) //CORRER
        {
            andar += 1;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            andar = -1;
        }
        animator.SetFloat("walking", andar);
        this.transform.Rotate(0, (Input.GetAxis("Horizontal") * rotacionar) * Time.deltaTime, 0);  //ROTACIONAR

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
