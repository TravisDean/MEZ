using UnityEngine;
using System.Collections;
using System;

public class InputManager : MonoBehaviour {
    public enum InputType
    {
        MIDI,
        Keyboard
    };
    public InputType inputType;

    public IEffectorContainer effectContainer;
    private IEffector effector;

    private IInputManager inputManager;

	public void Start () {
        // Make the input manager the correct type.
        // TODO: Extract to method, make responsive during program run.
        switch (inputType)
        {
            case InputType.MIDI:
                inputManager = gameObject.AddComponent<MidiInputManager>() as MidiInputManager;
                break;
            case InputType.Keyboard:
                inputManager = gameObject.AddComponent<UnityInputManager>() as UnityInputManager;
                break;
            default:
                throw new Exception("Unsupported input type.");
                break;
        }

        // Add the events that we wish to respond to here
        inputManager.PianoKeyDown += new EventHandler(pianoKeyDown);

        // Setup Unity interface container workaround
        effector = effectContainer.Result;

        // Test call to piano key down
        inputManager.pianoKeyDown();
        
	}

    // Call the handling methods here. Effector generalizes from input -> output.
    public void pianoKeyDown(object source, EventArgs e)
    {
        effector.pianoKeyDown();
    }
	
}
