using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	// Can set in inspector
	public float speed;
	public float angle;
	public float angleR;
	public float rotate;
	public float speedx;
	public float speedy;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		controller();
	}

	void controller () {
		// Right
		if (Input.GetKey (KeyCode.RightArrow)) {
			// Time.deltaTime move object over time, instead of frame. Example: x units per second, instead of x units per frame.
			//transform.Translate(speed * Time.deltaTime, 0.0f, 0.0f);
			angle += rotate;			
			angleR = angle/180*Mathf.PI;
			transform.Rotate (new Vector3 (0, 0, rotate));
			speedx = speed * Mathf.Sin(angleR);
			speedy = speed * Mathf.Cos(angleR);
		}
		// Left
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			//transform.Translate(((speed * Time.deltaTime)*-1), 0.0f, 0.0f);  
			angle -= rotate;			
			angleR = angle/180*Mathf.PI;
			transform.Rotate (new Vector3 (0, 0, -1*rotate));
			speedx = speed * Mathf.Sin(angleR);
			speedy = speed * Mathf.Cos(angleR);
		}

		// Up
		if (Input.GetKey (KeyCode.UpArrow)) {
			//transform.Translate (0.0f, speed * Time.deltaTime, 0.0f);  
			//this.renderer.enabled = true;
			//gameObject.SetActive(true);
			transform.position += new Vector3(0,0,1);
		}
		// Down
		if(Input.GetKey(KeyCode.DownArrow))	{
			//transform.Translate (0.0f, -1 * speed * Time.deltaTime, 0.0f);  
			//this.renderer.enabled = false;
			//gameObject.SetActive(false);
			transform.position += new Vector3(0,0,-1);
		}
	}
}
