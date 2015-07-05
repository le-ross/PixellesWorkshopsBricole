using UnityEngine;
using System.Collections;

public class ChangeColorOnDirection : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		var light = this.GetComponent<Light> ();


		var redChannel = Mathf.Abs (this.transform.position.x);
		var greenChannel = Mathf.Abs (this.transform.position.y - 2f);
		var blueChannel = Mathf.Abs (this.transform.position.z);
		light.color = new Color (redChannel, greenChannel, blueChannel);

	}
}
