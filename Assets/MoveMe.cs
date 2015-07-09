using UnityEngine;
using System.Collections;

public class MoveMe : MonoBehaviour
{
	public float speed = 1f;
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		// pressed D
		if (Input.GetKey (KeyCode.D)) {
			this.transform.rotation = this.transform.rotation * Quaternion.AngleAxis (Time.fixedDeltaTime * speed * 4f, Vector3.up);
		}

		// pressed A
		if (Input.GetKey (KeyCode.A)) {
			this.transform.rotation = this.transform.rotation * Quaternion.AngleAxis (Time.fixedDeltaTime * speed * -4f, Vector3.up);
		}

		// Pressed W
		if (Input.GetKey (KeyCode.W)) {
			this.transform.position = this.transform.position + (this.transform.forward * Time.fixedDeltaTime * speed);
		}

	}
}
