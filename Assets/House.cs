using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour {
	public AudioClip coincollectionsound;
	public AudioClip Clicksound;
	public GameObject GameCompletedPanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D Obj){
		gameObject.GetComponent<AudioSource> ().PlayOneShot (coincollectionsound);
		GameCompletedPanel.gameObject.SetActive (true);
		Obj.gameObject.SetActive (false);
	}
	public void Re_Start() {
		gameObject.GetComponent<AudioSource> ().PlayOneShot (Clicksound);
		Application.LoadLevel ("Scean1");
	}
	public void MainMenu() {
		gameObject.GetComponent<AudioSource> ().PlayOneShot (Clicksound);
		Application.LoadLevel ("Scean0");
	}
}
