using UnityEngine;
using System.Collections;

public class rot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate (Vector3.up * Time.deltaTime );
		transform.RotateAround (Vector3.zero,Vector3.right,20 * Time.deltaTime);
	}
}
