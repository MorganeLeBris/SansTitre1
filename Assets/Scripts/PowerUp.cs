using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

	HUD hud;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (5, 5, 5));
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			hud = GameObject.Find ("Main Camera").GetComponent<HUD> ();
			hud.IncreaseScore (1);
			Destroy (this.gameObject);
		}
	}
}
