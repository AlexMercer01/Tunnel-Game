using UnityEngine;
using System.Collections;

public class PlayerController : ControllableBehaviour {
	
	public float startSpeed=10;
	public float maxSpeed=100;
	public float acc=0.01f;
	private float curSpeed;
	private float horizontalMovement;
	private float verticalMovement;
	
	// Use this for initialization
	void Start () {
		curSpeed = startSpeed;
	}
	// Update is called once per frame


	void FixedUpdate () {
		curSpeed += acc;
		curSpeed = Mathf.Clamp (curSpeed, startSpeed, maxSpeed);
		rigidbody.velocity = new Vector3 (horizontalMovement,verticalMovement, curSpeed);

		}
	public override void moveHorizontal (float movementValue){
			horizontalMovement = movementValue;
		}
		
		public override void moveVertical (float movementValue){
			verticalMovement = movementValue;
		}

}
