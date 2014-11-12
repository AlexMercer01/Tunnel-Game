using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float startSpeed=10;
	public float maxSpeed=100;
	public float acc=0.01f;
	private float curSpeed;

	// Use this for initialization
	void Start () {
		curSpeed = startSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = new Vector3 (0f, 0f, curSpeed);
		curSpeed += acc;
		curSpeed = Mathf.Clamp (curSpeed, startSpeed, maxSpeed);
		}
}
