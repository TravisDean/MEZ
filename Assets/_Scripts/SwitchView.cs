// Generic Script to allow switching between VR/non-VR
// and FPS vs overhead cameras.
// Travis Dean.
using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SwitchView : MonoBehaviour {
	public bool usingVR = false;
	public bool usingFPS = true;

	public GameObject playerAgent;
	public GameObject entityView;
	public GameObject vr_playerAgent;
	public GameObject vr_entityView;

//	private IList<GameObject> views;

	// Use this for initialization
	void Start () {
		setView();
//		views = new IList<GameObject>();
	}

	void setView() {
		playerAgent.SetActive(!usingVR && usingFPS);
		entityView.SetActive(!usingVR && !usingFPS);
		vr_playerAgent.SetActive(usingVR && usingFPS);
		vr_entityView.SetActive(usingVR && !usingFPS);
	}
		
	// Update is called once per frame
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
