using UnityEngine;
using System.Collections;

/// <summary>
/// Destroys a legacy particle system by its ParticleEmitter energy.
/// </summary>
public class SelfDestroyEnergy : MonoBehaviour {
    float timeDestroy;

	void Start () {
        var energy = GetComponent<ParticleEmitter>().maxEnergy;
        timeDestroy = Time.time + energy;

        //print("Destroying at " + timeDestroy.ToString());
	}
	
	void Update () {
        if (Time.time >= timeDestroy)
        {
            //print("Attempting to destroy");
            Destroy(this.gameObject);
        }
	}
}
