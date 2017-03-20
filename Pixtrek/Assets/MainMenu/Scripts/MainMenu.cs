/// <summary>
/// Main menu.
/// Attached to Main Camera
/// </summary>

using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	public Texture backgroundTexture;

	public void OnGUI()
	{
		//Display background testure (PixTrek menu)
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

		//Display menu buttons
		GUI.color = Color.white;
		GUI.backgroundColor = new Color (0, 0, 0, 1);

		if (GUI.Button (new Rect (Screen.width * .25f, Screen.height * .8f, Screen.width * .5f, Screen.height * .1f), "Sandbox")) 
		{
			print ("Starting sandbox mode");
		}
	}
}
