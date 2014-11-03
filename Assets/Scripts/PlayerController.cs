using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed=10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical"); 
		Vector3 movement = new Vector3 (0.0f, moveVertical, -moveHorizontal);
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
}
