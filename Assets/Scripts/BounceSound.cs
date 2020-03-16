using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSound : MonoBehaviour
{
    public AudioClip bounce;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
    }

    // Update is called once per frame
    void OnParticleCollision(GameObject other)
    {
        GetComponent<AudioSource>().Play();

    }
}
