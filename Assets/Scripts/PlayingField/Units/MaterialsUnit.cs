using UnityEngine;
using System.Collections;

public class MaterialsUnit : MonoBehaviour {



	public Material red;

	private static Material[] materials;

	void Awake()
	{
		materials = new Material[1];
		materials [0] = red;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static Material getMaterialByName(string name)
	{
		switch (name)
		{
		case "red":
			return materials[0];
		}

		return null;
	}
}
