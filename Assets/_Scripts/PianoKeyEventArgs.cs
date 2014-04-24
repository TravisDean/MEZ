using System;

/// <summary>
/// Contains the key that was pressed to pass with the event.
/// </summary>
public class PianoKeyEventArgs : EventArgs
{
    public PianoKey key { get; private set; }

    public PianoKeyEventArgs(PianoKey k)
    {
        key = k;
    }
}
