using UnityEngine;
using System;


public class MidiInputManager : MonoBehaviour, IInputManager
{
    public event EventHandler PianoKeyDown;

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
