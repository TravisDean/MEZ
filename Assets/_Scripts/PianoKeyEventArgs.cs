using System;

/// <summary>
/// Contains information about the pressed key.
/// </summary>
public class PianoKeyEventArgs : EventArgs
{
    public PianoKey key { get; private set; }

    public PianoKeyEventArgs(PianoKey k)
    {
        key = k;
    }
}
