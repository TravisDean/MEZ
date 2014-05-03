using UnityEngine;
using System.Collections;
using System;
/// <summary>
/// Calculates the heigh of 
/// </summary>
[RequireComponent(typeof(TextMesh))]
public class HillHeightUpdater : MonoBehaviour
{
    public string heightStr = "Hill Height: ";
    public GameObject hillThing;

    private TextMesh mesh;

    void Start()
    {
        mesh = this.GetComponent<TextMesh>();
        mesh.text = heightStr;
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(hillThing.transform.position, Vector3.down, out hit))
        {
            var heightOfGround = hit.point.y;
            var hillTop = hillThing.transform.position.y;
            var height = hillTop - heightOfGround;

            var h = Math.Round(height, 2);
            mesh.text = heightStr + h + "m";  // "meters"
        }
        else
        {
            mesh.text = "Error. Hilltop below ground.";
        }
    }
}
