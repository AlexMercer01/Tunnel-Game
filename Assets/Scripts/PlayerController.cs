using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed=50;
	private float moveHorizontal;
	private float moveVertical;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moveHorizontal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical"); 
		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}

}
