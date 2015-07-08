using UnityEngine;
using System.Collections;

public class FollowOther : MonoBehaviour
{

	public GameObject other;
	public float HowHight = 10f;
	public float HowBehind = 5f;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		var newPosition = other.transform.position + new Vector3 (0f, HowHight, 0f) - (other.transform.forward * HowBehind);
		this.transform.position = Vector3.Lerp (this.transform.position, newPosition, 0.1f);

		this.transform.LookAt (other.transform.position);
	}
}
