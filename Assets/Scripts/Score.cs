using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
    public static int PlayerScore = 0;
    void OnParticleCollision(GameObject other)
    {
        Debug.Log("particle hit");
        transform.GetComponent<MeshRenderer>().material.color = other.GetComponent<ParticleSystemRenderer>().material.color;
        PlayerScore++;
        
    }
}
