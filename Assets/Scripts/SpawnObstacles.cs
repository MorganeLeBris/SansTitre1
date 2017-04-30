using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour {

	public GameObject obj;
	public GameObject obj2;

	// Use this for initialization
	void Awake () {

		Spawn ();
	}

	// Update is called once per frame
	void Spawn () {

		Instantiate(obj, new Vector3(transform.position.x,transform.position.y-3,0), Quaternion.identity);

		int rand;
		rand= Random.Range (0, 2);

		if(rand==1)
			Instantiate(obj2, new Vector3(transform.position.x+10,transform.position.y+2f,0), Quaternion.identity);
		else
			Instantiate(obj2, new Vector3(transform.position.x+10,transform.position.y-2f,0), Quaternion.identity);
		
		Invoke ("Spawn",Random.Range(1f,1.8f));
	}
}
