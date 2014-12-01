using UnityEngine;
using System.Collections;

public class PlayerController : ControllableBehaviour {
	
	public float startSpeed=10;
	public float maxSpeed=100;
	public float acc=0.01f;
	public float curSpeed;
	public float sideSpeed;
	public GUIText countText;
	double count;
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
		rigidbody.velocity = new Vector3 (horizontalMovement*sideSpeed*Time.deltaTime,verticalMovement*sideSpeed*Time.deltaTime, curSpeed);
		}

		public override void moveHorizontal (float movementValue){
			horizontalMovement = movementValue;
		}
		
		public override void moveVertical (float movementValue){
			verticalMovement = movementValue;
		}
	void OnTriggerEnter(Collider other){
				if (other.gameObject.tag == "PickUp") {
			other.gameObject.SetActive(false);
			count=count+100;
			SetCountText();
				}
		}
	void SetCountText(){
				countText.text = "Count: " + count.ToString ();
		}

}
