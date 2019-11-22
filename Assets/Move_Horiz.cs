using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Horiz : MonoBehaviour {
	private Vector2 Startpos;
	public float Speed;
	public float len;
	// Use this for initialization
	void Start () {
        Startpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 v = Startpos;
		v.y += (float)(len) * Mathf.Sin (Time.time * Speed);
		transform.position = v;
	}
}
