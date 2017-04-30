using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacles : MonoBehaviour {
	public TextMesh letter;
	private Image im;
	// Use this for initialization
	void Start () {
		 
		int rand = Random.Range (0, 4);
		switch (rand) {
		case 0:
			letter.text = "W";
			break;
		case 1:
			letter.text = "A";
			break;
		case 2:
			letter.text = "S";
			break;
		case 3:
			letter.text = "D";
			break;
		}
		 
	}

	void OnCollisionEnter2D(Collision2D coll){
		Debug.Log("Game Over");
		FindObjectOfType<HUD> ().GameOver ();
	}

	// Update is called once per frame
	void Update () {
		foreach (KeyCode kcode in System.Enum.GetValues(typeof(KeyCode))) {
			if (Input.GetKeyDown (kcode)) {
				if (kcode.ToString () == letter.text) {
					transform.Translate (new Vector3 (0,10,0));
				}
			}
		}
	}
}
