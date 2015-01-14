using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {
	public Main main;
	
	// enemies speed
	public float speed;
	
	// enemies initial x position
	float initialX;
	
	// Use this for initialization
	void Start () {
		// store the initial x position
		initialX = transform.position.x;
	}
	
	// Update is called once per frame
	void Update()
	{
		movement();
	}
	
	void movement(){
		Vector3 pos = transform.position;
		
		// Oscillate back and forth between the initial x and 5 units
		pos.x = Mathf.PingPong(Time.time*speed, 5) + initialX;
		transform.position = pos;
	}
	
	// if the character hits the enemy
	void OnTriggerEnter2D(Collider2D objectHit)
	{
		if(objectHit.gameObject.tag == "character")
			main.hasCrashed = true;
	}
}
