using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Guaranteed to be run after all items have been run in Update()
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
