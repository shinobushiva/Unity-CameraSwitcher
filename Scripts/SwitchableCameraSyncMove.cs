using UnityEngine;
using System.Collections;
using Shiva.CameraSwitch;

public class SwitchableCameraSyncMove : MonoBehaviour {
	
	public Vector3 offset;
	public Vector3 rotation;

	public CameraSwitcher switcher;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void LateUpdate () {
		transform.position = switcher.CurrentActive.transform.position+offset;
		transform.rotation = switcher.CurrentActive.transform.rotation;
		Quaternion q = transform.rotation;
		Vector3 ang = q.eulerAngles;
		ang += rotation;
		q.eulerAngles = ang;
		transform.rotation = q;
	}
}