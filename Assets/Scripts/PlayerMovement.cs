using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float startSpeed=10;
	public float maxSpeed=100;
	public float acc=1;
	private float curSpeed;
	private float sideSpeed=50;
	private float moveVertical;
	private float moveHorizontal;

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
		moveVertical = GameObject.Find ("Player").GetComponent<PlayerMovement> ().moveVertical;
		moveHorizontal = GameObject.Find ("Player").GetComponent<PlayerMovement> ().moveHorizontal;
		Vector3 Smovement = new Vector3 (0.0f, moveVertical, -moveHorizontal);
		rigidbody.AddForce (Smovement * sideSpeed * Time.deltaTime);
	}
}
