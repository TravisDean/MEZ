using UnityEngine;
using System;

public class UnityInputManager : MonoBehaviour, IInputManager
{
    public event EventHandler PianoKeyDown;

    public void Update()
    {
        if (Input.GetAxisRaw("Fire2") > 0)
        {
            pianoKeyDown();
            Input.ResetInputAxes();
        }
    }

    // Probably can condense this with lambdas and such. Will be useful in future.
    public void pianoKeyDown()
    {
        OnPianoKeyDown(new EventArgs());
    }

    void OnPianoKeyDown(EventArgs e)
    {
        if (PianoKeyDown != null)
            PianoKeyDown(this, e);
    }
}
