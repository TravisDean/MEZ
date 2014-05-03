using UnityEngine;
using System.Collections;

public class MakeMeshFlows : MonoBehaviour, IEffector
{
    public GameObject legacyParticleSystem;
    public int spawns = 4;
    public float forceAffectSize = 2;
    public float forceAffectNum = 4;

    private MaterialPropertyBlock matBlock;
    private int colorId;
    void Start()
    {
        matBlock = new MaterialPropertyBlock();
        colorId = Shader.PropertyToID("_TintColor");
        //for (int i = 33; i <= 103; i += 10)
        //{
        //    print("midi: " + i + " -> " + NoteDecorator.midiToDegree(i, 90));
        //}
    }

    public void keyDownEffect(PianoKeyEventArgs k)
    {
        meshMake(k.key);
    }

    private void meshMake(PianoKey pianoKey)
    {
        Color c = NoteDecorator.pitchToColor(pianoKey.pitch);
        matBlock.Clear();
        matBlock.AddColor(colorId, c);

        int degree = 360 / spawns;
        for (int iter = 0; iter < spawns; iter++)
        {
            var pos = transform.position; 
            var rot = transform.rotation;
            GameObject obj = Instantiate(legacyParticleSystem, pos, rot) as GameObject;
            obj.transform.RotateAround(pos, rot * Vector3.up,
                NoteDecorator.midiToDegree(pianoKey.midiCode, degree) + iter * degree);
            
            ParticleRenderer pr = obj.GetComponent<ParticleRenderer>();
            pr.SetPropertyBlock(matBlock);

            float f = pianoKey.force;
            ParticleEmitter pe = obj.GetComponent<ParticleEmitter>();
            pe.maxSize *= forceAffectSize * f;
            pe.maxEmission *= forceAffectNum * f;

            obj.SetActive(true);
        }

    }

    public void intervalEffect(IntervalEventArgs i) { }
}
