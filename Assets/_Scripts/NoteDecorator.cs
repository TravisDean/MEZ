using UnityEngine;
using System;
using System.Collections.Generic;

/// <summary>
/// Provides a one-stop shop to all pretty things our effectors could
/// possibly need based on notes.
/// 
/// Values determined experimentely by what looked good.
/// </summary>
public static class NoteDecorator
{
    private static Dictionary<Pitch, Color> pitchColor;

    static NoteDecorator()
    {
        pitchColor = new Dictionary<Pitch, Color>();

        pitchColor.Add(Pitch.A, new Color(1f, 0f, 0f));     // Red
        pitchColor.Add(Pitch.As, new Color(1f, 0f, 0.56f));
        pitchColor.Add(Pitch.B, new Color(.66f, 0f, 1f));  // Purple
        
        pitchColor.Add(Pitch.C, new Color(.16f, 0f, 1f));
        pitchColor.Add(Pitch.Cs, new Color(0f, 0.53f, 1f));
        pitchColor.Add(Pitch.D, new Color(0f, 1f, 1f));    // Teal

        pitchColor.Add(Pitch.Ds, new Color(0f, 1f, 0.54f));
        pitchColor.Add(Pitch.E, new Color(0f, 1f, 0f));   // Green
        pitchColor.Add(Pitch.F, new Color(0.63f, 1f, 0f));

        pitchColor.Add(Pitch.Fs, new Color(1f, 1f, 0f));   // Yellow
        pitchColor.Add(Pitch.G, new Color(1f, 0.70f, 0f));
        pitchColor.Add(Pitch.Gs, new Color(1f, 0.43f, 0f));
    }

    public static Color pitchToColor(Pitch p)
    {
        return pitchColor[p];
    }

    /// <summary>
    /// Completely arbitrary mapping of my piano keys to slightly different 
    /// degrees for graphical display.
    /// </summary>
    public static float midiToDegree(int midi, int maxDegree)
    {
        const int low = 28;     // Lowest key on my piano
        const int high = 103;

        int diff = high - low;
        float map = (float)maxDegree / diff;
        float degree = (midi - low) * map;
        return degree;
    }
}