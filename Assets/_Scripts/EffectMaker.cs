using UnityEngine;
using System.Collections;

public class EffectMaker : MonoBehaviour, IEffector {
    public ParticleSystem spawn;

    public enum SpawnType
    {
        Once,
        //Continuous
    };
    public SpawnType spawnType = SpawnType.Once;

    public float randomRadius = 5;

    public void pianoKeyDown()
    {
        Vector3 randOffset = Random.insideUnitSphere * randomRadius;
        Vector3 center = this.transform.position;
        Instantiate(spawn, center + randOffset, Quaternion.identity);
    }
}
