using UnityEngine;
using System.Collections;

public class RotateWithMouse : MonoBehaviour
{

	Vector3 OnClickerMousePosition; 
	// Use this for initialization
	void Start ()
	{
		OnClickerMousePosition = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if (Input.GetMouseButtonDown (0))
			OnClickerMousePosition = Input.mousePosition;

		if (Input.GetMouseButtonUp (0))
			OnClickerMousePosition = Vector3.zero;


		if (OnClickerMousePosition == Vector3.zero)
			return;

		var d = OnClickerMousePosition - Input.mousePosition;

		if (d.x > 0) 
			this.transform.rotation *= Quaternion.AngleAxis (-10f * Time.fixedDeltaTime * 3, Vector3.up);
		
		if (d.x < 0) 
			this.transform.rotation *= Quaternion.AngleAxis (10f * Time.fixedDeltaTime * 3, Vector3.up);

	}
}
