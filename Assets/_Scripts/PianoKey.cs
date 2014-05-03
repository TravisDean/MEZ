using UnityEngine;
using System;
using System.Collections.Generic;

/// <summary>
/// Constructed every time a key is played.
/// Contains information about which key was pressed
/// and how hard it was hit.
/// </summary>
public class PianoKey
{
    public Pitch pitch { get; private set; }
    public int octave { get; private set; }
    public float force { get; private set; }
    public int midiCode { get; private set; }

    // Default constructor with default values.
    public PianoKey(Pitch pitch = Pitch.C, int octave = 4, float force = 0.3f)
    {
        this.pitch = pitch;
        this.octave = octave;
        this.force = force;

        var p = (int)pitch;
        midiCode = p + octave * 12 + 9;
    }

    // Returns a new piano code with the correct pitch and octave
    // from the MIDI code.
    public PianoKey(int midiCode = 60, float force = 0.3f)
    {
        this.pitch = pitchFromMidi(midiCode);
        this.octave = octaveFromMidi(midiCode);
        this.force = force;
        this.midiCode = midiCode;
    }

    // Returns octave value of given a MIDI code.
    protected static int octaveFromMidi(int midiCode)
    {
        for (int i = 0, pitchForce = 23; i <= 12; i++, pitchForce += 12)
        {
            if (midiCode <= pitchForce)
                return i;
        }
        return -1;
    }

    // Returns a member of the Pitch enum from a MIDI code.
    protected static Pitch pitchFromMidi(int midiCode)
    {
        // Will want to remove when reacting to synths.
        if (midiCode < 20 || midiCode > 108)
            throw new Exception("MIDI code outside piano range.");

        Dictionary<int, Pitch> pitchMapping = new Dictionary<int, Pitch>(12); // 12 pitch capacity

        for (int p = 0; p < 12; p++)
        {
            Pitch enumPitch = (Pitch)((p + 3) % 12);
            pitchMapping.Add(p, enumPitch);
        }

        return pitchMapping[midiCode % 12];
    }


    // Call to test varios MIDI methods and output the results
    // to Unity's console.
    public static void TestMIDIMethods()
    {
        bool t = assert<Pitch, Pitch>(Pitch.A, pitchFromMidi(21));
        Debug.Log("Pitch.A comes from 21, yes? " + t);

        // C4 = midi 60.
        t = assert<int, int>(4, octaveFromMidi(60));
        Debug.Log("Midi code of 60 gives octave 4, yes? " + t
            + "\n\t(midi)-60  (octave)-" + octaveFromMidi(60));

        PianoKey test = new PianoKey(Pitch.C, 4);
        t = assert<int, int>(60, test.midiCode);
        Debug.Log("C4 gives midi code of 60, yes? " + t
            + "\n\t(C4.Pitch) - " + test.pitch.ToString()
            + "\n\t(C4.Octave) - " + test.octave.ToString()
            + "\n\t(C4.Midi) - " + test.midiCode.ToString());

        //for (int i = 21; i < 69; i++)
        //{
        //    Debug.Log("\n(i) " + i.ToString() + " -> (pitch)" + pitchFromMidi(i));
        //    Debug.Log("(i) " + i.ToString() + " -> (octave)" + octaveFromMidi(i) + "\n");
        //}
    }

    // This should really exist somewhere easy to import, but this was easier.
    private static bool assert<T, U>(T t1, U t2)
    {
        return t1.Equals(t2);
    }
}

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