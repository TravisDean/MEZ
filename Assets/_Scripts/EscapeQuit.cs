using UnityEngine;
using System.Collections;

/// <summary>
/// Quit application when Escape is pressed.
/// </summary>
public class EscapeQuit : MonoBehaviour
{
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}