using UnityEngine;
using System.Collections;

public class ship : MonoBehaviour {

	public float fireSpeed = 1f;
	private float allowNextBullet;
	public GameObject bullet;

	void Update () {

		// Fire thrusters with key W
		if (Input.GetKey (KeyCode.W)) {
			GetComponent<Rigidbody2D> ().AddForce (transform.up * 10);
		}

		// Turn left with key A
		if (Input.GetKey(KeyCode.A))
		{
			GetComponent<Rigidbody2D>().AddTorque(1f);
		}

		// Turn right with key D
		if (Input.GetKey(KeyCode.D))
		{
			GetComponent<Rigidbody2D>().AddTorque(-1f);
		}

		if ((Input.GetKey(KeyCode.Space)) && Time.time > allowNextBullet)
		{
			allowNextBullet = Time.time + fireSpeed;
			Instantiate(bullet, (transform.position + new Vector3(0f,0.7f,0f)), transform.rotation);
		}
	}

}
