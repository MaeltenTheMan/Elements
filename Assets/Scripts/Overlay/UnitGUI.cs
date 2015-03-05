using UnityEngine;
using System.Collections;

public class UnitGUI : MonoBehaviour {

	private static int width;

	private static bool isActive, isScrolling;
	// Use this for initialization

	public Texture2D build;
	public Texture2D move;

	private static int x;
	void Start () {
		isActive = false;
		width = Screen.width;
	}

	public static void activate()
	{
		isActive = true; 
		isScrolling = true;
		x = 0;
	}

	public static void deactivate()
	{
		isActive = false;
		isScrolling = false;
	}

	void OnGUI()
	{
		if (isActive)
		{
			if (isScrolling)
			{
				x++;
				if (x==120) isScrolling = false;
			}
			GUI.Box (new Rect (width-x, 50, x, 500), "");
			GUI.Label (new Rect (width-x+5, 100, 100, 100), build);
			GUI.Label (new Rect (width-x+5, 200, 100, 100), "Bewegen"); 
			GUI.Label (new Rect (width-x+5, 300, 100, 100), "Kämpfen"); 
		}
	 }


}
