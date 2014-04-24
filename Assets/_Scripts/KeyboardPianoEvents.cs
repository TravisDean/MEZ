using UnityEngine;
using System;

/// <summary>
/// Allows simulation of one octave of the piano via the keyboard.
/// Q->U   +   #s above for sharps
/// </summary>
public class KeyboardPianoEvents : MonoBehaviour, IPianoEvents
{
    public event EventHandler PianoKeyDown;

    public void Update()
    {
        if (Input.GetAxisRaw("Fire2") > 0)
        {
            pianoKeyDown();
            Input.ResetInputAxes();
        }
        if (Input.GetKeyDown("q"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(PianoKey.Pitch.C)));
        }
        if (Input.GetKeyDown("2"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(PianoKey.Pitch.Cs)));
        }
        if (Input.GetKeyDown("w"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(PianoKey.Pitch.D)));
        }
        if (Input.GetKeyDown("3"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(PianoKey.Pitch.Ds)));
        }
        if (Input.GetKeyDown("e"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(PianoKey.Pitch.E)));
        }
        if (Input.GetKeyDown("r"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(PianoKey.Pitch.F)));
        }
        if (Input.GetKeyDown("5"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(PianoKey.Pitch.Fs)));
        }
        if (Input.GetKeyDown("t"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(PianoKey.Pitch.G)));
        }
        if (Input.GetKeyDown("6"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(PianoKey.Pitch.Gs)));
        }
        if (Input.GetKeyDown("y"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(PianoKey.Pitch.A)));
        }
        if (Input.GetKeyDown("7"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(PianoKey.Pitch.As)));
        }
        if (Input.GetKeyDown("u"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(PianoKey.Pitch.B)));
        }


    }

    // Probably can condense this with lambdas and such. Will be useful in future.
    public void pianoKeyDown()
    {
        OnPianoKeyDown(new EventArgs());
    }

    public void pianoKeyDown(PianoKeyEventArgs k)
    {
        if (PianoKeyDown != null) PianoKeyDown(this, k);
    }

    public void OnPianoKeyDown(EventArgs e)
    {
        if (PianoKeyDown != null)
            PianoKeyDown(this, e);
    }
}
