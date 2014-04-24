using UnityEngine;
using System;

/// <summary>
/// All effects responding to key presses, either directly or
/// at a higher level, use this interface.
/// </summary>
public interface IEffector
{
    void pianoKeyDown();
    void pianoKeyDown(PianoKeyEventArgs k);
}

public class Effector : MonoBehaviour
{
    public IEffector Interface
    {
        get { return _interface.Result; }
        set { _interface.Result = value; } 
    }

    [SerializeField]
    private IEffectorContainer _interface;
}

[Serializable]
public class IEffectorContainer : IUnifiedContainer<IEffector> { }
