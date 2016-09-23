using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	void Update () {
		transform.Translate(Vector2.up * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other) {
		Destroy (gameObject);
	}

}
