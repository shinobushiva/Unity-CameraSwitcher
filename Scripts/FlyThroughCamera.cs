using UnityEngine;
using System.Collections;

public class FlyThroughCamera : MonoBehaviour
{

	public float speed = 1f;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		float v = Input.GetAxis ("Vertical");
		float h = Input.GetAxis ("Horizontal");
		float a = Input.GetAxis ("Altitude");

		//print ("" + v + "," + h);

		transform.Translate (new Vector3 (h, a, v) * speed * Time.deltaTime);

	
	}
}
