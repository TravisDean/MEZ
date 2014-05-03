using UnityEngine;
using System.Collections;

/// <summary>
/// Unused now. Idea was that animating color of particles
/// through scripts would require directly accesing them.
/// </summary>
[RequireComponent(typeof(ParticleSystem))]
public class ColorMorpher : MonoBehaviour {

    //public Color color;
    //private Color startingColor = Color.red;
    //private Color endColor = Color.white;
    //private ParticleSystem ps;

	// Use this for initialization
    //void Start () {
    //    ps = GetComponent<ParticleSystem>();
    //    endColor.a = 255;
    //}
	
	// Update is called once per frame
    //void Update () {

        //startingColor = Color.Lerp(startingColor, endColor, Time.deltaTime);
        //ps.startColor = startingColor;

        //print("Delta time ? " + Time.deltaTime.ToString() + "\n\tColor shifting to " + startingColor.ToString());
    //}
}
