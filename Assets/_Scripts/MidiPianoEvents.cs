using UnityEngine;
using System;

/// <summary>
/// Will map keyboard data to the correct keys.
/// Still TODO.
/// </summary>
public class MidiPianoEvents : MonoBehaviour, IPianoEvents
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
