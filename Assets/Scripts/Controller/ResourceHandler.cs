using UnityEngine;
using System.Collections;

public class ResourceHandler : MonoBehaviour{

	private static int[,] resourceGeneration;

	public static void initialize()
	{
		int amountOfPlayer = PlayerHandler.getAmountOfPlayer ();
		resourceGeneration = new int[amountOfPlayer ,5];
		for (int i=0; i<amountOfPlayer; i++)
		{
			resourceGeneration[i,0]=2;
		}

	}

	public static void nextTurn()
	{
		Player[] player = PlayerHandler.getAllPlayer ();

		for (int i=0; i<player.Length; i++)
		{
			for (int j=0; j<5; j++)
			{
				player[i].addResource(resourceGeneration[i,j], j );
			}
		}
	}

	public static int[] getIncome()
	{
		int actualPlayer = PlayerHandler.getActualPlayerID();
		int[] data = new int[5];
		for (int i=0; i<data.Length; i++)
		{
			data[i] = resourceGeneration[actualPlayer, i];
		}
		return data;
	}


}
