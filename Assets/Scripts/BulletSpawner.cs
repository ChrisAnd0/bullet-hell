using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour {

	
	public GameObject Enemy;
	public GameObject BulletPrefab;
	public float shotDelay = 10;
	public float shotWait = 10;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (shotWait >= shotDelay) 
		{
			GameObject bul = Instantiate 
				(BulletPrefab, 
				 Enemy.transform.position, 
				 Enemy.transform.rotation) 
					as GameObject;
			
			shotWait = 0;
			
			if (shotDelay >= 10)
			{
				shotDelay -= 5;
			}
		}
		else
		{
			shotWait++;
		}
	}
}
