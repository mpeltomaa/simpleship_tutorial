using UnityEngine;
using System.Collections;

public class diamond : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		Destroy (gameObject);
	}
}
