using UnityEngine;
using System.Collections;

public class ship : MonoBehaviour {

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

	}

}
