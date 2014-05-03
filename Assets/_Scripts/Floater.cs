using UnityEngine;
using System.Collections;

/// <summary>
/// Scripted control of note event effect Floater.
/// Accelerates / moves upward.
/// Leaves trail behind.
/// Responsive to note properties, hopefully .
///
/// Not used in current demo.
/// </summary>

[RequireComponent(typeof(TrailRenderer))]
[RequireComponent(typeof(Rigidbody))]
public class Floater : MonoBehaviour
{
    //public int forceMod = 10;
    //private TrailRenderer trail;

    //void Start()
    //{
    //    trail = this.GetComponent<TrailRenderer>();

    //    //launchUp();
    //    //Invoke("launchUp", 0.1f);
    //    Invoke("launchUp", 0.0f);
    //}

    //public void Init(Color c)
    //{
    //    trail.material.SetColor("_TintColor", c);
    //}

    //private void launchUp()
    //{
    //    //rigidbody.AddForce(Vector3.up * forceMod, ForceMode.Impulse);
    //    rigidbody.velocity += new Vector3(0, 10, 0);
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //        launchUp();
    //}
}
