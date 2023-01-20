using UnityEngine;
using System.Collections;

public class DeathManager : MonoBehaviour {
	
	void OnGUI()
	{
		Rect buttonRect = new Rect (185, 200, 60, 30);
		if (GUI.Button (buttonRect, "Restart")) {
			Application.LoadLevel ("StartScene");
		}
	}
}
