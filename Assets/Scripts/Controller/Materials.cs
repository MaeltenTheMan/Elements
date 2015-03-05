using UnityEngine;
using System.Collections;

public class Materials : MonoBehaviour {


	public Material fire;

	public Material water;

	private static Material f, w;
	// Use this for initialization
	void Awake() {
		f = fire;
		w = water;
	}


	// Update is called once per frame
	void Update () {
	
	}

	public static Material getMaterial(string type)
	{
		if (type.Equals("Fire"))
		    {
			return f;
		}
		if (type.Equals("Water"))
		{
			return w;
		}
		return null;
	}
}
