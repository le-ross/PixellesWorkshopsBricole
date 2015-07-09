using UnityEngine;
using System.Collections;

public class LightDimmer : MonoBehaviour
{
		
	// Update is called once per frame
	void Update ()
	{
		var light = this.GetComponent<Light> ();
		light.color = Color.Lerp (light.color, Color.black, 0.1f);
	}

	void OnTriggerStay (Collider other)
	{
		var light = this.GetComponent<Light> ();
		light.color = Color.Lerp (light.color, Color.white, 0.1f);
	}
}
