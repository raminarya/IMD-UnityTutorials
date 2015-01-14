using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	private float speed = 0.2f; //defines how fast the player will move each time Update() is called.
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//check if up arrow is pressed, if so, add the forward vector of the object to the object's position.
		//repeat for each Arrow key
		if(Input.GetKey(KeyCode.W)){//check up arrow status. Input.GetKey returns a bool, true is is pressed false if not. If true, move the object.
			transform.position += (transform.forward*speed); //transform.position refers to the attached object's transform component's position.
			//transform.forward is the vector pointing forward (which way the object is looking)
			//the forward vector is multiplied by the speed variable to adjust the speed
		}
		if(Input.GetKey(KeyCode.S)){
			transform.position += (-transform.forward*speed); //opposite of forward, move backward
		}
		if(Input.GetKey(KeyCode.D)){
			transform.position += (transform.right*speed);//directly to the object's right
		}
		if(Input.GetKey(KeyCode.A)){
			transform.position += (-transform.right*speed);//opposite of right, move left
		}
	}
}