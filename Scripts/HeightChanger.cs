using UnityEngine;
using System.Collections;

public class HeightChanger : MonoBehaviour {

	private CapsuleCollider cc;

	[System.Serializable]
	public class CapsuleSet{
		public float radius;
		public float height;
	}

	public CapsuleSet[] set;


	// Use this for initialization
	void Start () {
		cc = GetComponent<CapsuleCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetCapsuleSize(int num){
		if(num < 0 || num >= set.Length)
			return;

		GetComponent<Rigidbody> ().isKinematic = true;

		CapsuleSet cs = set [num];
		cc.height = cs.height;
		cc.radius = cs.radius;

		//transform.Translate (Vector3.up * cs.height);

		GetComponent<Rigidbody> ().isKinematic = false;

	}
}
