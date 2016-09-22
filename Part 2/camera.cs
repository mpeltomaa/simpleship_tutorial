using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public GameObject ship;
	private Vector3 cameraOffset;

	void Start () {
		cameraOffset = transform.position - ship.transform.position;
	}
	
	void Update () {
		transform.position = ship.transform.position + cameraOffset;
	}
}
