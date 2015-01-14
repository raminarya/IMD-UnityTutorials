using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{
	// players speed
	public float speed = 6.0f;

	// stores wether the character is on the ground or has run into an enemy
	public bool onGround = false;

	// called from Collision.cs when the character makes contact with the ground
	public void isOnGround(bool passThrough){onGround = passThrough;}

	// create an animator
	Animator animator;
	
	void Start()
	{
		// pull info from the characters Animator onto animator
		animator = GetComponent<Animator>();
		Application.targetFrameRate = 200;
	}
	
	void Update()
	{
		// call the movement function
		Movement();
	}

	// all player movements
	// associating the players movement with the appropriate animations
	// flips the character so the animation goes both left and right
	void Movement()
	{
		animator.SetFloat("moveSpeed", Mathf.Abs(Input.GetAxis ("Horizontal")));
		
		if(Input.GetAxisRaw("Horizontal") > 0)
		{
			transform.Translate(Vector3.right * speed * Time.deltaTime); 
			transform.eulerAngles = new Vector2(0, 0); 
		}
		
		if(Input.GetAxisRaw("Horizontal") < 0)
		{
			transform.Translate(Vector3.right * speed * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 180); 
		}

		// if the character is on the ground and you press space he will jump
		if(Input.GetKeyDown (KeyCode.Space) && onGround)
		{
			onGround = false;
			rigidbody2D.AddForce(transform.up * 300f);
			animator.SetTrigger("jump");
		}
	}
}
