using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Rotates the hill's slope up and down with Insert/Delet.
/// </summary>
public class HillRotator : MonoBehaviour {
    [SerializeField]
    public int rotationInterval = 10;
    [SerializeField]
    public Transform objectToRotate;
    [SerializeField]
    public Transform pointRotateAround; // Use root-level transform 

    public int rotationX;

    // Debugging use 
    public Vector3 worldPoint;
    public Vector3 rotationAxis;

	void Start () {
        // Seperate to perform any potentially required space transformations
        worldPoint = pointRotateAround.position;
        rotationAxis = pointRotateAround.TransformDirection(Vector3.right);

        rotateAroundPoint(-40); // Setup the object initially.
	}
	
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Insert))
        {
            rotateAroundPoint(rotationInterval);
        }
        else if (Input.GetKeyDown(KeyCode.Delete))
        {
            rotateAroundPoint(-rotationInterval);
        }
	}

    public void rotateAroundPoint(int degrees)
    {
        objectToRotate.RotateAround(worldPoint, rotationAxis, degrees);
        rotationX = rotXFromTransform(objectToRotate);
    }

    private int rotXFromTransform(Transform t)
    {
        int rot = (int)t.transform.eulerAngles.x;
        //print("Transform right now is " + rot);
        return Math.Abs(rot - 360); 
    }

    private void debug()
    {
        print("public rotation point? - " + pointRotateAround.ToString());
        print("translated world point? - " + worldPoint.ToString());
    }
}
