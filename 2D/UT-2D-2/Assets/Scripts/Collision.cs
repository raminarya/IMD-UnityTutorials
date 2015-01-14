using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	public Main main;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// when the character hits the ground change the boolean in main.cs to true
	void OnTriggerEnter2D(Collider2D objectHit)
	{
		// if the ground gets hit by a gameobject with tag "character", change boolean to true
		if(objectHit.gameObject.tag == "character")
			main.isOnGround(true);
		}
}
