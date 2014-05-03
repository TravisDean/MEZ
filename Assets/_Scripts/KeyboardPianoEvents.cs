using UnityEngine;
using System;

/// <summary>
/// Allows simulation of one octave of the piano via the keyboard.
/// Q->U   +   #s above for sharps
/// </summary>
public class KeyboardPianoEvents : PianoEvents
{
    public void Update()
    {
        if (Input.GetAxisRaw("Fire2") > 0)
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(60)));
            Input.ResetInputAxes();
        }
        if (Input.GetKeyDown("q"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(Pitch.C)));
        }
        if (Input.GetKeyDown("2"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(Pitch.Cs)));
        }
        if (Input.GetKeyDown("w"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(Pitch.D)));
        }
        if (Input.GetKeyDown("3"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(Pitch.Ds)));
        }
        if (Input.GetKeyDown("e"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(Pitch.E)));
        }
        if (Input.GetKeyDown("r"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(Pitch.F)));
        }
        if (Input.GetKeyDown("5"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(Pitch.Fs)));
        }
        if (Input.GetKeyDown("t"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(Pitch.G)));
        }
        if (Input.GetKeyDown("6"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(Pitch.Gs)));
        }
        if (Input.GetKeyDown("y"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(Pitch.A)));
        }
        if (Input.GetKeyDown("7"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(Pitch.As)));
        }
        if (Input.GetKeyDown("u"))
        {
            pianoKeyDown(new PianoKeyEventArgs(new PianoKey(Pitch.B)));
        }
    }
}
