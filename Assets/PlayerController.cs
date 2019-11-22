using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour {
	private Animator anim;
    private Vector2 v;
	public float speed,jumpforce;
	bool grounded;
	static int Score=0,Lives;
	public Text MyScore,MyLives;
	public Transform groundCheck;
	public GameObject GameOverPanel,GameOverPanel2,dragon;

	// Use this for initialization
	void Start () {
        v = transform.position;
		Lives = 10;
		GameOverPanel.gameObject.SetActive (false);

		dragon.gameObject.SetActive (true);

		GameOverPanel2.gameObject.SetActive (false);
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Lives == 0) {
			GameOverPanel.gameObject.SetActive (true);
			gameObject.SetActive (false);
		}
        if (Input.GetKey(KeyCode.Space) && grounded && gameObject.GetComponent<Rigidbody2D>().velocity.y < 0.1f && gameObject.GetComponent<Rigidbody2D>().velocity.y > -0.1f)
        {
            grounded = false;
            anim.Play("JUMPANIM");
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, jumpforce, 0));
        }
        if (Input.GetKey (KeyCode.RightArrow)) {
			transform.eulerAngles = new Vector3 (0, 0, 0);
			anim.Play ("WALKANIM");
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, gameObject.GetComponent<Rigidbody2D> ().velocity.y);
		} if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.eulerAngles = new Vector3 (0, 180, 0);
			anim.Play ("WALKANIM");
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, gameObject.GetComponent<Rigidbody2D> ().velocity.y);

		} 
	}
	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Bord") {
			GameOverPanel.gameObject.SetActive (true);
		} else if (col.gameObject.tag == "Enemy") {
            transform.position = v;
			DecLife ();
		} 
		else if (col.gameObject.tag == "Life") {
			Destroy (col.gameObject);
			IncLife ();
		} 
		else {
			anim.Play ("IDLEANIM");
		}

	}
    void OnCollisionStay2D(Collision2D col)
    {
        grounded = true;
    }
    void OnCollisionExit2D(Collision2D col)
    {
        grounded = false;
    }
    void IncScore() {
		Score += 1;
		MyScore.text=Score.ToString();
	}
	void DecLife(){
		Debug.Log ("Life Decresed");
		Lives -= 1;
		MyLives.text = Lives.ToString ();
	}
	void IncLife(){
		Lives += 1;
		MyLives.text = Lives.ToString ();
	}

}
