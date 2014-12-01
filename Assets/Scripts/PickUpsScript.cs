using UnityEngine;
using System.Collections;

public class PickUpsScript : MonoBehaviour {
	public GameObject prefab;
	public GameObject player;
	GameObject instance;
	int i=30;
	int k=1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (k == 1) {
			float positionX = Random.Range (-5, 5);
			float positionY = Random.Range (-5, 5);
			instance = Instantiate (prefab) as GameObject;
			instance.transform.position = new Vector3 (positionX, positionY, i);
			i = i + 60;
			k = 0;
		}
		if (player.transform.position.z > instance.transform.position.z) {
			k = 1;
		}
	}
}
