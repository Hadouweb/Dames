using UnityEngine;
using System.Collections;

public class MovePionRed : MonoBehaviour {

	public Rigidbody Possibility;

	void OnMouseDown ()
	{
		Debug.Log("Hello", gameObject);
		Rigidbody clone;
		clone = Instantiate(Possibility, transform.position, transform.rotation) as Rigidbody;
		clone.velocity = transform.TransformDirection(Vector3.forward * 10);
	}
}
