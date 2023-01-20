using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed;
	public float lives = 3;
	public string livesDisplay;
	
	public GameObject ScreenClear;
	
	// Update is called once per frame
	void Update () 
	{
		// move  
		if (this.transform.position.x < 3.2 && this.transform.position.x > -3.2 && this.transform.position.y < 4.2 && this.transform.position.y > -4.2)
		{
			if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (speed * Time.deltaTime, 0f, 0f);
			
			} 
			if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-speed * Time.deltaTime, 0f, 0f);
			
			}
			if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0f, speed * Time.deltaTime, 0f);
			
			} 
			if (Input.GetKey (KeyCode.DownArrow)) {	
			transform.Translate (0f, -speed * Time.deltaTime, 0f);
			
			}
		}
		//else {}

		if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift)) 
		{
			speed = 2;
		} 
		else 
		{
			speed = 6;
		}
		
		if (lives < 1)
		{
			Application.LoadLevel ("DeathScene");
		}
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Bullet(Clone)" || other.gameObject.name == "Enemy")
		{
			lives--;
			//Debug.Log (lives +"lives");
			//livesDisplay = "Lives: " + lives;
			
			GameObject clear = Instantiate 
				(ScreenClear) 
					as GameObject;
			
			Destroy (clear.gameObject, 1f);
			
			transform.position = new Vector3(0f, -2.5f);
		}
	}
	
	void OnGUI()
	{
		livesDisplay = GUI.TextField(new Rect(100, 20, 220, 20), "Lives: " + lives, 25);
	}
	
}

