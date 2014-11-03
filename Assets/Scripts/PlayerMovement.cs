using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float startSpeed=10;
	public float maxSpeed=100;
	public float acc=1;
	public float curSpeed;
	public float sideSpeed=10;

	// Use this for initialization
	void Start () {
		curSpeed = startSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = new Vector3 (curSpeed, 0, 0);
		rigidbody.AddForce (movement * curSpeed * Time.deltaTime);
		curSpeed += acc;
		curSpeed = Mathf.Clamp (curSpeed, startSpeed, maxSpeed);
	}
}
