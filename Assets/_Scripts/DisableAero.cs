using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

/// <summary>
/// Disabling Aero desktop composition reduces latency by ~16ms.
/// </summary>
public class DisableAero : MonoBehaviour {
    public bool disableAero = true;

    [DllImport("dwmapi.dll", EntryPoint = "DwmEnableComposition")]
    extern static uint DwmEnableComposition(uint compositionAction);

    public void Awake()
    {
        if (disableAero)
            DwmEnableComposition(0);
    }
}
