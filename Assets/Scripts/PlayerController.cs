using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed=50;
	public float moveHorizontal;
	public float moveVertical;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moveHorizontal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical"); 
	}

}
