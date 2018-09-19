using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Use this for initialization
    public int life = 100;
    void Awake () {
        transform.tag = "Player";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /*private void OnCollisionEnter(Collision other) {
        if (other.collider.tag == "Inimigo")
        {
            Debug.Log ("Colidiu");
        }

    }*/
}
