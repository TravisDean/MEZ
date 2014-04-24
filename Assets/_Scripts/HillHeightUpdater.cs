using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TextMesh))]
public class HillHeightUpdater : MonoBehaviour {
    public string heightStr = "Hill Height: ";
    public GameObject hillThing;

    private TextMesh text;

    void Start()
    {
        text = this.GetComponent<TextMesh>();
        text.text = heightStr;
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Physics.Raycast(hillThing.transform.position, Vector3.down, out hit))
        {
            var heightOfGround = hit.point.y;
            var hillTop = hillThing.transform.position.y;
            var height = hillTop - heightOfGround;

            text.text = heightStr + height;
        }
        else
        {
            text.text = "Error. Hilltop below ground.";
        }
	}
}
