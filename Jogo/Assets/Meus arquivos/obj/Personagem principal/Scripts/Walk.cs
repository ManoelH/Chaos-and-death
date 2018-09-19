using UnityEngine;

public class Walk : MonoBehaviour {
    private Animator animator;
    private float andar = 0;
    private float rotacionar = 100;

	void Awake () {
        animator = GetComponent<Animator>();
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
        animator.SetFloat("Walking", andar);
        this.transform.Rotate(0, (Input.GetAxis("Horizontal")*rotacionar)*Time.deltaTime, 0);  //ROTACIONAR
	}
}
