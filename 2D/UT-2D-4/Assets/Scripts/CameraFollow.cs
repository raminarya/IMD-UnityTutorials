using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	// used to get the players position
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// mimics players position
		transform.position = new Vector3(player.transform.position.x,0,transform.position.z);
	}
}
