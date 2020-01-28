using UnityEngine;

public class PlayerControl3D : MonoBehaviour
{
	public KeyCode moveUp = KeyCode.W;
	public KeyCode moveDown = KeyCode.S;
	public float speed = 10.0f;
	public float boundY = 2.25f;
	private Rigidbody rb2d;

	// Use this for initialization
	void Start()
	{
		rb2d = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		var vel = rb2d.velocity;
		if (Input.GetKey(moveUp))
		{
			vel.z = speed;
		}
		else if (Input.GetKey(moveDown))
		{
			vel.z = -speed;
		}
		else if (!Input.anyKey)
		{
			vel.z = 0;
		}
		rb2d.velocity = vel;

		var pos = transform.position;
		if (pos.y > boundY)
		{
			pos.y = boundY;
		}
		else if (pos.y < -boundY)
		{
			pos.y = -boundY;
		}
		transform.position = pos;
	}
}

