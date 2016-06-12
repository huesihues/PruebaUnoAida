using UnityEngine;
using System.Collections;

public class report : MonoBehaviour {
	public GvrHead head;
	// Use this for initialization
	void Start () {
		Debug.Log ("------>>>>");
		Debug.Log ("------>>>>");
		Debug.Log ("------>>>>");
		Debug.Log ("------>>>>");
		Debug.Log ("------>>>>");


	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("rotation " + head.trackRotation);
	
	}
}
