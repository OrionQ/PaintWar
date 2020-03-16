using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour {
	public ParticleSystem part;
	public List<ParticleCollisionEvent> collisionEvents;
    public AudioClip pop;
    void Start()
	{
			part = GetComponent<ParticleSystem>();
			collisionEvents = new List<ParticleCollisionEvent>();
        GetComponent<AudioSource>().playOnAwake = false;
    }


	void OnParticleCollision(GameObject other) {
			 GameManager.Score(this.gameObject.name, other.name);
        GetComponent<AudioSource>().Play();

    }
}
