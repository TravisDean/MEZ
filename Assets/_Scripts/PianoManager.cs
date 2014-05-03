using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Text;

/// <summary>
/// Connects the input device to the various effectors that will
/// be made to respond to piano events.
/// Swap input type with End.
/// </summary>
public class PianoManager : MonoBehaviour
{
    public enum InputType
    {
        MIDI,
        Keyboard
    };
    public InputType inputType;

    // IContainer is for Unity Editor support of IUnified.
    public IEffectorContainer keyEffectContainer;
    private IEffector keyEffector;

    public IEffectorContainer intervalEffectContainer;
    private IEffector intervalEffector;

    private IPianoEvents musicEvents;
    private MidiPianoEvents midiEventer;
    private KeyboardPianoEvents keyboardEventer;

    public void Start()
    {
        // Add the event managers.
        midiEventer = gameObject.AddComponent<MidiPianoEvents>() as MidiPianoEvents;
        keyboardEventer = gameObject.AddComponent<KeyboardPianoEvents>() as KeyboardPianoEvents;

        // Make the input manager the correct type.
        setInputType();

        // Setup Unity interface container workarounds.
        keyEffector = keyEffectContainer.Result;
        intervalEffector = intervalEffectContainer.Result;

        debug();

    }


    public void Update()
    {
        // Swap between MIDI and keyboard type input
        if (Input.GetKeyDown(KeyCode.End))
        {
            if (inputType == InputType.MIDI)
                inputType = InputType.Keyboard;
            else if (inputType == InputType.Keyboard)
                inputType = InputType.MIDI;
            else
                throw new Exception("Invalid input type.");
            setInputType();
        }
    }

    // Called when input type changes.
    private void setInputType()
    {
        switch (inputType)
        {
            case InputType.MIDI:
                musicEvents = midiEventer;
                break;
            case InputType.Keyboard:
                musicEvents = keyboardEventer;
                break;
            default:
                throw new Exception("Unsupported input type.");
        }
        setupEventHandlers();
    }

    // Add the events that we wish to respond to here
    private void setupEventHandlers()
    {
        // So we don't have two redundant listeners
        musicEvents.clearHandlers();
        musicEvents.PianoKeyDown += new EventHandler<PianoKeyEventArgs>(pianoKeyDown);
        musicEvents.IntervalPlayed += new EventHandler<IntervalEventArgs>(intervalPlayed);
    }


    // Call the handling methods here. Effector generalizes from input -> output.
    public void pianoKeyDown(object source, PianoKeyEventArgs k)
    {
        keyEffector.keyDownEffect(k);
    }

    private int? lastInterval = null;
    public void intervalPlayed(object source, IntervalEventArgs i)
    {
        keyEffector.intervalEffect(i);
        intervalEffector.intervalEffect(i);
        lastInterval = i.intervalFrequency;
    }

    // Debugging and general info ToString
    public new string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Input type: " + inputType.ToString());
        sb.AppendLine("Last interval: " + lastInterval.ToString());
        return sb.ToString();
    }

    private void debug()
    {
        // Test call to piano key down
        musicEvents.pianoKeyDown(new PianoKeyEventArgs(new PianoKey(60)));

        // Debugging statements.
        print("Version: " + Environment.Version.ToString());
        var key = new PianoKey(Pitch.C, 4, 0.4f);
        print("Test: 60   ? = ?   " + key.midiCode.ToString());
        print("Running test methods.");
        PianoKey.TestMIDIMethods();

        //print("Testing .NET and C# features. Next - LINQ");

        //int[] ints = { 1, 2, 3, 4, 5 };
        //var q = from i in ints
        //        select new { i };
        //foreach (var v in q)
        //{
        //    Debug.Log(v);
        //}
    }
}
