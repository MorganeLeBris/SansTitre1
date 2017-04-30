using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour {

	public GameObject[] objects;
	public float spawnMin;
	public float spawnMax;


	// Use this for initialization
	void Awake () {
		if (spawnMax == spawnMin)
			Spawn ();
		else
			Invoke ("SpawnPower",Random.Range(spawnMin,spawnMax));
	}
	
	// Update is called once per frame
	void Update () {

	}

	void Spawn(){
		Instantiate(objects[0], new Vector3(transform.position.x,transform.position.y,0), Quaternion.identity);
		Invoke ("Spawn",0.6f);
	}

	void SpawnPower(){
		Instantiate(objects[0], new Vector3(transform.position.x,transform.position.y+(Random.Range(2,5)),0), Quaternion.identity);
		Invoke ("SpawnPower",Random.Range(spawnMin,spawnMax));
	}
}
