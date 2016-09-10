using UnityEngine;
using System.Collections;
using Shiva.CameraSwitch;
using UnityStandardAssets.Utility;

public class MouseCameraMove : MonoBehaviour {

	public Transform target;

	private Vector3 mPos;
	private SwitchableCamera switchCamera;
	private SmoothFollow follow;
	private float damping = 0;

	void Start(){
		switchCamera = GetComponent<SwitchableCamera>();
		follow = GetComponent<SmoothFollow>();
//		damping = follow.rotationDamping;
	}

	// Update is called once per frame
	void Update () {
		
		if(!SystemWide.Instance.CanCameraGetMouseInput()){
//			follow.rotationDamping = damping;
			return;
		}

		if (!switchCamera.isMain)
			return;


		if(Input.GetMouseButtonDown(0)){
			mPos = Input.mousePosition;
//			damping = follow.rotationDamping;
//			follow.rotationDamping =  100f;
		}

		if(Input.GetMouseButton(0)){
			Vector3 v = Input.mousePosition - mPos;
			target.Rotate (-Vector3.up * 360 * 2 *  v.x / Screen.width);
			mPos = Input.mousePosition;
		}

		if(Input.GetMouseButtonUp(0)){
//			follow.rotationDamping = damping;
		}
	}
}
