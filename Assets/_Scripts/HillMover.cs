using UnityEngine;
using System.Collections;

public class HillMover : MonoBehaviour {
    [SerializeField]
    public float positionInterval = 0.1f;

	void Update () {
        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            this.transform.Translate(Vector3.down * positionInterval);
        }
        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            this.transform.Translate(Vector3.up * positionInterval);
        }
	
	}
}
