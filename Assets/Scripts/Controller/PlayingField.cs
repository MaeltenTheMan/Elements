using UnityEngine;
using System.Collections;

public class PlayingField : MonoBehaviour {

	private static GameObject[,] hexagons ;
	public static GameObject myObj;
	private static Hexagon[,] hex;

	public GameObject aa, ab, ac, ad, ba, bb, bc, bd,  ca, cb, cc, cd;
	// Use this for initialization
	void Start () {
	}

	public void initialize()
	{
		hex = new Hexagon[4, 3];
		hexagons = new GameObject[4, 3 ];
		hexagons [0, 0] = aa;
		hexagons [1, 0] = ab;
		hexagons [2, 0] = ac;
		hexagons [3, 0] = ad;
		hexagons [0, 1] = ba;
		hexagons [1, 1] = bb;
		hexagons [2, 1] = bc;
		hexagons [3, 1] = bd;
		hexagons [0, 2] = ca;
		hexagons [1, 2] = cb;
		hexagons [2, 2] = cc;
		hexagons [3, 2] = cd;


		
		for (int i=0; i<4; i++)
		{
			for (int j=0; j<3; j++)
			{
				hex[i,j] = hexagons [i, j].AddComponent<Hexagon> ();
				hex[i,j].initialize("Fire",i,j, hexagons[i,j]); 
			}
		}

		GameObject testa = BuildingHolder.getObjectByName ("test");
		Building test = testa.AddComponent<Building> ();
		test.initialize (PlayerHandler.getAllPlayer() [0].getName(), hex[1,0], "test", testa);


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public ArrayList getNeighbors(int x, int y)
	{
		ArrayList output = new ArrayList();
		//If the element isnt in the top row
		if (y != 0) {
			//If the element isnt ih the lowest row

			output.Add(hex[x,y-1]);
			//If the element isnt touching the right side
			if (x!=hex.GetLength(0)-1)
			{
				output.Add(hex[x+1,y-1]);
			}


		}

		//If the Element isnt touching the left side
		if (x!=0)
		{
			output.Add(hex[x-1,y]);
		}
		//If the element isnt touching the right side
		if (x!=hex.GetLength(0)-1)
		{
			output.Add (hex[x+1,y]);
		}
		//If the element isnt in the lowest row
		if ( y!=hex.GetLength(1)-1)
		{
			output.Add(hex[x,y+1]);

			//If the Element isnt touching the left side
			if (x!=0)
			{
				output.Add(hex[x-1,y+1]);
			}
		}




		int test = output.Count;
		for (int i=0; i<test; i++)
		{
			print(((Hexagon)output[i]).getX() +""+ ((Hexagon)(output[i])).getY());
			((Hexagon)output[i]).getObject().renderer.material = Materials.getMaterial("Water");
		}
		return output;
	}
}
