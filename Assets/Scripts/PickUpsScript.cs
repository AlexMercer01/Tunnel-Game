using UnityEngine;
using System.Collections;

public class PickUpsScript : MonoBehaviour {
	public GameObject prefab;
	public GameObject player;
	int i=30;
	int j=30;
	int k=1;
	// Use this for initialization
	void Start () {
	
	}
	GameObject instance;
	// Update is called once per frame
	void Update () {
		if (k == 1) {
			float positionX = Random.Range (-5, 5);
			float positionY = Random.Range (-5, 5);
			instance = Instantiate (prefab) as GameObject;
			instance.transform.position = new Vector3 (positionX, positionY, i);
			i = i + j;
			k = 0;
			instance.gameObject.tag="PickUp";
		}
		if (player.transform.position.z > instance.transform.position.z) {
						k = 1;
						Destroy (instance);
				} 
		if (player.transform.position.z > 5500) {
						j = 120;
				} else if (player.transform.position.z > 5000) {
						j = 110;
				}
		else if (player.transform.position.z > 4500) {
						j = 100;
				}
		else if (player.transform.position.z > 4000) {
						j = 90;
				}
		else if (player.transform.position.z > 3500) {
						j = 80;
				}
		else if (player.transform.position.z > 3000) {
						j = 70;
				}
		else if (player.transform.position.z > 2400) {
						j = 60;
				}
		else if (player.transform.position.z > 1500) {
						j = 50;
				}
		else if (player.transform.position.z > 600) {
						j = 40;
				}
	}
}
