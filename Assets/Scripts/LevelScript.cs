using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour {

	public GameObject wall1;
	public GameObject wall2;
	public GameObject wall3;
	public GameObject player;
	private int i=1;
	private int j = 1;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
			if (player.transform.position.z > 100*i) {
				if (j==1) {
					wall1.transform.position=new Vector3(0,0,wall1.transform.position.z+300);
				i++;j=2;}
				else if (j==2) {
					wall2.transform.position=new Vector3(0,0,wall2.transform.position.z+300);
				i++;j=3;}
				else if (j==3) {
					wall3.transform.position=new Vector3(0,0,wall3.transform.position.z+300);
				i++;j=1;}
			}
		if (j>3) j=1;
	}
}
