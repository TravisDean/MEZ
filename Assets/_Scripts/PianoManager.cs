using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Connects the input device to the various effectors that will
/// be made to respond to piano events.
/// </summary>
public class PianoManager : MonoBehaviour {
    public enum InputType
    {
        MIDI,
        Keyboard
    };
    public InputType inputType;

    public IEffectorContainer effectContainer;
    private IEffector effector;

    private IPianoEvents musicEvents;

	public void Start () {
        // Make the input manager the correct type.
        // TODO: Extract to method, make responsive during program run.
        switch (inputType)
        {
            case InputType.MIDI:
                musicEvents = gameObject.AddComponent<MidiPianoEvents>() as MidiPianoEvents;
                break;
            case InputType.Keyboard:
                musicEvents = gameObject.AddComponent<KeyboardPianoEvents>() as KeyboardPianoEvents;
                break;
            default:
                throw new Exception("Unsupported input type.");
                break;
        }

        // Add the events that we wish to respond to here
        musicEvents.PianoKeyDown += new EventHandler(pianoKeyDown);

        // Setup Unity interface container workaround
        effector = effectContainer.Result;

        // Test call to piano key down
        //musicEvents.pianoKeyDown();
        
	}

    // Call the handling methods here. Effector generalizes from input -> output.
    public void pianoKeyDown(object source, EventArgs e)
    {
        if (e.GetType() == typeof(PianoKeyEventArgs))
        {
            PianoKeyEventArgs keyArgs = (PianoKeyEventArgs)e;
            effector.pianoKeyDown(keyArgs);
            return;
        }
        effector.pianoKeyDown();
    }
	
}
