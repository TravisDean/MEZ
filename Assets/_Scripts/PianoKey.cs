using System;
using System.Collections.Generic;

/// <summary>
/// Basic class containing information about which key was pressed
/// and how hard it was hit.
/// </summary>
public class PianoKey
{
    public enum Pitch
    {
        A,
        As,
        B,
        C,
        Cs,
        D,
        Ds,
        E,
        F,
        Fs,
        G,
        Gs
    }

    public Pitch pitch {get; private set; } 
    public int octave {get; private set; } 
    public float force {get; private set; }

    public PianoKey(Pitch p, int oct = 4, float f = 0.3f)
    {
        pitch = p;
        octave = oct;
        force = f;
    }
}
