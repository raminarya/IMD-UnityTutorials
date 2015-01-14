using UnityEngine;
using System.Collections;

public class Waypoint : MonoBehaviour {

	//this is a Unity function which detects when an object enters this object's trigger collider
	void OnTriggerEnter(Collider hit){ // hit is the collider of the object which enters this trigger
		if(hit.CompareTag("Enemy")){ //check the tag of the object to see if it is the enemy, if so...
			hit.GetComponent<AI>().NextWaypoint();// have the enemy move towards the next waypoint
		}
	}
}
