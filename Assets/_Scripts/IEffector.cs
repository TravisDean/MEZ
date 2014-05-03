using UnityEngine;
using System;

/// <summary>
/// All effects responding to key presses, either directly or
/// at a higher level, use this interface.
/// Interface methods are implemented in various classes based off
/// of Effector.
/// </summary>
public interface IEffector
{
    void keyDownEffect(PianoKeyEventArgs k);
    void intervalEffect(IntervalEventArgs i);
}

/// <summary>
/// Base class for interface. Part of workaround using IUnited,
/// which facilitates editor interface support.
/// </summary>
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
