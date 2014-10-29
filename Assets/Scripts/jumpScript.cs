using UnityEngine;
using System.Collections;

public class jumpScript : MonoBehaviour {
	public float moveForce = 365f;            
	public float maxSpeed = 5f;            
	public float jumpForce = 1000f;
	public AudioClip jumpSound;
	public AudioClip deadSound;
	public bool jump = false;
	
	// Use this for initialization
	
	//Animator anim;
	void Start () {
		//anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//Si aprieto el boton saltar y Gamecontrol no es muerto. salta
		if(Input.GetButtonDown("Jump") && !GameControl.dead){
			jump = true;
		}
		//anim.SetBool("jump",jump);
	}
	
	void FixedUpdate() {
		if(jump)
		{    
			var v = new Vector2(0,0);
			//Si salto, paro el pollo y salta y se mueve, si no hago esto, el salto se hace exponencial.
			rigidbody2D.velocity = v; 
			//AudioSource.PlayClipAtPoint(jumpSound, transform.position);
			rigidbody2D.AddForce(new Vector2(0f, jumpForce));
			jump = false;
			
		}
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if(!GameControl.dead){
			GameControl.dead = true;
			//AudioSource.PlayClipAtPoint(deadSound, transform.position);
			//anim.SetBool("dead",true);
			rigidbody2D.gravityScale = 4;
		}
	}
}