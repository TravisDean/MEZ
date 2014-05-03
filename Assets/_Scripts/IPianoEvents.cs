using UnityEngine;
using System;

/// <summary>
/// Interface that the input handlers implement for easy testing and
/// swapping between input types.
/// TODO: Encapsulate handlers in one collection?
/// </summary>
public interface IPianoEvents
{
    event EventHandler<PianoKeyEventArgs> PianoKeyDown;
    event EventHandler<IntervalEventArgs> IntervalPlayed;

    void pianoKeyDown(PianoKeyEventArgs k);
    void intervalPlayed(IntervalEventArgs i);

    void clearHandlers();
}

/// <summary>
/// Common functionality for input events.
/// </summary>
public class PianoEvents : MonoBehaviour, IPianoEvents
{
    public event EventHandler<PianoKeyEventArgs> PianoKeyDown;
    public event EventHandler<IntervalEventArgs> IntervalPlayed;

    private PianoKey lastKey = null;

    public void pianoKeyDown(PianoKeyEventArgs k)
    {
        if (PianoKeyDown == null) return;
        PianoKeyDown(this, k);

        if (lastKey != null) 
            intervalPlayed(new IntervalEventArgs(lastKey, k.key));
        lastKey = k.key;
    }

    public void intervalPlayed(IntervalEventArgs i)
    {
        if (IntervalPlayed == null) return;
        IntervalPlayed(this, i);
    }

    public void clearHandlers()
    {
        PianoKeyDown = null;
        IntervalPlayed = null;
    }

}