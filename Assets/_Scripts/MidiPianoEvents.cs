using UnityEngine;
using System;
using System.Collections.Generic;

/// <summary>
/// Maps keyboard data to the correct keys.
/// </summary>
public class MidiPianoEvents : PianoEvents
{
    public void Update()
    {
        // For now, seems the best way to do this is to iterate over the entire array
        // every time and check for each. Seems it would be better to have this changed
        // when MidiInput changes, perhaps later..
        for (int midi = 0; midi < 128; midi++)
        {
            if (MidiInput.GetKeyDown(midi))
            {
                pianoKeyDown(new PianoKeyEventArgs(new PianoKey(midi)));
            }
            // TODO: implement for other effects.
            //if (MidiInput.GetKeyUp(midi))
            //{
            //    //pianoKeyUp(new PianoKeyEventArgs(getKeyFromMidi(i)));
            //}
        }
    }

}
