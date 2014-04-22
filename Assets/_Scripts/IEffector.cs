using UnityEngine;
using System;

public interface IEffector
{
    void pianoKeyDown();
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
