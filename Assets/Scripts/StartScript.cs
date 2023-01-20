using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	void OnGUI()
	{
		Rect buttonRect = new Rect (230, 100, 60, 30);
		if (GUI.Button (buttonRect, "Stage1")) {
			Application.LoadLevel ("MainScene");
		}
	}
}
