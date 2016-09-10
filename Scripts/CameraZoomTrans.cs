using UnityEngine;
using System.Collections;
using Shiva.CameraSwitch;

public class CameraZoomTrans : MonoBehaviour
{

	public Transform target;
	private Vector3 mPos;
	private SwitchableCamera switchCamera;
	//private SmoothFollow follow;
	//private float damping = 0;

	private Vector3 org;

	public float orgSize = 300;
	public float minSize = 100;
	public float maxSize = 300;
	public float zoomSpeed = 10;

	//
	private bool mouseDown = false;
	private Vector3 preMousePos;


	// Use this for initialization
	void Start ()
	{
		
		switchCamera = GetComponent<SwitchableCamera> ();
		org = transform.position;
		orgSize = GetComponent<Camera>().orthographicSize;

	}
	
	// Update is called once per frame
	void LateUpdate ()
	{

		if(!SystemWide.Instance.CanCameraGetMouseInput())
			return;

		if (!switchCamera.isMain)
			return;

		if(Input.GetMouseButtonDown(0)){
			mouseDown = true;
			preMousePos = Input.mousePosition;
		}

		if(Input.GetMouseButton(0)){
			Vector3 d = Input.mousePosition - preMousePos;

			preMousePos = Input.mousePosition;

			//d.z = d.y;
			d.z = 0;
			transform.Translate(-d);
		}

		if(Input.GetMouseButtonUp(0)){
			mouseDown = false;
		}
			
		if(Input.GetKey(KeyCode.A)){
			float s = GetComponent<Camera>().orthographicSize-zoomSpeed*Time.deltaTime;
			if(s > minSize){
				GetComponent<Camera>().orthographicSize = s;
			}else{
				GetComponent<Camera>().orthographicSize = minSize;
			}
		}

		if(Input.GetKey(KeyCode.B)){
			float s = GetComponent<Camera>().orthographicSize+zoomSpeed*Time.deltaTime;
			if(s < maxSize){
				GetComponent<Camera>().orthographicSize = s;
			}else{
				GetComponent<Camera>().orthographicSize = maxSize;
			}
		}

	}
}
