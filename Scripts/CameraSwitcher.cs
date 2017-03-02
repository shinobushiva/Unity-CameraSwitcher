using UnityEngine;
using System.Collections;

namespace Shiva.CameraSwitch{
	public class CameraSwitcher :  MonoBehaviour
	{
		
		public SwitchableCamera[] cameras;
//		[HideInInspector]
		private SwitchableCamera currentActive;

		public SwitchableCamera CurrentActive{
			get{
				if(currentActive == null){
					Switch(cameras[0]);
				}

				return currentActive;
			}
		}


		void Start ()
		{
			foreach (SwitchableCamera sc in cameras) {
					sc.On(false);
			}
			Switch (cameras [0]);
//			cameras [0].On (true);
//			currentActive = cameras [0];

		}


		void Update(){
		
		}
		
		public void Switch (SwitchableCamera c)
		{ 
			print ("Switch:" + c.gameObject);
			currentActive = c;


			foreach (SwitchableCamera sc in cameras) {
				if(sc == c){
					sc.isMain = true;
					sc.On(true);
				}else{
					sc.isMain = false;
					sc.On(false);
				}
			}

		}
	}
}