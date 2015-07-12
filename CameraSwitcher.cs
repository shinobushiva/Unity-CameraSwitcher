using UnityEngine;
using System.Collections;

namespace Shiva.CameraSwitch{
	public class CameraSwitcher :  MonoBehaviour
	{
		
		public SwitchableCamera[] cameras;
		[HideInInspector]
		public SwitchableCamera currentActive;

		void Start ()
		{
			foreach (SwitchableCamera sc in cameras) {
					sc.On(false);
			}
			cameras [0].On (true);
			currentActive = cameras [0];

		}

		void Update(){
		
		}
		
		public void Switch (SwitchableCamera c)
		{ 
			print ("Switch:" + c.gameObject);
			currentActive = c;

			foreach (SwitchableCamera sc in cameras) {
				if(sc == c){
					sc.On(true);
				}else{
					sc.On(false);
				}
			}

		}
	}
}