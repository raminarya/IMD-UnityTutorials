using UnityEngine;
using System.Collections;

public class CameraLook : MonoBehaviour {

	//store the rotation of the camera.
	private Vector3 cameraRotation = new Vector3(0,0,0);

	//define customization parameters to alter how fast the camera will move with the mouse.
	//these values can be changed from the Unity editor since they are public.
	public int XSensitivity = 5;
	public int YSensitivity = 5;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//save the amount the mouse has moved using Input.GetAxis for both X and Y axes. This function returns a value between -1 to 1 depending on the direction and amount of movement.
		//GetAxis will be 0 if the mouse has not moved.
		Vector2 mouseSpeed = new Vector2 (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

		//if the mouse has moved in X or Y direction, add a rotation to the camera. 
		if(mouseSpeed.x != 0 || mouseSpeed.y != 0){

			//add the amount the mouse has moved to the rotation of the camera in the right axis, multiplied by the sensitivity.
			cameraRotation.x -= mouseSpeed.y*YSensitivity; //add Y movement around the X axis (vertical)
			cameraRotation.y += mouseSpeed.x*XSensitivity; //add X movement around the Y axis (horizontal)

			//change the camera transform's local rotation to be the new rotation.
			transform.localEulerAngles = cameraRotation;
		}
	}
}