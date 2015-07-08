using UnityEngine;
using System.Collections;

public class MoveMe : MonoBehaviour
{
	public float speed = 1f;
	public float acceleration = 2f;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		//if (Input.GetKey (KeyCode.A)) 
		//	this.transform.position += -Vector3.right * Time.deltaTime;

		//if (Input.GetKey (KeyCode.D)) 
		//	this.transform.position += Vector3.right * Time.deltaTime;
		var currentSpeed = speed;
		if (Input.GetKey (KeyCode.Space))
			currentSpeed *= acceleration;

		if (Input.GetKey (KeyCode.D)) 
			this.transform.rotation *= Quaternion.AngleAxis (10f * Time.fixedDeltaTime * currentSpeed, Vector3.up);

		if (Input.GetKey (KeyCode.A)) 
			this.transform.rotation *= Quaternion.AngleAxis (-10f * Time.fixedDeltaTime * currentSpeed, Vector3.up);






		var newPosition = this.transform.position;
		if (Input.GetKey (KeyCode.W)) 
			newPosition = this.transform.position + (this.transform.forward * Time.fixedDeltaTime * currentSpeed);

		this.transform.position = Vector3.Lerp (this.transform.position, newPosition, 0.5f);
	}
}
