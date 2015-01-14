using UnityEngine;
using System.Collections;

public class KillTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider hit){
		if(hit.CompareTag("Player")){
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
