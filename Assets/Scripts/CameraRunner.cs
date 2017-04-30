using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRunner : MonoBehaviour {

	public Transform player;
    public AudioSource sound;
    // Use this for initialization
    void Start () {
        sound.Play();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.position.x + 6, 0, -10);
	}



}
