using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	// Use this for initialization
	public ControllableBehaviour myControllable;
	
	
	void Update () {
		myControllable.moveVertical (Input.GetAxis ("Vertical"));
		myControllable.moveHorizontal (Input.GetAxis ("Horizontal"));
	}
}
