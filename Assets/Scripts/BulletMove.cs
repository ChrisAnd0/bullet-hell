using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

	public float speed = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (speed * Time.deltaTime, 0, 0);

		if (this.transform.position.x >= 3.5 || this.transform.position.x <= -3.5 || this.transform.position.y >= 4.5 || this.transform.position.y <= -4.5)
		{
			Destroy(this.gameObject);
		}
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "ScreenClear(Clone)")
		{
			Destroy (this.gameObject);
		}
	}
}