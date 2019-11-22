using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movemnt : MonoBehaviour {
	Vector2 Startpos;
	public float Speed,len;
	// Use this for initialization
	void Start () {
		Startpos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 v = Startpos;
		if (Mathf.Sin (Time.time * Speed) <0) {
			transform.eulerAngles = new Vector3 (0, 180, 0);
		} else if(Mathf.Sin (Time.time * Speed) >0){
			transform.eulerAngles = new Vector3 (0, 0, 0);
		}
		v.x += (float)(len) * Mathf.Sin (Time.time * Speed);
		transform.position = v;	
	}

}
