using UnityEngine;
using System.Collections;

public class playScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void PlayKitchen(){
		Handheld.PlayFullScreenMovie ("kitchen1.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
