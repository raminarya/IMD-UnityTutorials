using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	private GameObject projectile;

	// Use this for initialization
	void Start () {
		//load the projectile resource as a GameObject
		projectile = (GameObject) Resources.Load("Projectile", typeof(GameObject));
	}
	
	// Update is called once per frame
	void Update () {
		HandleInput();
	}
	
	void HandleInput(){
		if(Input.GetMouseButton(0)){ //if left mouse clicked
			MakeProjectile();
		}
	}

	void MakeProjectile(){
		//make a new projectile in the game
		Instantiate(projectile, Camera.main.transform.position, Camera.main.transform.rotation);
	}
}