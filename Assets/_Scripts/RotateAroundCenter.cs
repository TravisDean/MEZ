using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Rotates the piano, camera, and effects around a center point on a
/// configurable axis. Different axises give VERY different effects.
/// TODO: useful, interesting scripted control from Profiles.
/// </summary>
public class RotateAroundCenter: MonoBehaviour {
    public int rate = 5;
    public Transform centerRotation;
    public Vector3 rotateAroundAxis = Vector3.up;

	void Update () {
        // Rotate around the point on axis.
        transform.RotateAround(centerRotation.transform.position, rotateAroundAxis, Time.deltaTime * rate);
	}
}
