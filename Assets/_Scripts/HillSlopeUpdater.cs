using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Updates the GUI billboard's text with the slope.
/// </summary>
[RequireComponent(typeof(TextMesh))]
public class HillSlopeUpdater : MonoBehaviour {
    public string promptStr = "Hill Slope: ";
    public HillRotator hillThing;

    private TextMesh mesh;

	void Start () {
        hillThing = GameObject.FindObjectOfType<HillRotator>() as HillRotator;
        mesh = this.GetComponent<TextMesh>();
        mesh.text = promptStr;
	}
	
    // Somewhat inefficient, but whole script uses ~0.2% CPU, so not worrying.
	void Update () {
        var slopeAngle = hillThing.rotationX;
        mesh.text = promptStr + slopeAngle + "°";
	}
}
