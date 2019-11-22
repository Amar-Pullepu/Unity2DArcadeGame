using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreBoard : MonoBehaviour {
	public Sprite[] sp;
	public GameObject soundbutton;
	public static int buttonclick=1;
	public AudioClip ButtonSound;
	public GameObject infobj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void click() {
		GameObject.Find ("GameLoader").GetComponent<AudioSource> ().PlayOneShot (ButtonSound, 5);
		if (buttonclick == 1) {
			buttonclick = 0;
			soundbutton.gameObject.GetComponent<Button> ().GetComponent<Image> ().sprite = sp [0];
			GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<AudioSource> ().mute = !GetComponent<AudioSource> ().mute;
		} 
		else {
			buttonclick = 1;
			soundbutton.gameObject.GetComponent<Button> ().GetComponent<Image> ().sprite = sp [1];
			GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<AudioSource> ().mute = GetComponent<AudioSource> ().mute;
		}
	}
	public void unhideinfo(){
		GameObject.Find ("GameLoader").GetComponent<AudioSource> ().PlayOneShot (ButtonSound, 5);
		infobj.gameObject.SetActive (true);
	}
	public void hideinfo() {
		GameObject.Find ("GameLoader").GetComponent<AudioSource> ().PlayOneShot (ButtonSound, 5);
		infobj.gameObject.SetActive (false);
	}
	public void loadgame() {
		GameObject.Find ("GameLoader").GetComponent<AudioSource> ().PlayOneShot (ButtonSound, 5);
		Application.LoadLevel ("Scean1");
	}
}
