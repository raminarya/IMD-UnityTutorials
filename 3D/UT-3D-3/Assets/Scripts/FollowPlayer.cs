using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public GameObject player; //drag the First Person Controller into this object in the inspector.
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPosition = player.transform.position; //get the player's position
		targetPosition.y += 10; //target a position above the player
		transform.position = targetPosition; //move the camera to the target position above the player
	}
}
