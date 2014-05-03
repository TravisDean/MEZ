using UnityEngine;
using System.Collections;

/// <summary>
/// Automatic destruction of non-looping particle systems.
/// </summary>
[RequireComponent(typeof(ParticleSystem))]
public class ParticleSelfDestroy : MonoBehaviour {
    float timeDestroy;

    bool isLooping;
	void Start () {
        var duration = GetComponent<ParticleSystem>().duration;
        timeDestroy = Time.time + duration;

        isLooping = GetComponent<ParticleSystem>().loop;
        //print("Destroying at " + timeDestroy.ToString());
	}
	
	void Update () {
        // Break out immediately if the prefab is set to loop
        if (isLooping) return;
        
        if (Time.time >= timeDestroy)
        {
            //print("Attempting to destroy");
            Destroy(this.gameObject);
        }
	}
}
