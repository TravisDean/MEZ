using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// Stores information related to the last musical interval played.
/// </summary>
public class IntervalEventArgs : EventArgs {

    public int intervalFrequency { get; private set; }
    public PianoKey lastKey { get; private set; }
    public PianoKey newKey { get; private set; }

    // public float timeBetween

    public IntervalEventArgs(PianoKey last, PianoKey next)
    {
        lastKey = last;
        newKey = next;
        intervalFrequency = next.midiCode - last.midiCode;
    }

}
