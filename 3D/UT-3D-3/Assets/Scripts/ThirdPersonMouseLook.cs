using UnityEngine;
using System.Collections;

public class ThirdPersonMouseLook : MonoBehaviour {
	
	public Vector3 _lastPosition;
	public Vector3 _lookAtDirection;
	
	public Vector3 _screenCenter;
	
	// Use this for initialization
	void Start () {
		_lastPosition = new Vector3 (0, 0, 0); //initialize the "last position" of the mouse so as to avoid errors
		_screenCenter = new Vector3 (Screen.width/2, Screen.height/2, 0); //get the position at the center of the screen
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.mousePosition != _lastPosition){ //check to see if the mouse moved
			Vector3 targetPosition = Input.mousePosition - _screenCenter; //get the position of the mouse around the center of the screen
			_lookAtDirection = new Vector3(targetPosition.x, transform.position.y, targetPosition.y); //translate the target position to world space around the player
			
			transform.LookAt(_lookAtDirection); //turn the player to look in the direction of the mouse
		}
		
		_lastPosition = Input.mousePosition; //update the last position
	}
}