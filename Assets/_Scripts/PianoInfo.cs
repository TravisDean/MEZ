using UnityEngine;
using System.Collections;

/// <summary>
/// Debug class providing information about the PianoManager.
/// </summary>
[RequireComponent(typeof(TextMesh))]
public class PianoInfo : MonoBehaviour {
    public string startString = "Input type: ";
    private TextMesh text;

    public PianoManager piano;
    void Start()
    {
        text = this.GetComponent<TextMesh>();
        text.text = startString;
        piano = GameObject.FindObjectOfType<PianoManager>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = piano.ToString(); 
	}
}
