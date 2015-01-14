using UnityEngine;
using System.Collections;

public class BasicCollision : MonoBehaviour {

	public GameObject player;
	/*Drag the First Person Controller from the Hierarchy to this variable in the Unity editor.
	 * This will assign the controller to the player object.
	 */

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		CheckCollisions();
	}

	void CheckCollisions(){

		//get the distance from this object (dude) to the player
		float distanceToPlayer = Vector3.Distance(this.transform.position, player.transform.position);

		if(distanceToPlayer < 1.4f){
			print ("Collision!"); //print a message to the console if the player is closer than 1.4 units
			Vector3 targetVector = this.transform.position - player.transform.position; //get vector from this (dude) to player
			targetVector.y = 0; //do not change the player's height
			player.transform.position -= targetVector*0.2f; //move the player away from this (dude) by a small amount
		}
	}
}