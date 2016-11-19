using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{
	public float rotateSpeed;

	void Update()
	{
		transform.Rotate (new Vector3 (0, 0, 45 * rotateSpeed) * Time.deltaTime);
	}
}
