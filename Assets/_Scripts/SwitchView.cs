// Generic Script to allow switching between VR/non-VR
// and FPS vs overhead cameras.
// Travis Dean.
using UnityEngine;
using System.Collections;

/// <summary>
/// Allows swapping between 4 cameras, normally used as 
/// VR / normal and first person / detached.
/// Swap with Enter and Home, respectively.
/// </summary>
[ExecuteInEditMode]
public class SwitchView : MonoBehaviour {
	public bool usingVR = false;
	public bool usingFPS = true;

	public GameObject playerAgent;
	public GameObject entityView;
	public GameObject vr_playerAgent;
	public GameObject vr_entityView;

	void Start () {
		setView();
	}

	void setView() {
		playerAgent.SetActive(!usingVR && usingFPS);
		entityView.SetActive(!usingVR && !usingFPS);
		vr_playerAgent.SetActive(usingVR && usingFPS);
		vr_entityView.SetActive(usingVR && !usingFPS);
	}
		
	void Update () {
		// On enter, switch between VR and normal views
		if (Input.GetKeyDown(KeyCode.Return)) {
			usingVR = !usingVR;
		}
		// On Home, switch between agent and entity
		if (Input.GetKeyDown(KeyCode.Home)) {
			usingFPS = !usingFPS;
		}
		setView();
	}
}
