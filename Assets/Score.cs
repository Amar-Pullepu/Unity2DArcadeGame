using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
	public AudioClip coincollectionsound;
	PlayerController _inst;
	// Use this for initialization
	void Start () {
		_inst = GameObject.FindGameObjectWithTag ("_inst").GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D Obj){
		if (Obj.gameObject.tag != "Bord") {
			GameObject.Find ("Dragon").GetComponent<AudioSource> ().PlayOneShot (coincollectionsound);
			_inst.SendMessage ("IncScore");
			Destroy (gameObject);
		}
	}
}
