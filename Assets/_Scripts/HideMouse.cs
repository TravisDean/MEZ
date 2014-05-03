using UnityEngine;
using System.Collections;

/// <summary>
/// Give option to hide the mouse cursor.
/// </summary>
public class HideMouse : MonoBehaviour {
    public bool hideMouse = true;

	void Start () {
        if (hideMouse)
            Screen.showCursor = false;
	}
}
