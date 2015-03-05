using UnityEngine;
using System.Collections;

public class UnitHolder : MonoBehaviour {


	public GameObject testObj;

	private static GameObject[] objects;

	private static int[,] costs;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void initialize()
	{
		objects = new GameObject[1];
		objects [0] = testObj;

		costs = new int[1, 5];
		costs [0, 0] = 2; 
	}

	public static GameObject getUnitByName(string type)
	{
		switch (type)
		{
			case "test": return (GameObject) Instantiate (objects[0]);
			default: return null;
		}
	}

	public static int[] getCosts(int id)
	{
		return arrayBuilder(costs, id);
	}


	private static int[] arrayBuilder(int[,] array, int wantedDimension)
	{
		int[] output = new int[array.GetLength(1)];
		for (int i=0; i<array.GetLength(1);i++)
		{
			output[i] = array[wantedDimension,i];
		}



		return output;
	}
}
