using UnityEngine;
using System.Collections;

public class BuildingHolder : MonoBehaviour {

	//Holds all existing models of all existing buildings

	public GameObject testObj;

	private static GameObject[] objects;

	
	// Update is called once per frame
	public void initialize()
	{
		objects = new GameObject[1];
		objects [0] = testObj;

	}

	public static GameObject getObjectByName(string name)
	{
		switch (name)
		{
		case "test":
			return (GameObject) Instantiate(objects[0]);
		default: return null;
		}
	}

}
