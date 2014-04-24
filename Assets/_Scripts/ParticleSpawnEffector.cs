using UnityEngine;
using System.Collections;

/// <summary>
/// Used to spawn different particle effects for different keys.
/// </summary>
public class ParticleSpawnEffector : MonoBehaviour, IEffector {
    [SerializeField]
//    public ParticleSystem anyKeySpawn;
    public ParticleSystem keyA;
    public ParticleSystem keyAs;
    public ParticleSystem keyB;
    public ParticleSystem keyC;
    public ParticleSystem keyCs;
    public ParticleSystem keyD;
    public ParticleSystem keyDs;
    public ParticleSystem keyE;
    public ParticleSystem keyF;
    public ParticleSystem keyFs;
    public ParticleSystem keyG;
    public ParticleSystem keyGs;

    // May be used to generate continous effects when keys are held down.
    public enum SpawnType
    {
        Once,
        //Continuous
    };
    public SpawnType spawnType = SpawnType.Once;

    public float randomRadius = 10;

    // Originally used as a testing method. May be used
    // in the future for events that happen on all key presses,
    // but that functionality will probably end up in another class.
    public void pianoKeyDown()
    {
     //   randomSpawnParticle(anyKeySpawn);
    }

    public void pianoKeyDown(PianoKeyEventArgs k)
    {
        PianoKey key = k.key;
        switch (key.pitch)
        {
            case PianoKey.Pitch.A:
                randomSpawnParticle(keyA);
                break;
            case PianoKey.Pitch.As:
                randomSpawnParticle(keyAs);
                break;
            case PianoKey.Pitch.B:
                randomSpawnParticle(keyB);
                break;
            case PianoKey.Pitch.C:
                randomSpawnParticle(keyC);
                break;
            case PianoKey.Pitch.Cs:
                randomSpawnParticle(keyCs);
                break;
            case PianoKey.Pitch.D:
                randomSpawnParticle(keyD);
                break;
            case PianoKey.Pitch.Ds:
                randomSpawnParticle(keyDs);
                break;
            case PianoKey.Pitch.E:
                randomSpawnParticle(keyE);
                break;
            case PianoKey.Pitch.F:
                randomSpawnParticle(keyF);
                break;
            case PianoKey.Pitch.Fs:
                randomSpawnParticle(keyFs);
                break;
            case PianoKey.Pitch.Gs:
                randomSpawnParticle(keyGs);
                break;
            case PianoKey.Pitch.G:
                randomSpawnParticle(keyG);
                break;
        }
    }

    /// <summary>
    /// Spawns the particle system randomly inside a sphere of size
    /// randomRadius and centered on this object.
    /// </summary>
    /// <param name="ps"></param>
    public void randomSpawnParticle(ParticleSystem ps)
    {
        Vector3 randOffset = Random.insideUnitSphere * randomRadius;
        Vector3 center = this.transform.position;
        Instantiate(ps, center + randOffset, Quaternion.identity);
    }
}
