using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour
{

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("particle hit");
        transform.GetComponent<Renderer>().material.color = other.GetComponent<ParticleSystemRenderer>().material.color;
        
        
    }
}
