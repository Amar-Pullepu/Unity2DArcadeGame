using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMovw : MonoBehaviour {
	public GameObject Obj;
	Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - Obj.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Obj.transform.position.x + offset.x, transform.position.y, transform.position.z);
	}
}
