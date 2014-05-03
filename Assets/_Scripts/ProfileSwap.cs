using UnityEngine;
using System.Collections;

/// <summary>
/// Allows run-time changes in visual display effects.
/// F1, F2, F3: change visual intensity
/// F5: disable rotational movement in world.
/// </summary>
public class ProfileSwap : MonoBehaviour {
    public bool rotate = true;

    public enum Profile
    {
        Tame,
        Normal,
        Crazy
    }
    public Profile profile; 

    RotateAroundCenter rotater;
    MakeMeshFlows pianoRoller;
    void Awake()
    {
        rotater = GameObject.FindObjectOfType<RotateAroundCenter>();
        pianoRoller = GameObject.FindObjectOfType<MakeMeshFlows>();
    }
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            profileSet(Profile.Tame);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            profileSet(Profile.Normal);
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            profileSet(Profile.Crazy);
        }
	    if (Input.GetKeyDown(KeyCode.F5))
        {
            rotate = !rotate;
            rotater.transform.position = Vector3.zero;
            rotater.transform.rotation = Quaternion.identity;
            rotater.enabled = rotate;
        }
	}

    private void profileSet(Profile p)
    {
        profile = p;
        switch (profile)
        {
            case Profile.Tame:
                pianoRoller.spawns = 1;
                pianoRoller.forceAffectNum = 1;
                break;
            case Profile.Normal:
                pianoRoller.spawns = 2;
                pianoRoller.forceAffectNum = 3;
                break;
            case Profile.Crazy:
                pianoRoller.spawns = 4;
                pianoRoller.forceAffectNum = 5;
                break;
        }
    }
}
