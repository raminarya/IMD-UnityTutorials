using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	private float startTime; //the time that this object was created in seconds
	private float lifeTime = 1.5f; //how long this object will exist in seconds

	public void Start(){
		startTime = Time.time; //save the time that the object was made.
	}

	public void Update(){
		Move(); //Projectile will fly forward
		CheckLife(); //projectile will expire after some time
	}

	public void OnTriggerEnter(Collider hit){
		//Check if the projectile hits an enemy
		if(hit.CompareTag("Enemy")){
			hit.gameObject.GetComponent<AI>().Die(); //call the die function on the Enemy's AI script.
			Die(); //Also remove the projectile.
		}
	}

	public void Move(){
		transform.position += transform.forward/4; //move the object forward each frame.
	}

	void CheckLife(){
		//if the time since creation is longer than the lifetime, remove this projectile.
		if(Time.time - startTime > lifeTime)
			Die();
	}

	void Die(){
		Destroy (this.gameObject); //destroy the gameObject associated with this script.
	}
}