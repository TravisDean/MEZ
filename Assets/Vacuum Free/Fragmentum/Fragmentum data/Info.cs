// VacuumShaders 2014
// https://www.facebook.com/VacuumShaders

using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Info : MonoBehaviour 
{
    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Variables                                                                 //                
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////


    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Unity Functions                                                           //                
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnGUI()
    {
        GUILayout.FlexibleSpace();
        if (GUI.Button(new Rect(10, 10, 240, 65), "Fragmentum 2 is available.\n With SM2 and SM3 support.\nFor Mac, Linux, iOS and Android."))
        {
            Application.OpenURL("https://www.assetstore.unity3d.com/#/content/8264");
        }
        GUI.backgroundColor = Color.white;
    }
}
