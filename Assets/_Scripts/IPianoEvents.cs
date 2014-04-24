using UnityEngine;
using System;

/// <summary>
/// Interface that the input handlers implement for easy testing and
/// swapping between input types.
/// </summary>
public interface IPianoEvents
{
    event EventHandler PianoKeyDown;
    void pianoKeyDown();
}