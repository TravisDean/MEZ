using UnityEngine;
using System;

public interface IInputManager
{
    event EventHandler PianoKeyDown;
    void pianoKeyDown();
}