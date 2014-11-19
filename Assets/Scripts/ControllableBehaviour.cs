using UnityEngine;

public class ControllableBehaviour : MonoBehaviour {
	
	public virtual void moveHorizontal (float movementValue){
		Debug.Log ("Horizontal movement is not implemented");
	}
	public virtual void moveVertical (float movementValue){
		Debug.Log ("Vertical movement is not implemented");
	}
}

