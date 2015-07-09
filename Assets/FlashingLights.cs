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

		// on boucle pour l'infinie
		while (true) {

			// on boucle tant que on est plus gros que le min
			while (light.intensity > minLight) {
				light.intensity -= 0.5f;
				yield return new WaitForSeconds (0.01f);
			}

			// on boucle tant que on est plus petit que le max
			while (light.intensity < maxLight) {
				light.intensity += 0.5f;
				yield return new WaitForSeconds (0.01f);
			}

		}
	}
}
