using UnityEngine;
using System.Collections;

public class FollowOther : MonoBehaviour
{
	public GameObject other;
	public float HowHight = 10f;
	public float HowBehind = 5f;
	
	// Update is called once per frame
	void Update ()
	{
		// ici on calcule la position en arriere de other en utilisant le vecteur other.transform.forward
		var behindOther = (other.transform.forward * HowBehind * -1f);

		// on calcule la hauteur
		var highterPosition = new Vector3 (0f, HowHight, 0f);

		//tada la nouvelle position est l'addition de toute
		var newPosition = other.transform.position + highterPosition + behindOther;

		var currentPosition = this.transform.position;
		var rate = 0.01f;

		// Lerp permet de faire un smoothing entre currentPosition vers newPosition.
		// le rate va simplement etre le vitesse de smooth ( amuser vous entre les valeurs 0.01f et 0.1f )
		this.transform.position = Vector3.Lerp (currentPosition, newPosition, rate);

		// LookAt permet de regarder en direction d'une position simple et efficasse
		this.transform.LookAt (other.transform.position);
	}
}
