using UnityEngine;
using System.Collections;

/// <summary>
/// Used to spawn different particle effects from prefabs for different key pitches.
/// </summary>
public class ParticleScriptSpawnEffector : MonoBehaviour, IEffector {
    public ParticleSystem bangSpawn;

    // May be used to generate continous effects when keys are held down.
    // Not yet implemented.
    public enum SpawnType
    {
        Once,
        //Continuous
    };
    public SpawnType spawnType = SpawnType.Once;

    public float randomRadius = 10;

    public void keyDownEffect(PianoKeyEventArgs ka)
    {
        randomSpawnParticle(bangSpawn, ka.key.pitch);
    }

    /// <summary>
    /// Spawns the particle system randomly inside a sphere of size
    /// randomRadius and centered on this object.
    /// </summary>
    public void randomSpawnParticle(ParticleSystem ps, Pitch pitch)
    {
        Vector3 randOffset = Random.insideUnitSphere * randomRadius;
        Vector3 center = this.transform.position;
        ParticleSystem tempParticles =
            Instantiate(ps, center + randOffset, Quaternion.identity) as ParticleSystem;
        tempParticles.startColor = NoteDecorator.pitchToColor(pitch);
    }


    // For testing only, don't intend particles to spawn on intervals.
    public void intervalEffect(IntervalEventArgs i) { }
}
