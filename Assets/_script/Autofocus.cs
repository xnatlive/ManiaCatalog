
	using UnityEngine;
	using UnityEngine.UI;
	using System.Collections;
	using Vuforia;

public class Autofocus : MonoBehaviour {
	
	bool focusModeSet;

	void Start () 
	{
		VuforiaBehaviour.Instance.RegisterVuforiaStartedCallback(OnVuforiaStarted);
		VuforiaBehaviour.Instance.RegisterOnPauseCallback(OnPaused);
	}



	private void OnVuforiaStarted()
	{
		CameraDevice.Instance.SetFocusMode(
			CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
	}

	private void OnPaused(bool paused)
	{
		if (!paused) // resumed
		{
			// Set again autofocus mode when app is resumed
			CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		}
	}

	void onEnable(){
		focusModeSet = CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);

		//CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO;
		if (!focusModeSet) {
			Debug.Log ("Failed to set focus mode (unsupported mode).");
		}
	}
}