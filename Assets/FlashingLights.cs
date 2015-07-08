using UnityEngine;
using System.Collections;

public class FlashingLights : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
		StartCoroutine (FlashThatLight ());
	}
	
	IEnumerator FlashThatLight ()
	{
		var light = this.GetComponent<Light> ();
		var minLight = 1f;
		var maxLight = 8f;

		while (true) {

			while (light.intensity > minLight) {
				light.intensity -= 0.5f;
				yield return new WaitForSeconds (0.01f);
			}

			while (light.intensity < maxLight) {
				light.intensity += 0.5f;
				yield return new WaitForSeconds (0.01f);
			}
		}
	}
}
