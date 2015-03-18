using UnityEngine;
using System.Collections;

public class MovePionRed : MonoBehaviour {

	public Rigidbody Possibility;

	void OnMouseDown ()
	{
		float posX = this.gameObject.position.x;
		float posY = this.gameObject.position.y;
		Debug.Log (posY + " " + posX);

		Rigidbody clone;
		clone = Instantiate(Possibility, transform.position, Quaternion.Euler ( 90, 0, 0 ) ) as Rigidbody;
	}
}
