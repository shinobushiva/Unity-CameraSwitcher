 using UnityEngine;
using System.Collections;

namespace Shiva.CameraSwitch{
	public class SwitchableCamera : MonoBehaviour
	{
		public Camera c;

		void Awake(){
		}
		
		void Start ()
		{
			if (c == null) {
				c = GetComponentInChildren<Camera>();
			}

			if (c == null) {
				print ("Could not find any camera in children. The component is destroied");
				Destroy(this);
			}

		}

		public void On(bool f){
			Behaviour[] mbs = GetComponentsInChildren<Behaviour> ();
			foreach (Behaviour mb in mbs) {
				if(mb == null)
					continue;

				mb.enabled = f;
			}
			//enabled = true;
		}
	 

	}
}