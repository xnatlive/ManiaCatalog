using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Vuforia;

public class menu : MonoBehaviour {
	public Canvas cnvCategoryMenu;
	public Canvas cnvMainMenu;
	public Button btnShowCategory;
	public Button btnBack2Camera;

	// Use this for initialization
	void Start () {
		cnvMainMenu = cnvMainMenu.GetComponent<Canvas> ();
		cnvCategoryMenu = cnvCategoryMenu.GetComponent<Canvas> ();
		btnShowCategory = btnShowCategory.GetComponent<Button> ();
		btnBack2Camera = btnBack2Camera.GetComponent<Button> ();
		cnvCategoryMenu.enabled = false;

	}

	public void ShowCategoryPress(){
		CameraDevice.Instance.Stop ();
		cnvMainMenu.enabled = false;
		cnvCategoryMenu.enabled = true;
		//btnBack2Camera.enabled = true;

	}
	public void varBack2CameraPress(){
		cnvMainMenu.enabled = true;

		cnvCategoryMenu.enabled = false;
		//btnBack2Camera.enabled = false;
		CameraDevice.Instance.Start ();

	
	}


}
